namespace CFB_Cursos_Aula
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.btn_iniciarCarro = new System.Windows.Forms.Button();
            this.btn_pararCarro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(46, 41);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(137, 23);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(212, 41);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(125, 23);
            this.btn_parar.TabIndex = 1;
            this.btn_parar.Text = "parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CFB_Cursos_Aula.Properties.Resources.istockphoto_533725233_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(12, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(359, 41);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(125, 23);
            this.btn_reiniciar.TabIndex = 4;
            this.btn_reiniciar.Text = "reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // btn_iniciarCarro
            // 
            this.btn_iniciarCarro.Location = new System.Drawing.Point(49, 138);
            this.btn_iniciarCarro.Name = "btn_iniciarCarro";
            this.btn_iniciarCarro.Size = new System.Drawing.Size(125, 23);
            this.btn_iniciarCarro.TabIndex = 5;
            this.btn_iniciarCarro.Text = "iniciar carro";
            this.btn_iniciarCarro.UseVisualStyleBackColor = true;
            this.btn_iniciarCarro.Click += new System.EventHandler(this.btn_iniciarCarro_Click);
            // 
            // btn_pararCarro
            // 
            this.btn_pararCarro.Location = new System.Drawing.Point(194, 138);
            this.btn_pararCarro.Name = "btn_pararCarro";
            this.btn_pararCarro.Size = new System.Drawing.Size(125, 23);
            this.btn_pararCarro.TabIndex = 6;
            this.btn_pararCarro.Text = "parar carro";
            this.btn_pararCarro.UseVisualStyleBackColor = true;
            this.btn_pararCarro.Click += new System.EventHandler(this.btn_pararCarro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "inicio 12 - 542";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pararCarro);
            this.Controls.Add(this.btn_iniciarCarro);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_iniciar);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.Button btn_iniciarCarro;
        private System.Windows.Forms.Button btn_pararCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}