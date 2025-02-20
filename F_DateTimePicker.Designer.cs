namespace CFB_Cursos_Aula
{
    partial class F_DateTimePicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_Datas = new System.Windows.Forms.DateTimePicker();
            this.tb_Campodata = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tbn_obterData = new System.Windows.Forms.Button();
            this.btn_SetarData = new System.Windows.Forms.Button();
            this.Btn_Hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_Datas
            // 
            this.dtp_Datas.Location = new System.Drawing.Point(12, 26);
            this.dtp_Datas.Name = "dtp_Datas";
            this.dtp_Datas.Size = new System.Drawing.Size(244, 20);
            this.dtp_Datas.TabIndex = 0;
            // 
            // tb_Campodata
            // 
            this.tb_Campodata.Location = new System.Drawing.Point(12, 63);
            this.tb_Campodata.Name = "tb_Campodata";
            this.tb_Campodata.Size = new System.Drawing.Size(244, 20);
            this.tb_Campodata.TabIndex = 1;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 105);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(58, 20);
            this.tb_dia.TabIndex = 2;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(94, 105);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(56, 20);
            this.tb_mes.TabIndex = 3;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(170, 105);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(86, 20);
            this.tb_ano.TabIndex = 4;
            // 
            // tbn_obterData
            // 
            this.tbn_obterData.Location = new System.Drawing.Point(294, 26);
            this.tbn_obterData.Name = "tbn_obterData";
            this.tbn_obterData.Size = new System.Drawing.Size(142, 23);
            this.tbn_obterData.TabIndex = 5;
            this.tbn_obterData.Text = "Obter Data";
            this.tbn_obterData.UseVisualStyleBackColor = true;
            this.tbn_obterData.Click += new System.EventHandler(this.tbn_obterData_Click);
            // 
            // btn_SetarData
            // 
            this.btn_SetarData.Location = new System.Drawing.Point(294, 63);
            this.btn_SetarData.Name = "btn_SetarData";
            this.btn_SetarData.Size = new System.Drawing.Size(142, 23);
            this.btn_SetarData.TabIndex = 6;
            this.btn_SetarData.Text = "Setar data";
            this.btn_SetarData.UseVisualStyleBackColor = true;
            this.btn_SetarData.Click += new System.EventHandler(this.btn_SetarData_Click);
            // 
            // Btn_Hoje
            // 
            this.Btn_Hoje.Location = new System.Drawing.Point(294, 103);
            this.Btn_Hoje.Name = "Btn_Hoje";
            this.Btn_Hoje.Size = new System.Drawing.Size(142, 23);
            this.Btn_Hoje.TabIndex = 7;
            this.Btn_Hoje.Text = "Hoje";
            this.Btn_Hoje.UseVisualStyleBackColor = true;
            this.Btn_Hoje.Click += new System.EventHandler(this.Btn_Hoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 340);
            this.Controls.Add(this.Btn_Hoje);
            this.Controls.Add(this.btn_SetarData);
            this.Controls.Add(this.tbn_obterData);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_Campodata);
            this.Controls.Add(this.dtp_Datas);
            this.Name = "F_DateTimePicker";
            this.Text = "F_DateTimePicker";
            this.Load += new System.EventHandler(this.F_DateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Datas;
        private System.Windows.Forms.TextBox tb_Campodata;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Button tbn_obterData;
        private System.Windows.Forms.Button btn_SetarData;
        private System.Windows.Forms.Button Btn_Hoje;
    }
}