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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          TreeNode Pais =  treeView1.Nodes.Add("pais Portugues");
            Pais.Name = "Pais";
         
             TreeNode filho1 = Pais.Nodes.Add("Angola");
            TreeNode filho2 = Pais.Nodes.Add("Moçambique");
            TreeNode filho3 = Pais.Nodes.Add("BRazil");
            TreeNode filho4 = Pais.Nodes.Add("Portugal");

            TreeNode outros = treeView1.Nodes.Add("outros");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = treeView1.SelectedNode.Name;

            if(treeView1.SelectedNode.Tag != null)
            {
            textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
            treeView1.Nodes.Remove(treeView1.Nodes["Pais"]);

            }
            catch
            {
                MessageBox.Show("Não Add ainda, razão pela qual nã é possivel remover o inexistente", "Não adicionado",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);

            }
            catch
            {
                MessageBox.Show("Nada selecionado", "vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
