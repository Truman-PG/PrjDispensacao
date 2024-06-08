namespace PrjDispensacao
{
    partial class frmDispensacao
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            ltbLinhaProducao = new ListBox();
            btnDispensar = new Button();
            cmbMateriaPrima = new ComboBox();
            txtQuantidade = new TextBox();
            txtNumero = new TextBox();
            lblLinProd = new Label();
            lblMateriaPrima = new Label();
            lblQuantidade = new Label();
            lblNumero = new Label();
            dtvDispensacao = new DataGridView();
            dispensacaoBindingSource = new BindingSource(components);
            dispensacaoBindingSource1 = new BindingSource(components);
            dispensacaoBindingSource2 = new BindingSource(components);
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoMatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codigoLinDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvDispensacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dispensacaoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dispensacaoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dispensacaoBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ltbLinhaProducao);
            panel1.Controls.Add(btnDispensar);
            panel1.Controls.Add(cmbMateriaPrima);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(lblLinProd);
            panel1.Controls.Add(lblMateriaPrima);
            panel1.Controls.Add(lblQuantidade);
            panel1.Controls.Add(lblNumero);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 281);
            panel1.TabIndex = 0;
            // 
            // ltbLinhaProducao
            // 
            ltbLinhaProducao.FormattingEnabled = true;
            ltbLinhaProducao.ItemHeight = 25;
            ltbLinhaProducao.Location = new Point(9, 110);
            ltbLinhaProducao.Name = "ltbLinhaProducao";
            ltbLinhaProducao.Size = new Size(180, 129);
            ltbLinhaProducao.TabIndex = 2;
            // 
            // btnDispensar
            // 
            btnDispensar.Cursor = Cursors.Hand;
            btnDispensar.Location = new Point(275, 195);
            btnDispensar.Name = "btnDispensar";
            btnDispensar.Size = new Size(112, 34);
            btnDispensar.TabIndex = 4;
            btnDispensar.Text = "Dispensar";
            btnDispensar.UseVisualStyleBackColor = true;
            btnDispensar.Click += btnDispensar_Click;
            // 
            // cmbMateriaPrima
            // 
            cmbMateriaPrima.FormattingEnabled = true;
            cmbMateriaPrima.Location = new Point(275, 32);
            cmbMateriaPrima.Name = "cmbMateriaPrima";
            cmbMateriaPrima.Size = new Size(182, 33);
            cmbMateriaPrima.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(275, 110);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(150, 31);
            txtQuantidade.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(9, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(150, 31);
            txtNumero.TabIndex = 0;
            // 
            // lblLinProd
            // 
            lblLinProd.AutoSize = true;
            lblLinProd.Location = new Point(3, 82);
            lblLinProd.Name = "lblLinProd";
            lblLinProd.Size = new Size(160, 25);
            lblLinProd.TabIndex = 3;
            lblLinProd.Text = "Linha de produção";
            // 
            // lblMateriaPrima
            // 
            lblMateriaPrima.AutoSize = true;
            lblMateriaPrima.Location = new Point(275, 4);
            lblMateriaPrima.Name = "lblMateriaPrima";
            lblMateriaPrima.Size = new Size(121, 25);
            lblMateriaPrima.TabIndex = 2;
            lblMateriaPrima.Text = "Matéria Prima";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(275, 82);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(105, 25);
            lblQuantidade.TabIndex = 1;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(3, 6);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(77, 25);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            // 
            // dtvDispensacao
            // 
            dtvDispensacao.AutoGenerateColumns = false;
            dtvDispensacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDispensacao.Columns.AddRange(new DataGridViewColumn[] { numeroDataGridViewTextBoxColumn, codigoMatDataGridViewTextBoxColumn, codigoLinDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn });
            dtvDispensacao.DataSource = dispensacaoBindingSource2;
            dtvDispensacao.Location = new Point(3, 290);
            dtvDispensacao.Name = "dtvDispensacao";
            dtvDispensacao.RowHeadersWidth = 62;
            dtvDispensacao.Size = new Size(669, 325);
            dtvDispensacao.TabIndex = 1;
            // 
            // dispensacaoBindingSource
            // 
            dispensacaoBindingSource.DataSource = typeof(Models.Dispensacao);
            // 
            // dispensacaoBindingSource1
            // 
            dispensacaoBindingSource1.DataSource = typeof(Models.Dispensacao);
            // 
            // dispensacaoBindingSource2
            // 
            dispensacaoBindingSource2.DataSource = typeof(Models.Dispensacao);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.MinimumWidth = 8;
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoMatDataGridViewTextBoxColumn
            // 
            codigoMatDataGridViewTextBoxColumn.DataPropertyName = "NomeMat";
            codigoMatDataGridViewTextBoxColumn.HeaderText = "Matéria Prima";
            codigoMatDataGridViewTextBoxColumn.MinimumWidth = 8;
            codigoMatDataGridViewTextBoxColumn.Name = "codigoMatDataGridViewTextBoxColumn";
            codigoMatDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoLinDataGridViewTextBoxColumn
            // 
            codigoLinDataGridViewTextBoxColumn.DataPropertyName = "NomeLin";
            codigoLinDataGridViewTextBoxColumn.HeaderText = "Linha de Produção";
            codigoLinDataGridViewTextBoxColumn.MinimumWidth = 8;
            codigoLinDataGridViewTextBoxColumn.Name = "codigoLinDataGridViewTextBoxColumn";
            codigoLinDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 8;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmDispensacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(676, 618);
            Controls.Add(dtvDispensacao);
            Controls.Add(panel1);
            Name = "frmDispensacao";
            Text = "Dispensação";
            Load += frmDispensacao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtvDispensacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dispensacaoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dispensacaoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dispensacaoBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblLinProd;
        private Label lblMateriaPrima;
        private Label lblQuantidade;
        private Label lblNumero;
        private Button btnDispensar;
        private ComboBox cmbMateriaPrima;
        private TextBox txtQuantidade;
        private TextBox txtNumero;
        private DataGridView dtvDispensacao;
        private BindingSource dispensacaoBindingSource;
        private ListBox ltbLinhaProducao;
        private BindingSource dispensacaoBindingSource1;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoMatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoLinDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private BindingSource dispensacaoBindingSource2;
    }
}