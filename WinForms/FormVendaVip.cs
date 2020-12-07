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
    public partial class FormVendaVip : Form
    {
        public FormVendaVip()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
        }

        private void FormVendaVip_Load(object sender, EventArgs e)
        {
            buttonAvulso.Select();
        }

        private void buttonVip_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void buttonAvulso_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormVendaVip_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    DialogResult = DialogResult.OK;
                    break;
                case Keys.F2:
                    DialogResult = DialogResult.Yes;
                    break;
                default:
                    break;
            }
        }
    }
}
