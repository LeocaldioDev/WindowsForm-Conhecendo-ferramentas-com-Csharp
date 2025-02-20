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
    public partial class F_numericUpDown : Form
    {
        public F_numericUpDown()
        {
            InitializeComponent();
        }

        private void btn_Definervalor_Click(object sender, EventArgs e)
        {
            if(
                (int.Parse(tb_valor.Text) >= numericUpDown1.Minimum) &
                (int.Parse(tb_valor.Text) <= numericUpDown1.Maximum)
                )
                    numericUpDown1.Value = int.Parse(tb_valor.Text);

        }
    }
}
