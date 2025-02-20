namespace CFB_Cursos_Aula
{
    partial class F_CheckBox
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_Abilitar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Checked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(13, 42);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(13, 66);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(52, 17);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Location = new System.Drawing.Point(13, 89);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(54, 17);
            this.cb_Navio.TabIndex = 2;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            // 
            // cb_Abilitar
            // 
            this.cb_Abilitar.AutoSize = true;
            this.cb_Abilitar.Location = new System.Drawing.Point(22, 226);
            this.cb_Abilitar.Name = "cb_Abilitar";
            this.cb_Abilitar.Size = new System.Drawing.Size(57, 17);
            this.cb_Abilitar.TabIndex = 3;
            this.cb_Abilitar.Text = "Abilitar";
            this.cb_Abilitar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_Abilitar.UseVisualStyleBackColor = true;
            this.cb_Abilitar.CheckedChanged += new System.EventHandler(this.cb_Abilitar_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Checked
            // 
            this.btn_Checked.Location = new System.Drawing.Point(184, 101);
            this.btn_Checked.Name = "btn_Checked";
            this.btn_Checked.Size = new System.Drawing.Size(75, 23);
            this.btn_Checked.TabIndex = 5;
            this.btn_Checked.Text = "Checked";
            this.btn_Checked.UseVisualStyleBackColor = true;
            this.btn_Checked.Click += new System.EventHandler(this.btn_Checked_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 346);
            this.Controls.Add(this.btn_Checked);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Abilitar);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.Name = "F_CheckBox";
            this.Text = "F_Checkbox";
            this.Load += new System.EventHandler(this.F_CheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Checked;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_Navio;
        public System.Windows.Forms.CheckBox cb_Abilitar;
    }
}