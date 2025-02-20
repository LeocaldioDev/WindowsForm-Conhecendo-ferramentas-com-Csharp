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
    public partial class F_filho : Form
    {
        F_CheckBox verde;
        public F_filho()
        {
            InitializeComponent();
            if (Application.OpenForms["F_CheckBox"].Created)
            {
                verde = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                cb_carro.Checked = verde.cb_carro.Checked;
                cb_aviao.Checked = verde.cb_aviao.Checked;
                cb_Navio.Checked = verde.cb_Navio.Checked;
            }
           
           
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            verde.cb_carro.Checked = cb_carro.Checked;
            
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            verde.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_Navio_CheckedChanged(object sender, EventArgs e)
        {
            verde.cb_Navio.Checked = cb_Navio.Checked;
            
        }

        private void F_filho_Load(object sender, EventArgs e)
        {

        }
    }
}
