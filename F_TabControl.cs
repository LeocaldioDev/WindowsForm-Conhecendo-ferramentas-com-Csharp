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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_novatab_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_nometab.Text))
            {
                TabPage pagina = new TabPage();
                pagina.Name = tb_nometab.Text;
                pagina.Text = tb_nometab.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;

                tabControl1.TabPages.Add(pagina);
                tb_nometab.Clear();
                DefinirMaximo();
            }
            else
            {
                MessageBox.Show("Digite o nome da nova tab");
                tb_nometab.Focus();
            }
            
        }

        private void DefinirMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count-1;
        }

        private void btn_removertab_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            DefinirMaximo();
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            DefinirMaximo();
        }

        private void btn_posicionarNaTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = int.Parse(numericUpDown1.Value.ToString());
            
        }
    }
}
