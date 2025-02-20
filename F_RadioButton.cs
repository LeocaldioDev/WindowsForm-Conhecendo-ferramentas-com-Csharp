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
    public partial class F_RadioButton : Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            textBox1.Text = txt;
            MessageBox.Show(txt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (RadioButton val in groupBox2.Controls)
            {
                if (val.Checked)
                {
                    txt = val.Text;
                }
            }
            textBox1.Text = txt;
            MessageBox.Show(txt);    

        }
    }
}


