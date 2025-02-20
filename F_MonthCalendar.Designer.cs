namespace CFB_Cursos_Aula
{
    partial class F_MonthCalendar
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
            this.MC_Principal = new System.Windows.Forms.MonthCalendar();
            this.btn_obterdata = new System.Windows.Forms.Button();
            this.tb_primeiradata = new System.Windows.Forms.TextBox();
            this.tb_ultimadata = new System.Windows.Forms.TextBox();
            this.tb_dataatual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MC_Principal
            // 
            this.MC_Principal.Location = new System.Drawing.Point(29, 27);
            this.MC_Principal.Name = "MC_Principal";
            this.MC_Principal.TabIndex = 0;
            
            // 
            // btn_obterdata
            // 
            this.btn_obterdata.Location = new System.Drawing.Point(437, 27);
            this.btn_obterdata.Name = "btn_obterdata";
            this.btn_obterdata.Size = new System.Drawing.Size(185, 23);
            this.btn_obterdata.TabIndex = 1;
            this.btn_obterdata.Text = "Obter data";
            this.btn_obterdata.UseVisualStyleBackColor = true;
            this.btn_obterdata.Click += new System.EventHandler(this.btn_obterdata_Click);
            // 
            // tb_primeiradata
            // 
            this.tb_primeiradata.Location = new System.Drawing.Point(437, 66);
            this.tb_primeiradata.Name = "tb_primeiradata";
            this.tb_primeiradata.Size = new System.Drawing.Size(185, 20);
            this.tb_primeiradata.TabIndex = 2;
            // 
            // tb_ultimadata
            // 
            this.tb_ultimadata.Location = new System.Drawing.Point(437, 92);
            this.tb_ultimadata.Name = "tb_ultimadata";
            this.tb_ultimadata.Size = new System.Drawing.Size(185, 20);
            this.tb_ultimadata.TabIndex = 3;
            // 
            // tb_dataatual
            // 
            this.tb_dataatual.Location = new System.Drawing.Point(436, 127);
            this.tb_dataatual.Name = "tb_dataatual";
            this.tb_dataatual.Size = new System.Drawing.Size(185, 20);
            this.tb_dataatual.TabIndex = 4;
            // 
            // F_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 423);
            this.Controls.Add(this.tb_dataatual);
            this.Controls.Add(this.tb_ultimadata);
            this.Controls.Add(this.tb_primeiradata);
            this.Controls.Add(this.btn_obterdata);
            this.Controls.Add(this.MC_Principal);
            this.Name = "F_MonthCalendar";
            this.Text = "F_MonthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MC_Principal;
        private System.Windows.Forms.Button btn_obterdata;
        private System.Windows.Forms.TextBox tb_primeiradata;
        private System.Windows.Forms.TextBox tb_ultimadata;
        private System.Windows.Forms.TextBox tb_dataatual;
    }
}