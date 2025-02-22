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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
          
        }

        private void btn_obterdata_Click(object sender, EventArgs e)
        {
         tb_primeiradata.Text   = MC_Principal.SelectionStart.ToShortDateString();
         tb_ultimadata.Text = MC_Principal.SelectionEnd.ToShortDateString();
            tb_dataatual.Text = MC_Principal.TodayDate.ToString();

        }

        private void F_MonthCalendar_Load(object sender, EventArgs e)
        {

        }
    }
}
