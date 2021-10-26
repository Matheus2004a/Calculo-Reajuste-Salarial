namespace WindowsFormsApplication1
{
    partial class Form_Reajuste
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
            this.sal_Mensal = new System.Windows.Forms.Label();
            this.val_Reajuste = new System.Windows.Forms.Label();
            this.text_SalMensal = new System.Windows.Forms.TextBox();
            this.btn_CalcularAjuste = new System.Windows.Forms.Button();
            this.text_ValorReajuste = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sal_Mensal
            // 
            this.sal_Mensal.AutoSize = true;
            this.sal_Mensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_Mensal.Location = new System.Drawing.Point(40, 76);
            this.sal_Mensal.Name = "sal_Mensal";
            this.sal_Mensal.Size = new System.Drawing.Size(171, 15);
            this.sal_Mensal.TabIndex = 0;
            this.sal_Mensal.Text = "Digite seu salário mensal";
            // 
            // val_Reajuste
            // 
            this.val_Reajuste.AutoSize = true;
            this.val_Reajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_Reajuste.Location = new System.Drawing.Point(258, 76);
            this.val_Reajuste.Name = "val_Reajuste";
            this.val_Reajuste.Size = new System.Drawing.Size(190, 15);
            this.val_Reajuste.TabIndex = 1;
            this.val_Reajuste.Text = "Digite o valor do reajuste(%)";
            // 
            // text_SalMensal
            // 
            this.text_SalMensal.Location = new System.Drawing.Point(43, 108);
            this.text_SalMensal.Name = "text_SalMensal";
            this.text_SalMensal.Size = new System.Drawing.Size(182, 20);
            this.text_SalMensal.TabIndex = 2;
            this.text_SalMensal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_SalMensal_KeyDown);
            // 
            // btn_CalcularAjuste
            // 
            this.btn_CalcularAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularAjuste.Location = new System.Drawing.Point(250, 177);
            this.btn_CalcularAjuste.Name = "btn_CalcularAjuste";
            this.btn_CalcularAjuste.Size = new System.Drawing.Size(137, 44);
            this.btn_CalcularAjuste.TabIndex = 4;
            this.btn_CalcularAjuste.Text = "Calcular ajuste";
            this.btn_CalcularAjuste.UseVisualStyleBackColor = true;
            this.btn_CalcularAjuste.Click += new System.EventHandler(this.btn_CalcularAjuste_Click_1);
            // 
            // text_ValorReajuste
            // 
            this.text_ValorReajuste.Location = new System.Drawing.Point(261, 108);
            this.text_ValorReajuste.Name = "text_ValorReajuste";
            this.text_ValorReajuste.Size = new System.Drawing.Size(182, 20);
            this.text_ValorReajuste.TabIndex = 5;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(88, 177);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(137, 44);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Form_Reajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 298);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.text_ValorReajuste);
            this.Controls.Add(this.btn_CalcularAjuste);
            this.Controls.Add(this.text_SalMensal);
            this.Controls.Add(this.val_Reajuste);
            this.Controls.Add(this.sal_Mensal);
            this.Name = "Form_Reajuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Reajuste_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sal_Mensal;
        private System.Windows.Forms.Label val_Reajuste;
        private System.Windows.Forms.TextBox text_SalMensal;
        private System.Windows.Forms.Button btn_CalcularAjuste;
        private System.Windows.Forms.TextBox text_ValorReajuste;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

