
namespace jogo_acerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtent = new System.Windows.Forms.TextBox();
            this.btnverifica = new System.Windows.Forms.Button();
            this.grbpalavra = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtd3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtd1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaltera = new System.Windows.Forms.Button();
            this.txtpalavra = new System.Windows.Forms.TextBox();
            this.grbtentativas = new System.Windows.Forms.GroupBox();
            this.lblres = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            this.grbdica = new System.Windows.Forms.GroupBox();
            this.lbld3 = new System.Windows.Forms.Label();
            this.lbld1 = new System.Windows.Forms.Label();
            this.lbld2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grblogin = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.grbpalavra.SuspendLayout();
            this.grbtentativas.SuspendLayout();
            this.grbdica.SuspendLayout();
            this.grblogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1048, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOGO DO ACERTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtent
            // 
            this.txtent.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtent.Location = new System.Drawing.Point(56, 97);
            this.txtent.Name = "txtent";
            this.txtent.Size = new System.Drawing.Size(938, 39);
            this.txtent.TabIndex = 1;
            this.txtent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtent.TextChanged += new System.EventHandler(this.txtent_TextChanged);
            // 
            // btnverifica
            // 
            this.btnverifica.BackColor = System.Drawing.Color.White;
            this.btnverifica.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverifica.ForeColor = System.Drawing.Color.Black;
            this.btnverifica.Location = new System.Drawing.Point(474, 214);
            this.btnverifica.Name = "btnverifica";
            this.btnverifica.Size = new System.Drawing.Size(189, 86);
            this.btnverifica.TabIndex = 2;
            this.btnverifica.Text = "Verificar";
            this.btnverifica.UseVisualStyleBackColor = false;
            this.btnverifica.Click += new System.EventHandler(this.btnverifica_Click);
            // 
            // grbpalavra
            // 
            this.grbpalavra.Controls.Add(this.label5);
            this.grbpalavra.Controls.Add(this.txtd3);
            this.grbpalavra.Controls.Add(this.label4);
            this.grbpalavra.Controls.Add(this.txtd2);
            this.grbpalavra.Controls.Add(this.label3);
            this.grbpalavra.Controls.Add(this.txtd1);
            this.grbpalavra.Controls.Add(this.label2);
            this.grbpalavra.Controls.Add(this.btnaltera);
            this.grbpalavra.Controls.Add(this.txtpalavra);
            this.grbpalavra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbpalavra.ForeColor = System.Drawing.Color.White;
            this.grbpalavra.Location = new System.Drawing.Point(35, 174);
            this.grbpalavra.Name = "grbpalavra";
            this.grbpalavra.Size = new System.Drawing.Size(273, 203);
            this.grbpalavra.TabIndex = 3;
            this.grbpalavra.TabStop = false;
            this.grbpalavra.Text = "Palavra";
            this.grbpalavra.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dica 3:";
            // 
            // txtd3
            // 
            this.txtd3.Enabled = false;
            this.txtd3.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtd3.Location = new System.Drawing.Point(90, 132);
            this.txtd3.Name = "txtd3";
            this.txtd3.Size = new System.Drawing.Size(177, 26);
            this.txtd3.TabIndex = 7;
            this.txtd3.Text = "Começa com C";
            this.txtd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dica 2:";
            // 
            // txtd2
            // 
            this.txtd2.Enabled = false;
            this.txtd2.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtd2.Location = new System.Drawing.Point(90, 100);
            this.txtd2.Name = "txtd2";
            this.txtd2.Size = new System.Drawing.Size(177, 26);
            this.txtd2.TabIndex = 5;
            this.txtd2.Text = "Professora de Desenvolvimento de Sistemas";
            this.txtd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dica 1:";
            // 
            // txtd1
            // 
            this.txtd1.Enabled = false;
            this.txtd1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtd1.Location = new System.Drawing.Point(90, 68);
            this.txtd1.Name = "txtd1";
            this.txtd1.Size = new System.Drawing.Size(177, 26);
            this.txtd1.TabIndex = 3;
            this.txtd1.Text = "Nome";
            this.txtd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palavra:";
            // 
            // btnaltera
            // 
            this.btnaltera.BackColor = System.Drawing.Color.White;
            this.btnaltera.Enabled = false;
            this.btnaltera.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaltera.ForeColor = System.Drawing.Color.Black;
            this.btnaltera.Location = new System.Drawing.Point(81, 164);
            this.btnaltera.Name = "btnaltera";
            this.btnaltera.Size = new System.Drawing.Size(107, 31);
            this.btnaltera.TabIndex = 1;
            this.btnaltera.Text = "Alterar";
            this.btnaltera.UseVisualStyleBackColor = false;
            this.btnaltera.Click += new System.EventHandler(this.btnaltera_Click);
            // 
            // txtpalavra
            // 
            this.txtpalavra.Enabled = false;
            this.txtpalavra.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtpalavra.Location = new System.Drawing.Point(90, 36);
            this.txtpalavra.Name = "txtpalavra";
            this.txtpalavra.Size = new System.Drawing.Size(177, 26);
            this.txtpalavra.TabIndex = 0;
            this.txtpalavra.Text = "Célia";
            this.txtpalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbtentativas
            // 
            this.grbtentativas.BackColor = System.Drawing.Color.Black;
            this.grbtentativas.Controls.Add(this.lblres);
            this.grbtentativas.Controls.Add(this.label6);
            this.grbtentativas.Controls.Add(this.lblcont);
            this.grbtentativas.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtentativas.ForeColor = System.Drawing.Color.White;
            this.grbtentativas.Location = new System.Drawing.Point(840, 156);
            this.grbtentativas.Name = "grbtentativas";
            this.grbtentativas.Size = new System.Drawing.Size(164, 126);
            this.grbtentativas.TabIndex = 4;
            this.grbtentativas.TabStop = false;
            this.grbtentativas.Text = "Tentativas";
            this.grbtentativas.Visible = false;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblres.Location = new System.Drawing.Point(108, 72);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(21, 22);
            this.lblres.TabIndex = 2;
            this.lblres.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Restantes: ";
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcont.Location = new System.Drawing.Point(67, 39);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(22, 24);
            this.lblcont.TabIndex = 0;
            this.lblcont.Text = "0";
            this.lblcont.Click += new System.EventHandler(this.lblcont_Click);
            // 
            // grbdica
            // 
            this.grbdica.Controls.Add(this.lbld3);
            this.grbdica.Controls.Add(this.lbld1);
            this.grbdica.Controls.Add(this.lbld2);
            this.grbdica.Controls.Add(this.label7);
            this.grbdica.Controls.Add(this.label9);
            this.grbdica.Controls.Add(this.label8);
            this.grbdica.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdica.ForeColor = System.Drawing.Color.White;
            this.grbdica.Location = new System.Drawing.Point(11, 412);
            this.grbdica.Name = "grbdica";
            this.grbdica.Size = new System.Drawing.Size(1023, 101);
            this.grbdica.TabIndex = 5;
            this.grbdica.TabStop = false;
            this.grbdica.Text = "Dicas";
            this.grbdica.Visible = false;
            this.grbdica.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbld3
            // 
            this.lbld3.AutoSize = true;
            this.lbld3.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbld3.Location = new System.Drawing.Point(75, 73);
            this.lbld3.Name = "lbld3";
            this.lbld3.Size = new System.Drawing.Size(127, 19);
            this.lbld3.TabIndex = 14;
            this.lbld3.Text = "Começa com C";
            this.lbld3.Visible = false;
            // 
            // lbld1
            // 
            this.lbld1.AutoSize = true;
            this.lbld1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbld1.Location = new System.Drawing.Point(75, 35);
            this.lbld1.Name = "lbld1";
            this.lbld1.Size = new System.Drawing.Size(54, 19);
            this.lbld1.TabIndex = 12;
            this.lbld1.Text = "Nome";
            // 
            // lbld2
            // 
            this.lbld2.AutoSize = true;
            this.lbld2.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbld2.Location = new System.Drawing.Point(75, 54);
            this.lbld2.Name = "lbld2";
            this.lbld2.Size = new System.Drawing.Size(358, 19);
            this.lbld2.TabIndex = 13;
            this.lbld2.Text = "Professora de Desenvolvimento de Sistemas";
            this.lbld2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dica 3:";
            this.label7.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Dica 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dica 2:";
            this.label8.Visible = false;
            // 
            // grblogin
            // 
            this.grblogin.BackColor = System.Drawing.Color.Black;
            this.grblogin.Controls.Add(this.btnlogin);
            this.grblogin.Controls.Add(this.txtsenha);
            this.grblogin.Controls.Add(this.txtnome);
            this.grblogin.Controls.Add(this.label11);
            this.grblogin.Controls.Add(this.label10);
            this.grblogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grblogin.ForeColor = System.Drawing.Color.White;
            this.grblogin.Location = new System.Drawing.Point(804, 288);
            this.grblogin.Name = "grblogin";
            this.grblogin.Size = new System.Drawing.Size(213, 132);
            this.grblogin.TabIndex = 6;
            this.grblogin.TabStop = false;
            this.grblogin.Text = "Login";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(68, 90);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(79, 32);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtsenha.Location = new System.Drawing.Point(68, 58);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(132, 26);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 12F);
            this.txtnome.Location = new System.Drawing.Point(68, 26);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(132, 26);
            this.txtnome.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(7, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Senha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(7, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome:";
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.White;
            this.btnsair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnsair.ForeColor = System.Drawing.Color.Black;
            this.btnsair.Location = new System.Drawing.Point(937, 12);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(97, 34);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1046, 525);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.grblogin);
            this.Controls.Add(this.grbdica);
            this.Controls.Add(this.grbtentativas);
            this.Controls.Add(this.grbpalavra);
            this.Controls.Add(this.btnverifica);
            this.Controls.Add(this.txtent);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jogo do Acerto";
            this.grbpalavra.ResumeLayout(false);
            this.grbpalavra.PerformLayout();
            this.grbtentativas.ResumeLayout(false);
            this.grbtentativas.PerformLayout();
            this.grbdica.ResumeLayout(false);
            this.grbdica.PerformLayout();
            this.grblogin.ResumeLayout(false);
            this.grblogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtent;
        private System.Windows.Forms.Button btnverifica;
        private System.Windows.Forms.GroupBox grbpalavra;
        private System.Windows.Forms.TextBox txtpalavra;
        private System.Windows.Forms.Button btnaltera;
        private System.Windows.Forms.GroupBox grbtentativas;
        private System.Windows.Forms.Label lblcont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtd3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbdica;
        private System.Windows.Forms.Label lbld3;
        private System.Windows.Forms.Label lbld1;
        private System.Windows.Forms.Label lbld2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grblogin;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label11;
    }
}

