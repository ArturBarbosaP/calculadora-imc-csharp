namespace RevisaoProva_03
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
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(169, 28);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(133, 20);
            this.txt_peso.TabIndex = 0;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(169, 73);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(133, 20);
            this.txt_altura.TabIndex = 1;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(27, 32);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(125, 13);
            this.lbl_peso.TabIndex = 2;
            this.lbl_peso.Text = "Insira seu peso (ex: 69,2)";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(27, 77);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(128, 13);
            this.lbl_altura.TabIndex = 3;
            this.lbl_altura.Text = "Insira sua altura (ex: 1,80)";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(30, 120);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(272, 41);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular IMC";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 189);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Button btn_calcular;
    }
}

