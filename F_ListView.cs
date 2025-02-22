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
    public partial class F_ListView : Form
    {
        string[] lvArray = new string[4];
        public F_ListView()
        {
            InitializeComponent();
          
        }

        private void F_ListView_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            
            lvArray[0] = tb_id.Text;
            lvArray[1] = tb_produto.Text;
            lvArray[2] = tb_quantidade.Text;
            lvArray[3] = tb_preco.Text;

            ListViewItem L = new ListViewItem(lvArray);
            if(string.IsNullOrEmpty(tb_id.Text) || string.IsNullOrEmpty(tb_produto.Text)
                || string.IsNullOrEmpty(tb_quantidade.Text)|| string.IsNullOrEmpty(tb_preco.Text)){
                MessageBox.Show("um dos campos esta vazio!");
            }
            else
            {
                ListView_Principal.Items.Add(L);
            }
           
            

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(ListView_Principal.SelectedItems.Count != 0)
            {
                ListView_Principal.SelectedItems[0].Remove();
            }
            else
            {
                // Exibe uma mensagem informando que nenhum item foi selecionado
                MessageBox.Show("Por favor, selecione um item para remover.", "Aviso");
            }

        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            if(ListView_Principal.SelectedItems.Count > 0)
            {

            tb_id.Text = ListView_Principal.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = ListView_Principal.SelectedItems[0].SubItems[1].Text;
            tb_quantidade.Text = ListView_Principal.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = ListView_Principal.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
