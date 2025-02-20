using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Cursos_Aula
{
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mtb_1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                MessageBox.Show(mtb_1.Text);
            }
            else
            {
                MessageBox.Show("o campo esta desabilitado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                mtb_2.PasswordChar = '*';

               
            }
            else
            {
                mtb_2.PasswordChar = '\0';


            }
        }
    }
}
