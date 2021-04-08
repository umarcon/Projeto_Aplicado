namespace gestao_condominio.Forms
{
    partial class Relatorios
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtDeVisitante = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtAteVisitante = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtAteLocacoes = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDeLocacoes = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data De";
            // 
            // dtDeVisitante
            // 
            this.dtDeVisitante.Location = new System.Drawing.Point(94, 46);
            this.dtDeVisitante.Name = "dtDeVisitante";
            this.dtDeVisitante.Size = new System.Drawing.Size(219, 20);
            this.dtDeVisitante.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Até";
            // 
            // dtAteVisitante
            // 
            this.dtAteVisitante.Location = new System.Drawing.Point(94, 71);
            this.dtAteVisitante.Name = "dtAteVisitante";
            this.dtAteVisitante.Size = new System.Drawing.Size(219, 20);
            this.dtAteVisitante.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Até";
            // 
            // dtAteLocacoes
            // 
            this.dtAteLocacoes.Location = new System.Drawing.Point(427, 70);
            this.dtAteLocacoes.Name = "dtAteLocacoes";
            this.dtAteLocacoes.Size = new System.Drawing.Size(219, 20);
            this.dtAteLocacoes.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data De";
            // 
            // dtDeLocacoes
            // 
            this.dtDeLocacoes.Location = new System.Drawing.Point(427, 45);
            this.dtDeLocacoes.Name = "dtDeLocacoes";
            this.dtDeLocacoes.Size = new System.Drawing.Size(219, 20);
            this.dtDeLocacoes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Visitantes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Locações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Gerar Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(427, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Gerar Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "OBS: Os arquivos serão exportados para a pasta C:\\Relatorios com o nomedorelatori" +
    "o_data.xlsx";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 162);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 162);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtAteLocacoes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDeLocacoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtAteVisitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDeVisitante);
            this.Name = "Relatorios";
            this.Text = "Relatorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDeVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtAteVisitante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtAteLocacoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDeLocacoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Splitter splitter1;
    }
}