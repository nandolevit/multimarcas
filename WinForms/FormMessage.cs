using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WinForms
{
	public static class FormMessage
	{
		public static void ShowMessegeInfo(string mensagem)
		{
			MessageBox.Show(mensagem, "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void ShowMessegeWarning(string mensagem)
		{
			MessageBox.Show(mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public static DialogResult ShowMessegeQuestion(string mensagem)
		{
			return MessageBox.Show(mensagem, "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
	}
}

