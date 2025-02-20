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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btn_AdicionarVeiculo_Click(object sender, EventArgs e)
        {
            tb_VisualizarVeiculos.Text += tb_CampoVeiculo.Text + Environment.NewLine;
            tb_CampoVeiculo.Clear();
        }

        private void btn_ApagarVeiculos_Click(object sender, EventArgs e)
        {
            tb_VisualizarVeiculos.Clear();
        }

        private void btn_EnviarTela2_Click(object sender, EventArgs e)
        {
            TelaVisualizacao tela2 = new TelaVisualizacao(tb_VisualizarVeiculos.Text,this);

            tela2.ShowDialog();


        }

        private void formularioVerdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox verde = new F_CheckBox();
            verde.ShowDialog();


        }

        private void formularioAzulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox azul = new F_CheckedListBox();
            azul.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox combo = new F_ComboBox();
            combo.Show();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker datatime = new F_DateTimePicker();
            datatime.Show();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel ff = new F_LinkLabel();
            ff.Show();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.Show();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView lv = new F_ListView();
            lv.Show();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox mtb = new F_MaskedTextBox();
            mtb.Show();
        }

        private void monthCalenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar Mc = new F_MonthCalendar();
            Mc.Show();
        }

        private void CMS_principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "tsm_Restaurar")
            {
                this.WindowState = FormWindowState.Normal; 
            }
            else if(e.ClickedItem.Name == "tsm_Mensagem") {
                MessageBox.Show(@"Esta mensagem é oficial da aplicação","Atenção",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            }else if (e.ClickedItem.Name == "tsm_Sair")
            {
                this.Close();
             
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_numericUpDown nud = new F_numericUpDown();
            nud.Show();
        }

        private void pictureBoxEArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox_arquivo pba = new F_PictureBox_arquivo();
            pba.Show();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_progressbar pb = new F_progressbar();
            pb.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_RadioButton rb = new F_RadioButton();
            rb.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F_TrackBar tb = new F_TrackBar();
            tb.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            F_TreeView tv = new F_TreeView();
            tv.Show();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_WebBrowser wb = new F_WebBrowser();
            wb.Show();
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SplitContainer sc = new F_SplitContainer();
            sc.Show();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TabControl tc = new F_TabControl();
            tc.Show();
        }

        private void tableLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TableLayoutPanel tlp = new F_TableLayoutPanel();
            tlp.Show();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ToolStripContainer tsc = new F_ToolStripContainer();
            tsc.Show();
        }

        private void backGroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_BackGroundWorker bgw = new F_BackGroundWorker();
            bgw.Show();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Timer t = new F_Timer();
            t.Show();
        }

        private void sqliteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Sqlite sql = new F_Sqlite();
            sql.Show();
        }
    }
}
