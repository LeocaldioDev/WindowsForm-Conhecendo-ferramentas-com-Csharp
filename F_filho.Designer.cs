namespace CFB_Cursos_Aula
{
    partial class F_filho
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
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Location = new System.Drawing.Point(12, 71);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(54, 17);
            this.cb_Navio.TabIndex = 5;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            this.cb_Navio.CheckedChanged += new System.EventHandler(this.cb_Navio_CheckedChanged);
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(12, 48);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(52, 17);
            this.cb_aviao.TabIndex = 4;
            this.cb_aviao.Text = "avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            this.cb_aviao.CheckedChanged += new System.EventHandler(this.cb_aviao_CheckedChanged);
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(12, 24);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 3;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            this.cb_carro.CheckedChanged += new System.EventHandler(this.cb_carro_CheckedChanged);
            // 
            // F_filho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 202);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_filho";
            this.Text = "F_filho";
            this.Load += new System.EventHandler(this.F_filho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Navio;
        private System.Windows.Forms.CheckBox cb_aviao;
        private System.Windows.Forms.CheckBox cb_carro;
    }
}