namespace CFB_Cursos_Aula
{
    partial class F_numericUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_Definervalor = new System.Windows.Forms.Button();
            this.tb_valor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // btn_Definervalor
            // 
            this.btn_Definervalor.Location = new System.Drawing.Point(359, 36);
            this.btn_Definervalor.Name = "btn_Definervalor";
            this.btn_Definervalor.Size = new System.Drawing.Size(75, 23);
            this.btn_Definervalor.TabIndex = 1;
            this.btn_Definervalor.Text = "Definir Valor";
            this.btn_Definervalor.UseVisualStyleBackColor = true;
            this.btn_Definervalor.Click += new System.EventHandler(this.btn_Definervalor_Click);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(234, 38);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 2;
            // 
            // F_numericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 311);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.btn_Definervalor);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "F_numericUpDown";
            this.Text = "F_numericUpDown";
            this.Load += new System.EventHandler(this.F_numericUpDown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_Definervalor;
        private System.Windows.Forms.TextBox tb_valor;
    }
}