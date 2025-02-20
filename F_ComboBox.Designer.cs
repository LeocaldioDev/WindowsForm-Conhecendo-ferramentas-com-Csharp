namespace CFB_Cursos_Aula
{
    partial class F_ComboBox
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
            this.cb_Veiculo = new System.Windows.Forms.ComboBox();
            this.btn_selecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.tb_AdicionaTransporte = new System.Windows.Forms.TextBox();
            this.btn_adicionarTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Veiculo
            // 
            this.cb_Veiculo.FormattingEnabled = true;
            this.cb_Veiculo.Items.AddRange(new object[] {
            "Carro",
            "Navio",
            "Avião",
            "Trem"});
            this.cb_Veiculo.Location = new System.Drawing.Point(12, 33);
            this.cb_Veiculo.Name = "cb_Veiculo";
            this.cb_Veiculo.Size = new System.Drawing.Size(216, 21);
            this.cb_Veiculo.TabIndex = 0;
            // 
            // btn_selecionados
            // 
            this.btn_selecionados.Location = new System.Drawing.Point(281, 33);
            this.btn_selecionados.Name = "btn_selecionados";
            this.btn_selecionados.Size = new System.Drawing.Size(232, 23);
            this.btn_selecionados.TabIndex = 1;
            this.btn_selecionados.Text = "Mostrar Selecionado";
            this.btn_selecionados.UseVisualStyleBackColor = true;
            this.btn_selecionados.Click += new System.EventHandler(this.btn_selecionados_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(281, 63);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(232, 23);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar elementos";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(281, 93);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(232, 23);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar elementos";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // tb_AdicionaTransporte
            // 
            this.tb_AdicionaTransporte.Location = new System.Drawing.Point(281, 223);
            this.tb_AdicionaTransporte.Name = "tb_AdicionaTransporte";
            this.tb_AdicionaTransporte.Size = new System.Drawing.Size(232, 20);
            this.tb_AdicionaTransporte.TabIndex = 4;
            // 
            // btn_adicionarTransporte
            // 
            this.btn_adicionarTransporte.Location = new System.Drawing.Point(281, 269);
            this.btn_adicionarTransporte.Name = "btn_adicionarTransporte";
            this.btn_adicionarTransporte.Size = new System.Drawing.Size(232, 23);
            this.btn_adicionarTransporte.TabIndex = 5;
            this.btn_adicionarTransporte.Text = "Adicionar Transporte";
            this.btn_adicionarTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarTransporte.Click += new System.EventHandler(this.btn_adicionarTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 373);
            this.Controls.Add(this.btn_adicionarTransporte);
            this.Controls.Add(this.tb_AdicionaTransporte);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_selecionados);
            this.Controls.Add(this.cb_Veiculo);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.Load += new System.EventHandler(this.F_ComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_selecionados;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.TextBox tb_AdicionaTransporte;
        private System.Windows.Forms.Button btn_adicionarTransporte;
        private System.Windows.Forms.ComboBox cb_Veiculo;
    }
}