namespace WindowsFormsVetoresMatrizes
{
    partial class FormArray
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
            this.lblVetores = new System.Windows.Forms.Label();
            this.btnListarVetor = new System.Windows.Forms.Button();
            this.lbxVetor = new System.Windows.Forms.ListBox();
            this.cbxVetor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVetores
            // 
            this.lblVetores.AutoSize = true;
            this.lblVetores.Location = new System.Drawing.Point(72, 87);
            this.lblVetores.Name = "lblVetores";
            this.lblVetores.Size = new System.Drawing.Size(103, 13);
            this.lblVetores.TabIndex = 0;
            this.lblVetores.Text = "Listagem de Vetores";
            // 
            // btnListarVetor
            // 
            this.btnListarVetor.Location = new System.Drawing.Point(75, 246);
            this.btnListarVetor.Name = "btnListarVetor";
            this.btnListarVetor.Size = new System.Drawing.Size(75, 23);
            this.btnListarVetor.TabIndex = 1;
            this.btnListarVetor.Text = "Listar";
            this.btnListarVetor.UseVisualStyleBackColor = true;
            this.btnListarVetor.Click += new System.EventHandler(this.btnListarVetor_Click);
            // 
            // lbxVetor
            // 
            this.lbxVetor.FormattingEnabled = true;
            this.lbxVetor.Location = new System.Drawing.Point(75, 115);
            this.lbxVetor.Name = "lbxVetor";
            this.lbxVetor.Size = new System.Drawing.Size(120, 95);
            this.lbxVetor.TabIndex = 2;
            // 
            // cbxVetor
            // 
            this.cbxVetor.FormattingEnabled = true;
            this.cbxVetor.Location = new System.Drawing.Point(74, 44);
            this.cbxVetor.Name = "cbxVetor";
            this.cbxVetor.Size = new System.Drawing.Size(121, 21);
            this.cbxVetor.TabIndex = 3;
            // 
            // FormArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 329);
            this.Controls.Add(this.cbxVetor);
            this.Controls.Add(this.lbxVetor);
            this.Controls.Add(this.btnListarVetor);
            this.Controls.Add(this.lblVetores);
            this.Name = "FormArray";
            this.Text = "Formulário de Vetores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVetores;
        private System.Windows.Forms.Button btnListarVetor;
        private System.Windows.Forms.ListBox lbxVetor;
        private System.Windows.Forms.ComboBox cbxVetor;
    }
}

