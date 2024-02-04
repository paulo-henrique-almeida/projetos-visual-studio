
namespace projetinho
{
    partial class Form1
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblmassa = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtmassa = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btncalc = new System.Windows.Forms.Button();
            this.lblimc = new System.Windows.Forms.Label();
            this.lblimccalc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(506, 49);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(421, 75);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Calcular IMC";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.ForeColor = System.Drawing.Color.White;
            this.lblaltura.Location = new System.Drawing.Point(522, 162);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(188, 42);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Altura (m):";
            // 
            // lblmassa
            // 
            this.lblmassa.AutoSize = true;
            this.lblmassa.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmassa.ForeColor = System.Drawing.Color.White;
            this.lblmassa.Location = new System.Drawing.Point(522, 239);
            this.lblmassa.Name = "lblmassa";
            this.lblmassa.Size = new System.Drawing.Size(209, 42);
            this.lblmassa.TabIndex = 2;
            this.lblmassa.Text = "Massa (kg):";
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.Location = new System.Drawing.Point(766, 162);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(150, 48);
            this.txtaltura.TabIndex = 3;
            this.txtaltura.Text = "1";
            this.txtaltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtaltura.TextChanged += new System.EventHandler(this.txtaltura_TextChanged);
            // 
            // txtmassa
            // 
            this.txtmassa.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmassa.Location = new System.Drawing.Point(766, 239);
            this.txtmassa.Name = "txtmassa";
            this.txtmassa.Size = new System.Drawing.Size(150, 48);
            this.txtmassa.TabIndex = 4;
            this.txtmassa.Text = "0";
            this.txtmassa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmassa.TextChanged += new System.EventHandler(this.txtmassa_TextChanged);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Red;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.Location = new System.Drawing.Point(1293, 32);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(87, 41);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(632, 340);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(191, 62);
            this.btncalc.TabIndex = 6;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.ForeColor = System.Drawing.Color.White;
            this.lblimc.Location = new System.Drawing.Point(439, 467);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(271, 56);
            this.lblimc.TabIndex = 7;
            this.lblimc.Text = "Seu IMC é:";
            this.lblimc.Visible = false;
            // 
            // lblimccalc
            // 
            this.lblimccalc.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimccalc.ForeColor = System.Drawing.Color.White;
            this.lblimccalc.Location = new System.Drawing.Point(716, 467);
            this.lblimccalc.Name = "lblimccalc";
            this.lblimccalc.Size = new System.Drawing.Size(114, 56);
            this.lblimccalc.TabIndex = 8;
            this.lblimccalc.Text = "IMC aparecerá aqui";
            this.lblimccalc.Visible = false;
            this.lblimccalc.Click += new System.EventHandler(this.lblimccalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1457, 624);
            this.Controls.Add(this.lblimccalc);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.txtmassa);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.lblmassa);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblmassa;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtmassa;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Label lblimccalc;
    }
}

