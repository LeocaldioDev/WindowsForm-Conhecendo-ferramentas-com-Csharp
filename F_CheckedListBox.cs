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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {


            String text = "";
            
                foreach (string val in clb_Veiculos.CheckedItems)
                {
                    text += val.ToString() + ", ";

                }
                if(!string.IsNullOrEmpty(text))
            {

               int valor = text.LastIndexOf(',');
               text = text.Remove(valor);
            }

            MessageBox.Show(text);
            

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clb_Veiculos.Items.Clear();
        }

        private void btn_ResetarLista_Click(object sender, EventArgs e)
        {
            clb_Veiculos.Items.Add("Carro", false);
            clb_Veiculos.Items.Add("Avião", false);
            clb_Veiculos.Items.Add("Navio", false);
            clb_Veiculos.Items.Add("Ônibus", false);
            clb_Veiculos.Items.Add("Trem", false);
        }

        private void btn_adicionarTransporte_Click(object sender, EventArgs e)
        {

           // string novotexto = tb_Adicionartransporte.Text.Trim();

            if (clb_Veiculos.Items.Contains(tb_Adicionartransporte.Text)) {
            MessageBox.Show("Este item ja existe na lista");

            }
            else
            {
                clb_Veiculos.Items.Add(tb_Adicionartransporte.Text, false);
            }
            tb_Adicionartransporte.Clear();
            tb_Adicionartransporte.Focus();
        }
    }
}
