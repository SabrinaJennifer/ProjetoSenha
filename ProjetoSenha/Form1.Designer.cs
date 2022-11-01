namespace ProjetoSenha
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
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnPreferencial = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNormal
            // 
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(79, 64);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(178, 89);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnPreferencial
            // 
            this.btnPreferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreferencial.Location = new System.Drawing.Point(79, 242);
            this.btnPreferencial.Name = "btnPreferencial";
            this.btnPreferencial.Size = new System.Drawing.Size(178, 89);
            this.btnPreferencial.TabIndex = 1;
            this.btnPreferencial.Text = "Preferencial";
            this.btnPreferencial.UseVisualStyleBackColor = true;
            this.btnPreferencial.Click += new System.EventHandler(this.btnPreferencial_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.BackColor = System.Drawing.Color.BurlyWood;
            this.lbSenha.Location = new System.Drawing.Point(462, 64);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(226, 281);
            this.lbSenha.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.btnPreferencial);
            this.Controls.Add(this.btnNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnPreferencial;
        private System.Windows.Forms.Label lbSenha;
    }
}

