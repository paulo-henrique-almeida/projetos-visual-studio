namespace WindowsFormsApp1
{
    partial class gire_a_moeda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbldinheiro = new System.Windows.Forms.Label();
            this.btnjogar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldolar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(4)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(149, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 354);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblresultado);
            this.panel2.Controls.Add(this.btnjogar);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 346);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbldinheiro
            // 
            this.lbldinheiro.AutoSize = true;
            this.lbldinheiro.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldinheiro.ForeColor = System.Drawing.Color.White;
            this.lbldinheiro.Location = new System.Drawing.Point(499, 46);
            this.lbldinheiro.Name = "lbldinheiro";
            this.lbldinheiro.Size = new System.Drawing.Size(32, 37);
            this.lbldinheiro.TabIndex = 1;
            this.lbldinheiro.Text = "0";
            this.lbldinheiro.Visible = false;
            // 
            // btnjogar
            // 
            this.btnjogar.BackColor = System.Drawing.Color.Black;
            this.btnjogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(4)))));
            this.btnjogar.FlatAppearance.BorderSize = 3;
            this.btnjogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnjogar.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjogar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnjogar.Location = new System.Drawing.Point(320, 255);
            this.btnjogar.Name = "btnjogar";
            this.btnjogar.Size = new System.Drawing.Size(124, 52);
            this.btnjogar.TabIndex = 0;
            this.btnjogar.Text = "Jogar";
            this.btnjogar.UseVisualStyleBackColor = false;
            this.btnjogar.Click += new System.EventHandler(this.btnjogar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(3, 86);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(783, 111);
            this.lblresultado.TabIndex = 1;
            this.lblresultado.Text = "Você";
            this.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblresultado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gire a Moeda v3.0";
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolar.ForeColor = System.Drawing.Color.White;
            this.lbldolar.Location = new System.Drawing.Point(476, 46);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(32, 37);
            this.lbldolar.TabIndex = 2;
            this.lbldolar.Text = "$";
            this.lbldolar.Visible = false;
            // 
            // gire_a_moeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1119, 596);
            this.Controls.Add(this.lbldolar);
            this.Controls.Add(this.lbldinheiro);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gire_a_moeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gire a Moeda v3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnjogar;
        private System.Windows.Forms.Label lbldinheiro;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldolar;
    }
}

