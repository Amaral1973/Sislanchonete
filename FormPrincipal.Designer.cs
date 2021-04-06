
namespace SisLanchonete
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbVendas = new System.Windows.Forms.PictureBox();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.lblNumProdutos = new System.Windows.Forms.Label();
            this.lblProdutoMaisVendido = new System.Windows.Forms.Label();
            this.lblProdutoMenosVendido = new System.Windows.Forms.Label();
            this.lblMediaPrecos = new System.Windows.Forms.Label();
            this.lblResultNumeroProdutos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultMediaPrecos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dbLanchoneteDataSet = new SisLanchonete.DbLanchoneteDataSet();
            this.produtosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosVendidosTableAdapter = new SisLanchonete.DbLanchoneteDataSetTableAdapters.ProdutosVendidosTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendas)).BeginInit();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLanchoneteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.testesToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // testesToolStripMenuItem
            // 
            this.testesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem});
            this.testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            this.testesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.testesToolStripMenuItem.Text = "Testes";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbClientes
            // 
            this.pbClientes.Image = global::SisLanchonete.Properties.Resources.clientes;
            this.pbClientes.Location = new System.Drawing.Point(13, 28);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(117, 114);
            this.pbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClientes.TabIndex = 1;
            this.pbClientes.TabStop = false;
            this.pbClientes.Click += new System.EventHandler(this.pbClientes_Click);
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Image = global::SisLanchonete.Properties.Resources.usuarios;
            this.pbUsuarios.Location = new System.Drawing.Point(136, 28);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(117, 114);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuarios.TabIndex = 2;
            this.pbUsuarios.TabStop = false;
            this.pbUsuarios.Click += new System.EventHandler(this.pbUsuarios_Click);
            // 
            // pbProduto
            // 
            this.pbProduto.Image = global::SisLanchonete.Properties.Resources.produtos;
            this.pbProduto.Location = new System.Drawing.Point(259, 28);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(117, 114);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduto.TabIndex = 3;
            this.pbProduto.TabStop = false;
            this.pbProduto.Click += new System.EventHandler(this.pbProduto_Click);
            // 
            // pbVendas
            // 
            this.pbVendas.Image = global::SisLanchonete.Properties.Resources.vendas;
            this.pbVendas.Location = new System.Drawing.Point(382, 27);
            this.pbVendas.Name = "pbVendas";
            this.pbVendas.Size = new System.Drawing.Size(117, 114);
            this.pbVendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVendas.TabIndex = 4;
            this.pbVendas.TabStop = false;
            this.pbVendas.Click += new System.EventHandler(this.pbVendas_Click);
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.lblResultMediaPrecos);
            this.gbProdutos.Controls.Add(this.label7);
            this.gbProdutos.Controls.Add(this.label6);
            this.gbProdutos.Controls.Add(this.lblResultNumeroProdutos);
            this.gbProdutos.Controls.Add(this.lblMediaPrecos);
            this.gbProdutos.Controls.Add(this.lblProdutoMenosVendido);
            this.gbProdutos.Controls.Add(this.lblProdutoMaisVendido);
            this.gbProdutos.Controls.Add(this.lblNumProdutos);
            this.gbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProdutos.Location = new System.Drawing.Point(13, 180);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(363, 203);
            this.gbProdutos.TabIndex = 5;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "Produtos";
            // 
            // lblNumProdutos
            // 
            this.lblNumProdutos.AutoSize = true;
            this.lblNumProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProdutos.Location = new System.Drawing.Point(6, 47);
            this.lblNumProdutos.Name = "lblNumProdutos";
            this.lblNumProdutos.Size = new System.Drawing.Size(167, 20);
            this.lblNumProdutos.TabIndex = 0;
            this.lblNumProdutos.Text = "Números de Produtos:";
            // 
            // lblProdutoMaisVendido
            // 
            this.lblProdutoMaisVendido.AutoSize = true;
            this.lblProdutoMaisVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoMaisVendido.Location = new System.Drawing.Point(6, 85);
            this.lblProdutoMaisVendido.Name = "lblProdutoMaisVendido";
            this.lblProdutoMaisVendido.Size = new System.Drawing.Size(177, 20);
            this.lblProdutoMaisVendido.TabIndex = 1;
            this.lblProdutoMaisVendido.Text = "Produtos Mais Vendido:";
            // 
            // lblProdutoMenosVendido
            // 
            this.lblProdutoMenosVendido.AutoSize = true;
            this.lblProdutoMenosVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoMenosVendido.Location = new System.Drawing.Point(6, 127);
            this.lblProdutoMenosVendido.Name = "lblProdutoMenosVendido";
            this.lblProdutoMenosVendido.Size = new System.Drawing.Size(184, 20);
            this.lblProdutoMenosVendido.TabIndex = 2;
            this.lblProdutoMenosVendido.Text = "Produto Menos Vendido:";
            // 
            // lblMediaPrecos
            // 
            this.lblMediaPrecos.AutoSize = true;
            this.lblMediaPrecos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaPrecos.Location = new System.Drawing.Point(6, 163);
            this.lblMediaPrecos.Name = "lblMediaPrecos";
            this.lblMediaPrecos.Size = new System.Drawing.Size(123, 20);
            this.lblMediaPrecos.TabIndex = 3;
            this.lblMediaPrecos.Text = "Média de Preço:";
            // 
            // lblResultNumeroProdutos
            // 
            this.lblResultNumeroProdutos.AutoSize = true;
            this.lblResultNumeroProdutos.Location = new System.Drawing.Point(210, 47);
            this.lblResultNumeroProdutos.Name = "lblResultNumeroProdutos";
            this.lblResultNumeroProdutos.Size = new System.Drawing.Size(0, 20);
            this.lblResultNumeroProdutos.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // lblResultMediaPrecos
            // 
            this.lblResultMediaPrecos.AutoSize = true;
            this.lblResultMediaPrecos.Location = new System.Drawing.Point(210, 163);
            this.lblResultMediaPrecos.Name = "lblResultMediaPrecos";
            this.lblResultMediaPrecos.Size = new System.Drawing.Size(0, 20);
            this.lblResultMediaPrecos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuários";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vendas";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.produtosVendidosBindingSource;
            this.chart1.Location = new System.Drawing.Point(395, 189);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Name = "Series1";
            series1.XValueMember = "nome";
            series1.YValueMembers = "total";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(370, 249);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "txtProdutosVendidos";
            title1.Text = "Produtos Vendidos";
            this.chart1.Titles.Add(title1);
            // 
            // dbLanchoneteDataSet
            // 
            this.dbLanchoneteDataSet.DataSetName = "DbLanchoneteDataSet";
            this.dbLanchoneteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosVendidosBindingSource
            // 
            this.produtosVendidosBindingSource.DataMember = "ProdutosVendidos";
            this.produtosVendidosBindingSource.DataSource = this.dbLanchoneteDataSet;
            // 
            // produtosVendidosTableAdapter
            // 
            this.produtosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbProdutos);
            this.Controls.Add(this.pbVendas);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.pbUsuarios);
            this.Controls.Add(this.pbClientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Lanchonete Burguer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendas)).EndInit();
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLanchoneteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.PictureBox pbVendas;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.Label lblResultMediaPrecos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblResultNumeroProdutos;
        private System.Windows.Forms.Label lblMediaPrecos;
        private System.Windows.Forms.Label lblProdutoMenosVendido;
        private System.Windows.Forms.Label lblProdutoMaisVendido;
        private System.Windows.Forms.Label lblNumProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DbLanchoneteDataSet dbLanchoneteDataSet;
        private System.Windows.Forms.BindingSource produtosVendidosBindingSource;
        private DbLanchoneteDataSetTableAdapters.ProdutosVendidosTableAdapter produtosVendidosTableAdapter;
    }
}