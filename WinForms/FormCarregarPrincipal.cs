using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinForms
{
    public partial class FormCarregarPrincipal : Form
    {
        Thread thread;
        public FormCarregarPrincipal()
        {
            InitializeComponent();
        }

        private void FormCarregarPrincipal_Load(object sender, EventArgs e)
        {
            thread = new Thread(Abrir);
            thread.Start();
        }

        private void Abrir()
        {
            FormCarregando formCarregando = new FormCarregando();
            formCarregando.ShowDialog();
            //formCarregando.Dispose(); 
            thread.Abort();
        }
        private void FormCarregarPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.OpenForms["FormCarregando"].DialogResult = DialogResult.Yes;
        }
    }
}
