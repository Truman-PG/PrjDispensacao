namespace PrjDispensacao
{
    partial class frmPrincipal
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
            button1 = new Button();
            btnLinProducao = new Button();
            btnDispensacao = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(59, 51);
            button1.Name = "button1";
            button1.Size = new Size(179, 34);
            button1.TabIndex = 0;
            button1.Text = "Materia Prima";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLinProducao
            // 
            btnLinProducao.Cursor = Cursors.Hand;
            btnLinProducao.Location = new Point(59, 117);
            btnLinProducao.Name = "btnLinProducao";
            btnLinProducao.Size = new Size(179, 34);
            btnLinProducao.TabIndex = 1;
            btnLinProducao.Text = "Linha Produção";
            btnLinProducao.UseVisualStyleBackColor = true;
            btnLinProducao.Click += btnLinProducao_Click;
            // 
            // btnDispensacao
            // 
            btnDispensacao.Cursor = Cursors.Hand;
            btnDispensacao.Location = new Point(59, 183);
            btnDispensacao.Name = "btnDispensacao";
            btnDispensacao.Size = new Size(179, 34);
            btnDispensacao.TabIndex = 2;
            btnDispensacao.Text = "Dispensação";
            btnDispensacao.UseVisualStyleBackColor = true;
            btnDispensacao.Click += btnDispensacao_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(286, 264);
            Controls.Add(btnDispensacao);
            Controls.Add(btnLinProducao);
            Controls.Add(button1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnLinProducao;
        private Button btnDispensacao;
    }
}