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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("esta vazio!");
            }
            else
            {
                if(int.Parse(textBox1.Text) > 100 | int.Parse(textBox1.Text) < 0)
                {
                    MessageBox.Show("O valor esta fora da margem de 0-100");
                    textBox1.Clear();
                    return;
                    
                }
                trackBar1.Value = int.Parse(textBox1.Text);
                label1.Text = textBox1.Text;
            }
            
        }

        private void F_TrackBar_Load(object sender, EventArgs e)
        {

        }
    }
}
