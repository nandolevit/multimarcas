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
    public partial class FormCarregando : Form
    {

        public FormCarregando()
        {
            InitializeComponent();
            
        }

        private void FormCarregando_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.FecharFormCarregando = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.FecharFormCarregando == true)
                this.DialogResult = DialogResult.Yes;
        }

        private void FormCarregando_Load(object sender, EventArgs e)
        {

        }
    }
}
