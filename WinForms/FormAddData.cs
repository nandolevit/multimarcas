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
    public partial class FormAddData : Form
    {
        public string textoData { get; set; }

        public FormAddData()
        {
            InitializeComponent();
            FormFormat formFormat = new FormFormat(this);
            formFormat.formatar();
            this.AcceptButton = buttonAdd;
            textBoxDia.MaxLength = 2;
            textBoxAno.MaxLength = 4;
        }

        private void FormAddData_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDia.Text, out int dia) && int.TryParse(textBoxAno.Text, out int ano))
            {
                if (comboBoxMes.SelectedIndex >= 0)
                {
                    string novaData = Convert.ToString(string.Format("{0:00}", dia)) + "/" + string.Format("{0:00}", comboBoxMes.SelectedIndex + 1) + "/" + Convert.ToString(ano);

                    if (DateTime.TryParse(novaData, out DateTime data))
                    {
                        textoData = novaData;
                        DialogResult = DialogResult.Yes;
                    }
                    else
                        FormMessage.ShowMessegeWarning("Insira uma data válida!");
                }
            }
            else
                FormMessage.ShowMessegeWarning("Insira o dia e o ano válido!");
        }
    }
}
