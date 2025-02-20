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
    public partial class F_WebBrowser : Form
    {
        private string home = null;
        public F_WebBrowser()
        {
            InitializeComponent();
        }

        private void Navegar()
        {
            webBrowser1.Navigate(tb_barrapesquisa.Text);
        }
        private void tb_barrapesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Navegar();
            }
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            Navegar();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if(home == null)
            {
                webBrowser1.GoHome();
            }
            else
            {
                webBrowser1.Navigate(home);
            }
            
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            btn_voltar.Enabled = webBrowser1.CanGoForward;
        }
        private void btn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }


        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            btn_proximo.Enabled = webBrowser1.CanGoForward;
        }



        private void btn_parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void btn_definirhome_Click(object sender, EventArgs e)
        {
            home = tb_barrapesquisa.Text;
        }
    }
}
