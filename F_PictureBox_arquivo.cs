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
    public partial class F_PictureBox_arquivo : Form
    {
        public F_PictureBox_arquivo()
        {
            InitializeComponent();
        }

        private void btn_logo1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ImagemCriada;
            label1.Text = Properties.Resources.Leo;
            label2.Text = Properties.Resources.Leocaldio;
        }

        private void btn_logo2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.assedio_2;
            label2.Text = Properties.Resources.Leo;
            label1.Text = Properties.Resources.Leocaldio;
        }

        private void btn_logo3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.assedio;
        }
    }
}
