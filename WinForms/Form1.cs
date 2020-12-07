using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjTransfer;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public static IPAddress[] localAdress;
        //define se o modo offline será definido
        public static bool Offline { get; set; }
        //stringConnect para o modo offline
        public string ConexaoOffline { get { return "server=LOCALHOST;user id=nandolevit;password=@wizykovisc87;SslMode=none;database=levittech"; } }
        public static bool ConectedSystem { get; set; }
        public static bool FecharFormCarregando { get; set; }
        public static EmpresaInfo Empresa { get; set; }
        public static UnidadeInfo Unidade { get; set; }
        public static UserInfo User { get; set; }
        public static ComputerInfo Server { get; set; }
        public static ComputerInfo Computer { get; set; }
        public static string Caminho { get { return @"C:\Users\Public\LevitSoft\emp.lvt"; } }
        public static string FileNameEmp { get { return "emp.lvt"; } }
        public static string FileNameUnid { get { return "unid.lvt"; } }
        public static string FileNameComp { get { return "comp.lvt"; } }
        public static UserLoginInfo Login { get; set; } //registra a hora do login e a saída do usuário
        public static bool encerrarThread;

        UserNegocio userNegocio;
        EmpresaNegocios negocioEmp;
        Thread threadLogin;
        UserColecao LoginGeral = new UserColecao();
        CaixaNegocios caixaNegocios;
        SerializarNegocios serializarNegocios = new SerializarNegocios(Caminho);
        AccessLogin accessLogin;
        UnidadeInfo unidadeInfo;

        public Form1()
        {
            InitializeComponent();
        }

        public static void ConfiguracaoRede()
        {
            Computer.comphostname = Dns.GetHostName();
            localAdress = Dns.GetHostAddresses(Computer.comphostname);
            Computer.compip = localAdress[localAdress.Length - 1].ToString();
            Computer.compuser = (User == null) ? 0 : User.useid;

            foreach (NetworkInterface inter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (inter.OperationalStatus == OperationalStatus.Up)
                {
                    if (inter.NetworkInterfaceType == NetworkInterfaceType.Ethernet || inter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    {
                        Computer.compmac = inter.GetPhysicalAddress().ToString();
                        Computer.compadaptador = inter.Description;
                    }
                }
            }
        }

        private bool Desserializar()
        {
            Empresa = (serializarNegocios.DesserializarObjeto(FileNameEmp) as EmpresaInfo);
            Unidade = (serializarNegocios.DesserializarObjeto(FileNameUnid) as UnidadeInfo);
            Computer = (serializarNegocios.DesserializarObjeto(FileNameComp) as ComputerInfo);

            if (Empresa == null || Unidade == null || Computer == null)
                return false;
            else
                return true;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente();
        }

        private void MenuItemCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private bool TestarOffline()
        {
            if (Server != null)
                return true;
            else
            {
                FormMessage.ShowMessegeWarning("Não é possível ativar o Modo Offline para este dispositivo!");
                return false;
            }
        }

        private void AtivarModoOffline(EmpresaInfo emp)
        {
            Offline = true;

            if (threadLogin != null)
                threadLogin.Abort();

            string conexao = string.Empty;

            userNegocio = new UserNegocio();
            if (userNegocio.TestarConexaoSemPersistencia(ConexaoOffline))
                conexao = ConexaoOffline;
            else
            {
                IPAddress[] ipServer = Dns.GetHostAddresses(Server.comphostname);
                conexao = ConexaoOffline.Replace("LOCALHOST", ipServer[ipServer.Length - 1].ToString());
            }

            EmpresaNegocios empresaNegocios = new EmpresaNegocios(conexao);
            Empresa = empresaNegocios.ConsultarEmpresaSysIdOffline(emp.empcod);
            Empresa.empconexao = conexao;
            this.Text += " :: " + Empresa.empfantasia;
            this.Text += " :: MODO OFFLINE";
            panelOnline.Width = 0;
            menuStripPrincipal.Enabled = false;
            buttonCliente.Text = "Cliente";
            buttonBuscarCliente.Text = "Buscar";
            buttonOs.Text = "Servico";
            panelPrincipal.BackColor = Color.Maroon;

            if (Application.OpenForms["FormOnline"] != null)
                Application.OpenForms["FormOnline"].Close();

            buttonAutorizada.Enabled = false;
            buttonProduto.Enabled = false;
            buttonProdutoBuscar.Enabled = false;
            buttonVendas.Enabled = false;
            buttonEntrada.Enabled = false;
            buttonPeriodo.Enabled = false;
            buttonCaixa.Enabled = false;
            buttonTurno.Enabled = false;
            buttonSenha.Enabled = false;
            LogarNovamente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserNegocio testar = new UserNegocio();
            Computer = new ComputerInfo();
            ConfiguracaoRede();
            toolStripStatusLabelPcNome.Text = Computer.comphostname;
            toolStripStatusLabelIP.Text = Computer.compip;

            if (Offline)
            {
                AtivarModoOffline(Empresa);
            }
            else
            {
                if (Desserializar())
                {

                    negocioEmp = new EmpresaNegocios(Empresa.empconexao);
                    threadLogin = new Thread(UpdateUserLogin);
                    threadLogin.Start();

                    if (testar.TestarConexao())
                    {

                        if (Unidade != null)
                        {
                            ComputerColecao colecao = negocioEmp.ConsultarComputadorIdUnid(Unidade.uniid);

                            if (colecao != null)
                                foreach (ComputerInfo comp in colecao)
                                    if (comp.compserver)
                                    {
                                        Server = comp;
                                        break;
                                    }
                        }

                        if (Empresa != null)
                        {
                            Empresa = negocioEmp.ConsultarEmpresaSysId(Empresa.empcod);

                            if (Empresa.empativada == 1)
                            {
                                TimeSpan timeSpan = Empresa.empdataativo.Subtract(DateTime.Now.Date);
                                if (timeSpan.Days > 0)
                                {
                                    if (timeSpan.Days < 7)
                                        FormMessage.ShowMessegeWarning(Empresa.empobs.Replace("**", timeSpan.Days.ToString()));

                                    InicializarSistema();
                                    this.Text += " :: " + Empresa.empfantasia;
                                }
                                else
                                {
                                    FormMessage.ShowMessegeWarning("Seu sistema está bloqueado!");
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                FormMessage.ShowMessegeWarning("Seu sistema está bloqueado!");
                                Application.Exit();
                            }
                        }
                        else
                            FormMessage.ShowMessegeWarning("Falha!");
                    }
                    else
                        ModoOfflineEncerrarSistema();
                }
                else
                    AbrirFormEmpresa();

                if (Empresa != null)
                    caixaNegocios = new CaixaNegocios(Empresa.empconexao);
            }
        }

        private void AbrirFormEmpresa()
        {
            FormEmpresa formEmpresa = new FormEmpresa();
            formEmpresa.ShowDialog(this);
            formEmpresa.Dispose();
            Application.Exit();
        }

        public void ModoOfflineEncerrarSistema()
        {
            if (FormMessage.ShowMessegeQuestion("Falha na conexão. Deseja trabalhar no MODO OFFLINE?") == DialogResult.Yes)
            {
                ModoOffline();
            }
            else
                Application.Exit();
        }

        public void ExecutarThread(Thread thread)
        {
            thread.Start();
            //FormCarregarPrincipal formCarregarPrincipal = new FormCarregarPrincipal();
            //formCarregarPrincipal.Show();

            DateTime temp1 = DateTime.Now;
            DateTime temp2;

            while (true)
            {
                temp2 = DateTime.Now;
                TimeSpan span = temp2 - temp1;

                if (span.TotalSeconds > 90)
                {
                    //Form1.FecharFormCarregando = true;
                    FormMessage.ShowMessegeWarning("Falha, não foi passível concluir a tarefa, tente novamente!");
                    break;
                }

                if (encerrarThread)
                {
                    panelCentral.Visible = false;
                    break;
                }
            }

            //Form1.FecharFormCarregando = true;
            //formCarregarPrincipal.Close();
            thread.Abort();
            encerrarThread = false;
        }

        private void InicializarSistema()
        {
            AoCarregar();
        }

        private void AoCarregar()
        {
            toolStripStatusLabelUsuario.Text = "USUÁRIO: ";
            toolStripStatusLabelLocal.Text = "UNIDADE: ";

            accessLogin = new AccessLogin(Form1.Empresa.empconexao);
            negocioEmp = new EmpresaNegocios(Form1.Empresa.empconexao);
            if (accessLogin.UserExist())
            {
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog(this);

                if (formLogin.DialogResult == DialogResult.Yes)
                {
                    if (User.usenovologin == 0)
                    {
                        panelPrincipal.Enabled = true;

                        if (Offline == false)
                        {
                            menuStripPrincipal.Enabled = true;

                            //Login = userNegocio.ConsultarUserLogin(Login.loginid);
                            panelOnline.Visible = true;
                            FormOnline formOnline = new FormOnline();
                            formOnline.MdiParent = this;
                            panelOnline.Controls.Add(formOnline);
                            formOnline.Show();
                        }

                        toolStripStatusLabelUsuario.Text += User.uselogin;
                        toolStripStatusLabelLocal.Text += Unidade.uniunidade;
                        buttonCliente.Select();
                    }
                    else
                    {
                        FormAlterarSenha formAlterarSenha = new FormAlterarSenha(User);
                        formAlterarSenha.ShowDialog(this);

                        if (formAlterarSenha.DialogResult == DialogResult.Yes)
                            AoCarregar();

                        formAlterarSenha.Dispose();
                    }
                }

                formLogin.Dispose();

            }
            else
            {
                EmpresaNegocios empresaNegocios = new EmpresaNegocios(Empresa.empconexao);
                UnidadeInfo unid = empresaNegocios.ConsultarUnidadeSede();

                PreencherUnid();

                if (unid == null)
                    empresaNegocios.InsertUnidade(unidadeInfo, true);

                FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(unidadeInfo);
                formCadastroPessoa.ShowDialog(this);

                if (formCadastroPessoa.DialogResult == DialogResult.Yes)
                    AoCarregar();

                formCadastroPessoa.Dispose();
            }
        }

        private void UpdateUserLogin()
        {
            userNegocio = new UserNegocio(Empresa.empconexao);

            DateTime tempo = DateTime.Now;
            DateTime tempo1;
            DateTime emp1 = DateTime.Now;
            DateTime emp2;
            bool test = true;

            while (true)
            {
                tempo1 = DateTime.Now;
                TimeSpan min = tempo1 - tempo;

                if (min.TotalSeconds > 1)
                {
                    ConectedSystem = userNegocio.TestarConexaoSemPersistencia();

                    if (!ConectedSystem)
                    {
                        if (test == true)
                            FormMessage.ShowMessegeWarning("A internet caiu! Aguarde, tentaremos restabelecer a conexão...");

                        test = false;
                    }
                    else
                    {
                        if (test == false)
                            FormMessage.ShowMessegeWarning("Conexão estabelecida...");

                        test = true;
                    }

                    if (ConectedSystem)
                    {
                        if (min.TotalSeconds > 15)
                        {
                            tempo = DateTime.Now;

                            if (Login != null)
                                userNegocio.UpdateUserLogin(Login.loginid);

                            ConfiguracaoRede();
                            negocioEmp.UpdateComputadorLog(Computer);
                        }

                        emp2 = DateTime.Now;
                        TimeSpan min2 = emp2 - emp1;

                        if (min2.TotalMinutes > 60)
                        {
                            emp1 = DateTime.Now;

                            EmpresaNegocios empresaNegocios = new EmpresaNegocios(Empresa.empconexao);

                            Empresa = empresaNegocios.ConsultarEmpresaSysId(Empresa.empcod);

                            if (Empresa.empativada == 0)
                            {
                                MessageBox.Show("Seu sistema está bloqueado!");
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private UnidadeInfo PreencherUnid()
        {
            unidadeInfo = new UnidadeInfo
            {
                unibairro = Empresa.empbairro,
                unicep = Empresa.empcep,
                unicidade = Empresa.empcidade,
                unicnpj = Empresa.empcnpj,
                unicomplemento = Empresa.empcomplemento,
                uniemail = Empresa.empemail,
                unifantasia = Empresa.empfantasia,
                uniidEmpresa = Empresa.empcod,
                unilogradouro = Empresa.emplogradouro,
                unirazaoSocial = Empresa.emprazaosocial,
                unireferencia = Empresa.empreferencia,
                unisite = Empresa.empsite,
                unitelefone = Empresa.emptelefone,
                uniuf = Empresa.empuf,
                uniunidade = " " + Empresa.empbairro + "(SEDE)",
                unifundada = Empresa.empfundada
            };

            return unidadeInfo;
        }

        private void MenuItemOrdemServ_Click(object sender, EventArgs e)
        {
            BuscarServico();
        }

        private void MenuItemFuncionario_Click(object sender, EventArgs e)
        {
            FuncInfo funcInfo = new FuncInfo();
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(funcInfo);
            FormAbertos(formCadastroPessoa);
        }

        private void MenuItemAlterarSenha_Click(object sender, EventArgs e)
        {
            FecharForm();
            FormAlterarSenha formAlterarSenha = new FormAlterarSenha(true);
            formAlterarSenha.ShowDialog(this);

            if (formAlterarSenha.DialogResult == DialogResult.Yes)
                AoCarregar();

            formAlterarSenha.Dispose();
        }

        private bool AbertoForm(Form form)
        {
            bool ver = true;

            string nome = string.Empty;

            foreach (Form frm in Application.OpenForms)
            {
                nome += frm.Name + Environment.NewLine;

                if (form.Name == frm.Name)
                {
                    frm.Activate();
                    ver = false;
                    FormMessage.ShowMessegeInfo("Fomulário já está aberto");
                }
            }

            if (ver)
                return ver;
            else
                return false;
        }

        private void MenuItemConsultarFunc_Click(object sender, EventArgs e)
        {
            FormFuncConsultar formFuncConsultar = new FormFuncConsultar();
            FormAbertos(formFuncConsultar);
        }

        private void MenuItemSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogarNovamente();
        }
        private void LogarNovamente()
        {
            User = null;
            FecharForm();
            AoCarregar();
        }

        private void FecharForm()
        {
            List<Form> formList = new List<Form>();

            foreach (Form frm in Application.OpenForms)
                if (frm.Name != "Form1")
                    formList.Add(frm);

            foreach (Form frm1 in formList)
                frm1.Close();

            //menuStripPrincipal.Enabled = false;
            //panelPrincipal.Enabled = false;
        }

        private void FormAbertos(Form form, bool panel = false)
        {
            if (AbertoForm(form))
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.MdiParent = this;
                panelCentral.Controls.Add(form);
                form.Show();
                form.MaximizeBox = true;

                if (panel)
                {
                    panelOnline.Visible = false;
                    form.FormClosed += new FormClosedEventHandler(this.EventoTornarPanelOnlineVisivel);
                }
                else
                    form.Select();


                form.WindowState = FormWindowState.Maximized;
            }
        }

        private void EventoTornarPanelOnlineVisivel(object sender, EventArgs e)
        {
            panelOnline.Visible = true;
        }

        private void MenuItemSobre_Click(object sender, EventArgs e)
        {
            FormEmpresa formEmpresa = new FormEmpresa(Empresa);
            FormAbertos(formEmpresa);
        }

        private void MenuItemEntradaSaida_Click(object sender, EventArgs e)
        {
            FormEntradaSaida formEntradaSaida = new FormEntradaSaida();
            FormAbertos(formEntradaSaida);
        }

        private void MenuItemProduto_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            FormAbertos(formProdutos);
        }

        private void MenuItemLancarEstoque_Click(object sender, EventArgs e)
        {
            FormEstoqueContagem formEstoqueContagem = new FormEstoqueContagem();
            FormAbertos(formEstoqueContagem, true);
        }


        private void MenuItemProdutos_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void MenuItemPedido_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            FormAbertos(formPedido);
        }

        private void MenuItemVender_Click(object sender, EventArgs e)
        {
            Vender();
        }

        private void AbrirVenda()
        {
            FormVenda formVenda = new FormVenda();
            FormAbertos(formVenda, true);
        }

        private void MenuItemUnidade_Click(object sender, EventArgs e)
        {
            FormUnidade formUnidade = new FormUnidade();
            FormAbertos(formUnidade);
        }

        private void MenuItemLancarEstoque_Click_1(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormProdEstoque formProdEstoque = new FormProdEstoque();
                FormAbertos(formProdEstoque);
            }
        }

        private void MenuItemAutorizada_Click(object sender, EventArgs e)
        {
            AutorizadaInfo autorizadaInfo = new AutorizadaInfo();
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(autorizadaInfo);
            FormAbertos(formCadastroPessoa);
        }

        private void MenuItemimprimir2Via_Click(object sender, EventArgs e)
        {
            FormCupom formCupom = new FormCupom();
            FormAbertos(formCupom);
        }

        private void MenuItemCaixa_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();

            if (caixa.CaixaAberto() != null)
            {
                FormCaixa formCaixa = new FormCaixa(EnumCaixa.Caixa);
                FormAbertos(formCaixa);
            }
            else
                caixa.VerificarCaixa();
        }

        private void MenuItempagamentoRecebimentoDiversos_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormLancamentos formLancamentos = new FormLancamentos(true);
                FormAbertos(formLancamentos);
            }
            
        }

        private void MenuItemSangria_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormSangria formSangria = new FormSangria();
                FormAbertos(formSangria);
            }
            
        }

        private void MenuItemTrocaDeTurno_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormCaixa formCaixa = new FormCaixa(EnumCaixa.Turno);
                FormAbertos(formCaixa);
            }
        }

        private void AbrirVendaPeriodo()
        {
            FormVendaRelatorio formVendaRelatorio = new FormVendaRelatorio();
            FormAbertos(formVendaRelatorio, true);
        }

        private void MenuItemVendaPeriodo_Click(object sender, EventArgs e)
        {
            AbrirVendaPeriodo();
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
            toolStripStatusLabelTime.Text.ToUpper();

            if (Offline == true)
            {
                if (!ConectedSystem && User != null)
                {
                    if (Application.OpenForms["FormConexao"] == null)
                    {
                        FormConexao formConexao = new FormConexao();
                        formConexao.ShowDialog();
                        formConexao.Dispose();
                    }
                }
            }
        }
        
        private void buttonCliente_Click(object sender, EventArgs e)
        {
            CadCliente();
        }

        private void CadCliente()
        {
            //FrmCliente frmCliente = new FrmCliente();
            ClienteInfo cli = new ClienteInfo();
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(cli);
            FormAbertos(formCadastroPessoa);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            FornecedorInfo fornecedorInfo = new FornecedorInfo();
            FormCadastroPessoa formCadastroPessoa = new FormCadastroPessoa(fornecedorInfo);
            FormAbertos(formCadastroPessoa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProdutos formProdutos = new FormProdutos();
            FormAbertos(formProdutos);
        }

        private void buttonOs_Click(object sender, EventArgs e)
        {
            BuscarServico();
        }

        private void BuscarServico()
        {
            FormConsultarServico formConsultarServico = new FormConsultarServico();
            FormAbertos(formConsultarServico, true);
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            FormClienteConsultar formClienteConsultar = new FormClienteConsultar();
            FormAbertos(formClienteConsultar);
        }

        private void buttonProdutoBuscar_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void BuscarProduto()
        {
            FormProdutosConsultar formProdutosConsultar = new FormProdutosConsultar();
            FormAbertos(formProdutosConsultar);
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            Vender();
        }

        private void Vender()
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                AbrirVenda();
            }
        }

        private void buttonPeriodo_Click(object sender, EventArgs e)
        {
            AbrirVendaPeriodo();
            //formVendaRelatorio.WindowState = FormWindowState.Maximized;
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            FormEntradaSaida formEntradaSaida = new FormEntradaSaida();
            FormAbertos(formEntradaSaida, true);
        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            FecharForm();
            FormAlterarSenha formAlterarSenha = new FormAlterarSenha(true);
            formAlterarSenha.ShowDialog(this);

            if (formAlterarSenha.DialogResult == DialogResult.Yes)
                AoCarregar();

            formAlterarSenha.Dispose();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void buttonCaixa_Click(object sender, EventArgs e)
        {
            AbrirCaixa(EnumCaixa.Caixa);
        }

        private void AbrirCaixa(EnumCaixa enumCaixa)
        {
            Caixa caixa = new Caixa();
            if (caixa.VerificarCaixa())
            {
                FormCaixa formCaixa = new FormCaixa(enumCaixa);
                FormAbertos(formCaixa);
            }
        }

        private void buttonTurno_Click(object sender, EventArgs e)
        {
            AbrirCaixa(EnumCaixa.Turno);
        }

        private void relatorioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioVendaVendedor formRelatorioVendaVendedor = new FormRelatorioVendaVendedor();
            FormAbertos(formRelatorioVendaVendedor, true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Offline == false)
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        CadCliente();
                        break;
                    case Keys.F2:
                        BuscarCliente();
                        break;
                    case Keys.F3:
                        BuscarServico();
                        break;
                    case Keys.F4:
                        BuscarProduto();
                        break;
                    case Keys.F5:
                        Vender();
                        break;
                    case Keys.F6:
                        break;
                    case Keys.F7:
                        break;
                    case Keys.F8:
                        break;
                    case Keys.F9:
                        break;
                    case Keys.F10:
                        break;
                    case Keys.F12:
                        break;
                    case Keys.LWin:
                    case Keys.RWin:
                        break;
                    default:
                        break;
                }
            }
        }

        private void contarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEstoqueContagem formEstoqueContagem = new FormEstoqueContagem(true);
            FormAbertos(formEstoqueContagem, true);
        }

        private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutoEstoqueDetalhes formProdutoEstoqueDetalhes = new FormProdutoEstoqueDetalhes();
            FormAbertos(formProdutoEstoqueDetalhes, true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadLogin != null)
                threadLogin.Abort();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ModoOfflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModoOffline();
        }

        private void ModoOffline()
        {
            if (TestarOffline())
            {
                if (FormMessage.ShowMessegeQuestion("Deseja ativar o modo Offline? Todas as janelas serão fechadas!") == DialogResult.Yes)
                {
                    EmpresaInfo emp = (serializarNegocios.DesserializarObjeto(FileNameEmp) as EmpresaInfo);
                    AtivarModoOffline(emp);
                }
            }
        }

        private void ToolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTaxa_Click(object sender, EventArgs e)
        {
            using (FormTaxa formTaxa = new FormTaxa())
            {
                formTaxa.ShowDialog(this);
            }
            //FormAbertos(formTaxa);
        }
    }
}

