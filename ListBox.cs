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
    public partial class ListBox : Form
    {
        List<string> listaCarros = new List<string>();
        public ListBox()
        {
            InitializeComponent();
            Atualizar();
        }

        private void tbn_Adicionar_Click(object sender, EventArgs e)
        {
            listaCarros.Add(tb_carro.Text);
            Atualizar();
            tb_carro.Clear();
            tb_carro.Focus();
            
        }

        public void Atualizar()
        {
            lb_carros.DataSource = null;
            lb_carros.DataSource = listaCarros;
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {  
            int removido = lb_carros.SelectedIndex;
            if (!(removido < 0)) {
            listaCarros.RemoveAt(removido);
            Atualizar();
            }
            else
            {
                MessageBox.Show("nada selecionado papai");
            }
        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            if (!(lb_carros.SelectedIndex < 0)) { 
                string valor = listaCarros[lb_carros.SelectedIndex].ToString();
                tb_carro.Text = valor;
            }
            else
            {
                MessageBox.Show("Não é possivel obter nada!");
            }
            

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            listaCarros.Clear();
            Atualizar();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {

        }
    }

}
