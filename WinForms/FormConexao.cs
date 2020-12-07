using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FormConexao : Form
    {
        public FormConexao()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.ConectedSystem)
                this.DialogResult = DialogResult.Yes;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.ModoOfflineEncerrarSistema();
        }
    }
}
