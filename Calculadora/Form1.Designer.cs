namespace Calculadora
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
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.txt_operacao = new System.Windows.Forms.TextBox();
            this.lbl_algoritmo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.Location = new System.Drawing.Point(12, 73);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(100, 40);
            this.cmd_calcular.TabIndex = 1;
            this.cmd_calcular.Text = "Calcular";
            this.cmd_calcular.UseVisualStyleBackColor = true;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(133, 73);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(93, 40);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // txt_operacao
            // 
            this.txt_operacao.Location = new System.Drawing.Point(12, 34);
            this.txt_operacao.MaxLength = 30;
            this.txt_operacao.Name = "txt_operacao";
            this.txt_operacao.Size = new System.Drawing.Size(214, 20);
            this.txt_operacao.TabIndex = 0;
            this.txt_operacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_operacao_KeyDown);
            // 
            // lbl_algoritmo
            // 
            this.lbl_algoritmo.AutoSize = true;
            this.lbl_algoritmo.Location = new System.Drawing.Point(12, 9);
            this.lbl_algoritmo.Name = "lbl_algoritmo";
            this.lbl_algoritmo.Size = new System.Drawing.Size(100, 13);
            this.lbl_algoritmo.TabIndex = 3;
            this.lbl_algoritmo.Text = "Escreva o algoritmo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 125);
            this.Controls.Add(this.lbl_algoritmo);
            this.Controls.Add(this.txt_operacao);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.TextBox txt_operacao;
        private System.Windows.Forms.Label lbl_algoritmo;
    }
}

