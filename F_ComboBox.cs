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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_selecionados_Click(object sender, EventArgs e)
        {
           
                MessageBox.Show(cb_Veiculo.SelectedItem.ToString() ?? "Vazio");
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cb_Veiculo.Items.Clear();
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            cb_Veiculo.Items.Add("Carro");
            cb_Veiculo.Items.Add("Navio");
            cb_Veiculo.Items.Add("Mota");
            cb_Veiculo.Items.Add("Trem");
         
        }

        private void btn_adicionarTransporte_Click(object sender, EventArgs e)
        {
            if (cb_Veiculo.Items.Contains(tb_AdicionaTransporte.Text))
            {
                MessageBox.Show("Este item ja existe");
            }
            else
            {
                cb_Veiculo.Items.Add(tb_AdicionaTransporte.Text);
            }

       
        }

        private void F_ComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
