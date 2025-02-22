namespace CFB_Cursos_Aula
{
    partial class F_PictureBox_arquivo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logo1 = new System.Windows.Forms.Button();
            this.btn_logo2 = new System.Windows.Forms.Button();
            this.btn_logo3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logo1
            // 
            this.btn_logo1.Location = new System.Drawing.Point(328, 105);
            this.btn_logo1.Name = "btn_logo1";
            this.btn_logo1.Size = new System.Drawing.Size(75, 23);
            this.btn_logo1.TabIndex = 3;
            this.btn_logo1.Text = "Logo1";
            this.btn_logo1.UseVisualStyleBackColor = true;
            this.btn_logo1.Click += new System.EventHandler(this.btn_logo1_Click);
            // 
            // btn_logo2
            // 
            this.btn_logo2.Location = new System.Drawing.Point(328, 135);
            this.btn_logo2.Name = "btn_logo2";
            this.btn_logo2.Size = new System.Drawing.Size(75, 23);
            this.btn_logo2.TabIndex = 4;
            this.btn_logo2.Text = "Logo2";
            this.btn_logo2.UseVisualStyleBackColor = true;
            this.btn_logo2.Click += new System.EventHandler(this.btn_logo2_Click);
            // 
            // btn_logo3
            // 
            this.btn_logo3.Location = new System.Drawing.Point(328, 165);
            this.btn_logo3.Name = "btn_logo3";
            this.btn_logo3.Size = new System.Drawing.Size(75, 23);
            this.btn_logo3.TabIndex = 5;
            this.btn_logo3.Text = "Logo3";
            this.btn_logo3.UseVisualStyleBackColor = true;
            this.btn_logo3.Click += new System.EventHandler(this.btn_logo3_Click);
            // 
            // F_PictureBox_arquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 304);
            this.Controls.Add(this.btn_logo3);
            this.Controls.Add(this.btn_logo2);
            this.Controls.Add(this.btn_logo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_PictureBox_arquivo";
            this.Text = "F_PictureBox_arquivo";
            this.Load += new System.EventHandler(this.F_PictureBox_arquivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_logo1;
        private System.Windows.Forms.Button btn_logo2;
        private System.Windows.Forms.Button btn_logo3;
    }
}