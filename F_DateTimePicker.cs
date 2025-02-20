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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void tbn_obterData_Click(object sender, EventArgs e)
        {
            tb_Campodata.Text = dtp_Datas.Text;
        }

        private void btn_SetarData_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(tb_dia.Text);
            int mes = int.Parse(tb_mes.Text);
            int ano = int.Parse(tb_ano.Text);

            DateTime tr = new DateTime(ano,mes,dia);
            dtp_Datas.Value = tr;

        }

        private void Btn_Hoje_Click(object sender, EventArgs e)
        {
            dtp_Datas.Value = DateTime.Today;
        }

        private void F_DateTimePicker_Load(object sender, EventArgs e)
        {

        }
    }
}
