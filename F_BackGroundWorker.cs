using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CFB_Cursos_Aula
{
    public partial class F_BackGroundWorker : Form
    {
        int count= 0;
        public F_BackGroundWorker()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for(int i = 0; i< 1000; i++) {
                count++;
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(10);
            
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = "Trabalhando";
            label2.Text = count.ToString();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "Terminado";
            MessageBox.Show("Terminado");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
