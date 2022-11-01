namespace ProjetoSenha
{
    partial class TelaChamada
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
            this.lbtela = new System.Windows.Forms.Label();
            this.btnchamar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtela
            // 
            this.lbtela.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbtela.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbtela.Location = new System.Drawing.Point(391, 21);
            this.lbtela.Name = "lbtela";
            this.lbtela.Size = new System.Drawing.Size(369, 310);
            this.lbtela.TabIndex = 0;
            this.lbtela.Text = "label1";
            // 
            // btnchamar
            // 
            this.btnchamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchamar.Location = new System.Drawing.Point(57, 203);
            this.btnchamar.Name = "btnchamar";
            this.btnchamar.Size = new System.Drawing.Size(205, 128);
            this.btnchamar.TabIndex = 1;
            this.btnchamar.Text = "Chamar";
            this.btnchamar.UseVisualStyleBackColor = true;
            this.btnchamar.Click += new System.EventHandler(this.btnchamar_Click);
            // 
            // TelaChamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnchamar);
            this.Controls.Add(this.lbtela);
            this.Name = "TelaChamada";
            this.Text = "TelaChamada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbtela;
        private System.Windows.Forms.Button btnchamar;
    }
}