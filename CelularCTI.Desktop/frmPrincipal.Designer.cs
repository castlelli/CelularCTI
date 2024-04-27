namespace CelularCTI.Desktop
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Gpb_pesquisa = new GroupBox();
            cmbFabricante = new ComboBox();
            btn_PesquisarFabricante = new Button();
            lbl_Pesq = new Label();
            txt_PesqNome = new TextBox();
            btn_PesquisarNome = new Button();
            lbl_PesqNome = new Label();
            btn_PesqPreco = new Button();
            num_PrecoMax = new NumericUpDown();
            label1 = new Label();
            num_PrecoMin = new NumericUpDown();
            lbl_pesquisa = new Label();
            Num_PMin = new NumericUpDown();
            gpb_View = new GroupBox();
            lstCelulares = new ListBox();
            dataGridView1 = new DataGridView();
            Gpb_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_PrecoMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_PrecoMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num_PMin).BeginInit();
            gpb_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Gpb_pesquisa
            // 
            Gpb_pesquisa.Controls.Add(cmbFabricante);
            Gpb_pesquisa.Controls.Add(btn_PesquisarFabricante);
            Gpb_pesquisa.Controls.Add(lbl_Pesq);
            Gpb_pesquisa.Controls.Add(txt_PesqNome);
            Gpb_pesquisa.Controls.Add(btn_PesquisarNome);
            Gpb_pesquisa.Controls.Add(lbl_PesqNome);
            Gpb_pesquisa.Controls.Add(btn_PesqPreco);
            Gpb_pesquisa.Controls.Add(num_PrecoMax);
            Gpb_pesquisa.Controls.Add(label1);
            Gpb_pesquisa.Controls.Add(num_PrecoMin);
            Gpb_pesquisa.Controls.Add(lbl_pesquisa);
            Gpb_pesquisa.Controls.Add(Num_PMin);
            Gpb_pesquisa.Location = new Point(35, 24);
            Gpb_pesquisa.Name = "Gpb_pesquisa";
            Gpb_pesquisa.Size = new Size(740, 211);
            Gpb_pesquisa.TabIndex = 0;
            Gpb_pesquisa.TabStop = false;
            Gpb_pesquisa.Text = "Pesquisa por:";
            // 
            // cmbFabricante
            // 
            cmbFabricante.FormattingEnabled = true;
            cmbFabricante.Location = new Point(98, 171);
            cmbFabricante.Name = "cmbFabricante";
            cmbFabricante.Size = new Size(424, 28);
            cmbFabricante.TabIndex = 12;
            // 
            // btn_PesquisarFabricante
            // 
            btn_PesquisarFabricante.Location = new Point(602, 170);
            btn_PesquisarFabricante.Name = "btn_PesquisarFabricante";
            btn_PesquisarFabricante.Size = new Size(108, 29);
            btn_PesquisarFabricante.TabIndex = 10;
            btn_PesquisarFabricante.Text = ">>";
            btn_PesquisarFabricante.UseVisualStyleBackColor = true;
            btn_PesquisarFabricante.Click += btn_PesquisarFabricante_Click;
            // 
            // lbl_Pesq
            // 
            lbl_Pesq.AutoSize = true;
            lbl_Pesq.Location = new Point(15, 174);
            lbl_Pesq.Name = "lbl_Pesq";
            lbl_Pesq.Size = new Size(77, 20);
            lbl_Pesq.TabIndex = 9;
            lbl_Pesq.Text = "Fabricante";
            // 
            // txt_PesqNome
            // 
            txt_PesqNome.Location = new Point(98, 101);
            txt_PesqNome.Name = "txt_PesqNome";
            txt_PesqNome.Size = new Size(424, 27);
            txt_PesqNome.TabIndex = 8;
            // 
            // btn_PesquisarNome
            // 
            btn_PesquisarNome.Location = new Point(602, 99);
            btn_PesquisarNome.Name = "btn_PesquisarNome";
            btn_PesquisarNome.Size = new Size(108, 29);
            btn_PesquisarNome.TabIndex = 7;
            btn_PesquisarNome.Text = ">>";
            btn_PesquisarNome.UseVisualStyleBackColor = true;
            btn_PesquisarNome.Click += btn_PesquisarNome_Click;
            // 
            // lbl_PesqNome
            // 
            lbl_PesqNome.AutoSize = true;
            lbl_PesqNome.Location = new Point(18, 108);
            lbl_PesqNome.Name = "lbl_PesqNome";
            lbl_PesqNome.Size = new Size(50, 20);
            lbl_PesqNome.TabIndex = 6;
            lbl_PesqNome.Text = "Nome";
            // 
            // btn_PesqPreco
            // 
            btn_PesqPreco.Location = new Point(602, 33);
            btn_PesqPreco.Name = "btn_PesqPreco";
            btn_PesqPreco.Size = new Size(108, 29);
            btn_PesqPreco.TabIndex = 4;
            btn_PesqPreco.Text = ">>";
            btn_PesqPreco.UseVisualStyleBackColor = true;
            btn_PesqPreco.Click += btn_PesqPreco_Click;
            // 
            // num_PrecoMax
            // 
            num_PrecoMax.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_PrecoMax.Location = new Point(380, 33);
            num_PrecoMax.Name = "num_PrecoMax";
            num_PrecoMax.Size = new Size(156, 25);
            num_PrecoMax.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 33);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 2;
            label1.Text = "a";
            // 
            // num_PrecoMin
            // 
            num_PrecoMin.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num_PrecoMin.Location = new Point(110, 33);
            num_PrecoMin.Name = "num_PrecoMin";
            num_PrecoMin.Size = new Size(156, 25);
            num_PrecoMin.TabIndex = 0;
            // 
            // lbl_pesquisa
            // 
            lbl_pesquisa.AutoSize = true;
            lbl_pesquisa.Location = new Point(32, 33);
            lbl_pesquisa.Name = "lbl_pesquisa";
            lbl_pesquisa.Size = new Size(46, 20);
            lbl_pesquisa.TabIndex = 1;
            lbl_pesquisa.Text = "Preço";
            // 
            // Num_PMin
            // 
            Num_PMin.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Num_PMin.Location = new Point(119, 33);
            Num_PMin.Name = "Num_PMin";
            Num_PMin.Size = new Size(156, 25);
            Num_PMin.TabIndex = 0;
            // 
            // gpb_View
            // 
            gpb_View.Controls.Add(lstCelulares);
            gpb_View.Location = new Point(53, 241);
            gpb_View.Name = "gpb_View";
            gpb_View.Size = new Size(723, 283);
            gpb_View.TabIndex = 1;
            gpb_View.TabStop = false;
            gpb_View.Text = "Celulares";
            // 
            // lstCelulares
            // 
            lstCelulares.FormattingEnabled = true;
            lstCelulares.Location = new Point(18, 26);
            lstCelulares.Name = "lstCelulares";
            lstCelulares.Size = new Size(669, 224);
            lstCelulares.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 542);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(723, 111);
            dataGridView1.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 688);
            Controls.Add(dataGridView1);
            Controls.Add(gpb_View);
            Controls.Add(Gpb_pesquisa);
            Name = "frmPrincipal";
            Text = "Form1";
            Load += frmPrincipal_Load;
            Gpb_pesquisa.ResumeLayout(false);
            Gpb_pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_PrecoMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_PrecoMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num_PMin).EndInit();
            gpb_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Gpb_pesquisa;
        private NumericUpDown Num_PMin;
        private Button btn_PesqPreco;
        private NumericUpDown num_PrecoMax;
        private Label label1;
        private Label lbl_pesquisa;
        private Button btn_PesquisarFabricante;
        private Label lbl_Pesq;
        private TextBox txt_PesqNome;
        private Button btn_PesquisarNome;
        private Label lbl_PesqNome;
        private NumericUpDown num_PrecoMin;
        private GroupBox gpb_View;
        private ListBox lstCelulares;
        private ComboBox cmbFabricante;
        private DataGridView dataGridView1;
    }
}
