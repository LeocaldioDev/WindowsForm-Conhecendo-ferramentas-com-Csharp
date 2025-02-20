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
    public partial class TelaVisualizacao : Form
    {
        FormularioPrincipal x;
        public TelaVisualizacao(string v, FormularioPrincipal formula)
        {
            InitializeComponent();
            tb_Tela2.Text = v;
            x=formula;
        }

        private void TelaVisualizacao_FormClosed(object sender, FormClosedEventArgs e)
        {
           x.tb_VisualizarVeiculos.Text = tb_Tela2.Text;


        }
    }
}
