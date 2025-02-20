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
    public partial class F_CheckBox : Form
    {
        public int valor;
        protected int numero = 10;
        List<CheckBox>check_opcoes = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            check_opcoes.Add(cb_carro);
            check_opcoes.Add(cb_aviao);
            check_opcoes.Add(cb_Navio);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text="";

            foreach(var valor in check_opcoes)
            {
                if (valor.Checked)
                {
                    text += valor.Text+ ", ";
                }


            }

            MessageBox.Show(text);

        }

        private void cb_Abilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Abilitar.Checked){
                MessageBox.Show("esta Abilitado!");
            }
            
        }

        private void btn_Checked_Click(object sender, EventArgs e)
        {
            F_filho f_filho = new F_filho();
            f_filho.Show();
        }

        private void F_CheckBox_Load(object sender, EventArgs e)
        {

        }
    }
}
