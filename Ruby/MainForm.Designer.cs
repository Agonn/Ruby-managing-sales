﻿namespace Ruby
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.cmbMalli = new MetroFramework.Controls.MetroComboBox();
            this.txtCmimi = new MetroFramework.Controls.MetroTextBox();
            this.btnShto = new MetroFramework.Controls.MetroButton();
            this.btnPdf = new MetroFramework.Controls.MetroButton();
            this.dtpData = new MetroFramework.Controls.MetroDateTime();
            this.Malli = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.CxtMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.tbShitja = new MetroFramework.Controls.MetroTabPage();
            this.dtpShitje = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtbmPershkrimi = new MetroFramework.Controls.MetroTextBox();
            this.lblmShenimet = new MetroFramework.Controls.MetroLabel();
            this.dgvShitja = new System.Windows.Forms.DataGridView();
            this.midDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliEmriDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliCmimiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataShitjesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMalliBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rubyDBDataSet_Malli = new Ruby.RubyDBDataSet_Malli();
            this.tbFurde = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.dgvShpenzimet = new System.Windows.Forms.DataGridView();
            this.shiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rrymafatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ujifatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatimifatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafaturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblShpenzimetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubyDBDataSet_shpenz = new Ruby.RubyDBDataSet_shpenz();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.dgvFurde = new System.Windows.Forms.DataGridView();
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sasiagrfurdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmimipergrfurdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmimitotalfurdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datablerjesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFurdeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubyDBDataSet_furde = new Ruby.RubyDBDataSet_furde();
            this.tbHistoria = new MetroFramework.Controls.MetroTabPage();
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliEmriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliCmimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataShitjesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMalliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblShpenzime = new MetroFramework.Controls.MetroLabel();
            this.lblShitje = new MetroFramework.Controls.MetroLabel();
            this.lblHistoriaShitje = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblDataSot = new MetroFramework.Controls.MetroLabel();
            this.lblSkaData = new MetroFramework.Controls.MetroLabel();
            this.tbStatistika = new MetroFramework.Controls.MetroTabPage();
            this.cmbStatistika = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblHyrje = new MetroFramework.Controls.MetroLabel();
            this.tbLive = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tblMalliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubyDBDataSet = new Ruby.RubyDBDataSet();
            this.tblMalliTableAdapter = new Ruby.RubyDBDataSet1TableAdapters.TblMalliTableAdapter();
            this.tblFurdeTableAdapter = new Ruby.RubyDBDataSet_furdeTableAdapters.TblFurdeTableAdapter();
            this.rubyDBDataSet1 = new Ruby.RubyDBDataSet1();
            this.tblMalliTableAdapter1 = new Ruby.RubyDBDataSet_MalliTableAdapters.TblMalliTableAdapter();
            this.rubyDBDataSet_malli_shitje = new Ruby.RubyDBDataSet_malli_shitje();
            this.btShtoFurde = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyle)).BeginInit();
            this.CxtMenu.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.tbShitja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet_Malli)).BeginInit();
            this.tbFurde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShpenzimet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblShpenzimetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet_shpenz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFurdeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet_furde)).BeginInit();
            this.tbHistoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource1)).BeginInit();
            this.tbStatistika.SuspendLayout();
            this.tbLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet_malli_shitje)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMalli
            // 
            this.cmbMalli.FormattingEnabled = true;
            this.cmbMalli.ItemHeight = 23;
            this.cmbMalli.Items.AddRange(new object[] {
            "Gurrë",
            "Hallhalle",
            "Komplet",
            "Qafore",
            "Riparim",
            "Shërbim",
            "Unazë",
            "Vathë",
            "Tjetër"});
            this.cmbMalli.Location = new System.Drawing.Point(98, 35);
            this.cmbMalli.Name = "cmbMalli";
            this.cmbMalli.Size = new System.Drawing.Size(121, 29);
            this.cmbMalli.TabIndex = 0;
            this.cmbMalli.UseSelectable = true;
            // 
            // txtCmimi
            // 
            // 
            // 
            // 
            this.txtCmimi.CustomButton.Image = null;
            this.txtCmimi.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtCmimi.CustomButton.Name = "";
            this.txtCmimi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCmimi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCmimi.CustomButton.TabIndex = 1;
            this.txtCmimi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCmimi.CustomButton.UseSelectable = true;
            this.txtCmimi.CustomButton.Visible = false;
            this.txtCmimi.Lines = new string[0];
            this.txtCmimi.Location = new System.Drawing.Point(98, 73);
            this.txtCmimi.MaxLength = 32767;
            this.txtCmimi.Name = "txtCmimi";
            this.txtCmimi.PasswordChar = '\0';
            this.txtCmimi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCmimi.SelectedText = "";
            this.txtCmimi.SelectionLength = 0;
            this.txtCmimi.SelectionStart = 0;
            this.txtCmimi.ShortcutsEnabled = true;
            this.txtCmimi.Size = new System.Drawing.Size(121, 23);
            this.txtCmimi.TabIndex = 1;
            this.txtCmimi.UseSelectable = true;
            this.txtCmimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCmimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnShto
            // 
            this.btnShto.DisplayFocus = true;
            this.btnShto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShto.Location = new System.Drawing.Point(98, 142);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(121, 23);
            this.btnShto.TabIndex = 3;
            this.btnShto.Text = "Shto";
            this.btnShto.UseSelectable = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click_1);
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.Location = new System.Drawing.Point(1176, 676);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(77, 23);
            this.btnPdf.TabIndex = 11;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseSelectable = true;
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpData.Location = new System.Drawing.Point(454, 3);
            this.dtpData.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(224, 29);
            this.dtpData.TabIndex = 1;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // Malli
            // 
            this.Malli.AutoSize = true;
            this.Malli.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Malli.Location = new System.Drawing.Point(3, 35);
            this.Malli.Name = "Malli";
            this.Malli.Size = new System.Drawing.Size(38, 19);
            this.Malli.TabIndex = 13;
            this.Malli.Text = "Tipi:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Çmimi:";
            // 
            // metroStyle
            // 
            this.metroStyle.Owner = this;
            this.metroStyle.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // CxtMenu
            // 
            this.CxtMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CxtMenu.Depth = 0;
            this.CxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.historikuToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.kameraToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem});
            this.CxtMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.CxtMenu.Name = "CxtMenu";
            this.CxtMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CxtMenu.Size = new System.Drawing.Size(122, 104);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // historikuToolStripMenuItem
            // 
            this.historikuToolStripMenuItem.Name = "historikuToolStripMenuItem";
            this.historikuToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.historikuToolStripMenuItem.Text = "Historia";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // kameraToolStripMenuItem
            // 
            this.kameraToolStripMenuItem.Name = "kameraToolStripMenuItem";
            this.kameraToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kameraToolStripMenuItem.Text = "Kamera";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.logOutToolStripMenuItem.Text = "Çkyqu";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.tbShitja);
            this.metroTab.Controls.Add(this.tbFurde);
            this.metroTab.Controls.Add(this.tbHistoria);
            this.metroTab.Controls.Add(this.tbStatistika);
            this.metroTab.Controls.Add(this.tbLive);
            this.metroTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTab.Location = new System.Drawing.Point(20, 60);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 1;
            this.metroTab.Size = new System.Drawing.Size(1233, 642);
            this.metroTab.TabIndex = 14;
            this.metroTab.UseSelectable = true;
            // 
            // tbShitja
            // 
            this.tbShitja.Controls.Add(this.dtpShitje);
            this.tbShitja.Controls.Add(this.metroLabel6);
            this.tbShitja.Controls.Add(this.txtbmPershkrimi);
            this.tbShitja.Controls.Add(this.lblmShenimet);
            this.tbShitja.Controls.Add(this.dgvShitja);
            this.tbShitja.Controls.Add(this.metroLabel2);
            this.tbShitja.Controls.Add(this.cmbMalli);
            this.tbShitja.Controls.Add(this.Malli);
            this.tbShitja.Controls.Add(this.txtCmimi);
            this.tbShitja.Controls.Add(this.btnShto);
            this.tbShitja.HorizontalScrollbar = true;
            this.tbShitja.HorizontalScrollbarBarColor = true;
            this.tbShitja.HorizontalScrollbarHighlightOnWheel = false;
            this.tbShitja.HorizontalScrollbarSize = 10;
            this.tbShitja.Location = new System.Drawing.Point(4, 38);
            this.tbShitja.Name = "tbShitja";
            this.tbShitja.Size = new System.Drawing.Size(1225, 600);
            this.tbShitja.TabIndex = 0;
            this.tbShitja.Text = "Shitje";
            this.tbShitja.VerticalScrollbar = true;
            this.tbShitja.VerticalScrollbarBarColor = true;
            this.tbShitja.VerticalScrollbarHighlightOnWheel = false;
            this.tbShitja.VerticalScrollbarSize = 10;
            // 
            // dtpShitje
            // 
            this.dtpShitje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpShitje.Enabled = false;
            this.dtpShitje.Location = new System.Drawing.Point(454, 3);
            this.dtpShitje.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpShitje.Name = "dtpShitje";
            this.dtpShitje.Size = new System.Drawing.Size(224, 29);
            this.dtpShitje.TabIndex = 26;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 106);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Përshkrimi:";
            // 
            // txtbmPershkrimi
            // 
            // 
            // 
            // 
            this.txtbmPershkrimi.CustomButton.Image = null;
            this.txtbmPershkrimi.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtbmPershkrimi.CustomButton.Name = "";
            this.txtbmPershkrimi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbmPershkrimi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbmPershkrimi.CustomButton.TabIndex = 1;
            this.txtbmPershkrimi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbmPershkrimi.CustomButton.UseSelectable = true;
            this.txtbmPershkrimi.CustomButton.Visible = false;
            this.txtbmPershkrimi.Lines = new string[0];
            this.txtbmPershkrimi.Location = new System.Drawing.Point(98, 106);
            this.txtbmPershkrimi.MaxLength = 32767;
            this.txtbmPershkrimi.Name = "txtbmPershkrimi";
            this.txtbmPershkrimi.PasswordChar = '\0';
            this.txtbmPershkrimi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbmPershkrimi.SelectedText = "";
            this.txtbmPershkrimi.SelectionLength = 0;
            this.txtbmPershkrimi.SelectionStart = 0;
            this.txtbmPershkrimi.ShortcutsEnabled = true;
            this.txtbmPershkrimi.Size = new System.Drawing.Size(121, 23);
            this.txtbmPershkrimi.TabIndex = 2;
            this.txtbmPershkrimi.UseSelectable = true;
            this.txtbmPershkrimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbmPershkrimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblmShenimet
            // 
            this.lblmShenimet.Location = new System.Drawing.Point(340, 510);
            this.lblmShenimet.Name = "lblmShenimet";
            this.lblmShenimet.Size = new System.Drawing.Size(336, 90);
            this.lblmShenimet.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblmShenimet.TabIndex = 18;
            this.lblmShenimet.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvShitja
            // 
            this.dgvShitja.AllowUserToDeleteRows = false;
            this.dgvShitja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShitja.AutoGenerateColumns = false;
            this.dgvShitja.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvShitja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShitja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn1,
            this.malliEmriDataGridViewTextBoxColumn1,
            this.malliCmimiDataGridViewTextBoxColumn1,
            this.dataShitjesDataGridViewTextBoxColumn1,
            this.pershkrimiDataGridViewTextBoxColumn1});
            this.dgvShitja.DataSource = this.tblMalliBindingSource2;
            this.dgvShitja.Location = new System.Drawing.Point(684, 3);
            this.dgvShitja.Name = "dgvShitja";
            this.dgvShitja.ReadOnly = true;
            this.dgvShitja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvShitja.RowHeadersVisible = false;
            this.dgvShitja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShitja.Size = new System.Drawing.Size(541, 620);
            this.dgvShitja.TabIndex = 5;
            // 
            // midDataGridViewTextBoxColumn1
            // 
            this.midDataGridViewTextBoxColumn1.DataPropertyName = "Mid";
            this.midDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.midDataGridViewTextBoxColumn1.Name = "midDataGridViewTextBoxColumn1";
            this.midDataGridViewTextBoxColumn1.ReadOnly = true;
            this.midDataGridViewTextBoxColumn1.Width = 30;
            // 
            // malliEmriDataGridViewTextBoxColumn1
            // 
            this.malliEmriDataGridViewTextBoxColumn1.DataPropertyName = "Malli_Emri";
            this.malliEmriDataGridViewTextBoxColumn1.HeaderText = "Emri";
            this.malliEmriDataGridViewTextBoxColumn1.Name = "malliEmriDataGridViewTextBoxColumn1";
            this.malliEmriDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // malliCmimiDataGridViewTextBoxColumn1
            // 
            this.malliCmimiDataGridViewTextBoxColumn1.DataPropertyName = "Malli_Cmimi";
            this.malliCmimiDataGridViewTextBoxColumn1.HeaderText = "Çmimi";
            this.malliCmimiDataGridViewTextBoxColumn1.Name = "malliCmimiDataGridViewTextBoxColumn1";
            this.malliCmimiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataShitjesDataGridViewTextBoxColumn1
            // 
            this.dataShitjesDataGridViewTextBoxColumn1.DataPropertyName = "Data_Shitjes";
            this.dataShitjesDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataShitjesDataGridViewTextBoxColumn1.Name = "dataShitjesDataGridViewTextBoxColumn1";
            this.dataShitjesDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pershkrimiDataGridViewTextBoxColumn1
            // 
            this.pershkrimiDataGridViewTextBoxColumn1.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn1.HeaderText = "Përshkrimi";
            this.pershkrimiDataGridViewTextBoxColumn1.Name = "pershkrimiDataGridViewTextBoxColumn1";
            this.pershkrimiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pershkrimiDataGridViewTextBoxColumn1.Width = 230;
            // 
            // tblMalliBindingSource2
            // 
            this.tblMalliBindingSource2.DataMember = "TblMalli";
            this.tblMalliBindingSource2.DataSource = this.rubyDBDataSet_Malli;
            // 
            // rubyDBDataSet_Malli
            // 
            this.rubyDBDataSet_Malli.DataSetName = "RubyDBDataSet_Malli";
            this.rubyDBDataSet_Malli.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFurde
            // 
            this.tbFurde.Controls.Add(this.btShtoFurde);
            this.tbFurde.Controls.Add(this.metroLabel8);
            this.tbFurde.Controls.Add(this.metroTextBox3);
            this.tbFurde.Controls.Add(this.metroLabel7);
            this.tbFurde.Controls.Add(this.metroLabel4);
            this.tbFurde.Controls.Add(this.metroTextBox2);
            this.tbFurde.Controls.Add(this.metroTextBox1);
            this.tbFurde.Controls.Add(this.dgvShpenzimet);
            this.tbFurde.Controls.Add(this.materialDivider1);
            this.tbFurde.Controls.Add(this.dgvFurde);
            this.tbFurde.HorizontalScrollbarBarColor = true;
            this.tbFurde.HorizontalScrollbarHighlightOnWheel = false;
            this.tbFurde.HorizontalScrollbarSize = 10;
            this.tbFurde.Location = new System.Drawing.Point(4, 38);
            this.tbFurde.Name = "tbFurde";
            this.tbFurde.Size = new System.Drawing.Size(1225, 600);
            this.tbFurde.TabIndex = 4;
            this.tbFurde.Text = "Furde/Shpenzime";
            this.tbFurde.VerticalScrollbarBarColor = true;
            this.tbFurde.VerticalScrollbarHighlightOnWheel = false;
            this.tbFurde.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(3, 106);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Përshkrimi:";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(98, 104);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox3.TabIndex = 26;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(3, 73);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(50, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Gram:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 35);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Sasia:";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(98, 69);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox2.TabIndex = 14;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(98, 35);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox1.TabIndex = 14;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvShpenzimet
            // 
            this.dgvShpenzimet.AllowUserToDeleteRows = false;
            this.dgvShpenzimet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShpenzimet.AutoGenerateColumns = false;
            this.dgvShpenzimet.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvShpenzimet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShpenzimet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiIDDataGridViewTextBoxColumn,
            this.rrymafatDataGridViewTextBoxColumn,
            this.ujifatDataGridViewTextBoxColumn,
            this.tatimifatDataGridViewTextBoxColumn,
            this.datafaturesDataGridViewTextBoxColumn,
            this.pershkrimiDataGridViewTextBoxColumn3});
            this.dgvShpenzimet.DataSource = this.tblShpenzimetBindingSource;
            this.dgvShpenzimet.Location = new System.Drawing.Point(684, 317);
            this.dgvShpenzimet.Name = "dgvShpenzimet";
            this.dgvShpenzimet.ReadOnly = true;
            this.dgvShpenzimet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvShpenzimet.RowHeadersVisible = false;
            this.dgvShpenzimet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShpenzimet.Size = new System.Drawing.Size(541, 291);
            this.dgvShpenzimet.TabIndex = 6;
            // 
            // shiIDDataGridViewTextBoxColumn
            // 
            this.shiIDDataGridViewTextBoxColumn.DataPropertyName = "ShiID";
            this.shiIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.shiIDDataGridViewTextBoxColumn.Name = "shiIDDataGridViewTextBoxColumn";
            this.shiIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // rrymafatDataGridViewTextBoxColumn
            // 
            this.rrymafatDataGridViewTextBoxColumn.DataPropertyName = "Rryma_fat";
            this.rrymafatDataGridViewTextBoxColumn.HeaderText = "Rryma";
            this.rrymafatDataGridViewTextBoxColumn.Name = "rrymafatDataGridViewTextBoxColumn";
            this.rrymafatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ujifatDataGridViewTextBoxColumn
            // 
            this.ujifatDataGridViewTextBoxColumn.DataPropertyName = "Uji_fat";
            this.ujifatDataGridViewTextBoxColumn.HeaderText = "Uji";
            this.ujifatDataGridViewTextBoxColumn.Name = "ujifatDataGridViewTextBoxColumn";
            this.ujifatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tatimifatDataGridViewTextBoxColumn
            // 
            this.tatimifatDataGridViewTextBoxColumn.DataPropertyName = "Tatimi_fat";
            this.tatimifatDataGridViewTextBoxColumn.HeaderText = "Tatimi";
            this.tatimifatDataGridViewTextBoxColumn.Name = "tatimifatDataGridViewTextBoxColumn";
            this.tatimifatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datafaturesDataGridViewTextBoxColumn
            // 
            this.datafaturesDataGridViewTextBoxColumn.DataPropertyName = "Data_fatures";
            this.datafaturesDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datafaturesDataGridViewTextBoxColumn.Name = "datafaturesDataGridViewTextBoxColumn";
            this.datafaturesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pershkrimiDataGridViewTextBoxColumn3
            // 
            this.pershkrimiDataGridViewTextBoxColumn3.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn3.HeaderText = "Përshkrimi";
            this.pershkrimiDataGridViewTextBoxColumn3.Name = "pershkrimiDataGridViewTextBoxColumn3";
            this.pershkrimiDataGridViewTextBoxColumn3.ReadOnly = true;
            this.pershkrimiDataGridViewTextBoxColumn3.Width = 130;
            // 
            // tblShpenzimetBindingSource
            // 
            this.tblShpenzimetBindingSource.DataMember = "Tbl.Shpenzimet";
            this.tblShpenzimetBindingSource.DataSource = this.rubyDBDataSet_shpenz;
            // 
            // rubyDBDataSet_shpenz
            // 
            this.rubyDBDataSet_shpenz.DataSetName = "RubyDBDataSet_shpenz";
            this.rubyDBDataSet_shpenz.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.Gainsboro;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-68, 300);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1328, 11);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // dgvFurde
            // 
            this.dgvFurde.AllowUserToDeleteRows = false;
            this.dgvFurde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFurde.AutoGenerateColumns = false;
            this.dgvFurde.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvFurde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFurde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fidDataGridViewTextBoxColumn,
            this.sasiagrfurdeDataGridViewTextBoxColumn,
            this.cmimipergrfurdeDataGridViewTextBoxColumn,
            this.cmimitotalfurdeDataGridViewTextBoxColumn,
            this.datablerjesDataGridViewTextBoxColumn,
            this.pershkrimiDataGridViewTextBoxColumn2});
            this.dgvFurde.DataSource = this.tblFurdeBindingSource;
            this.dgvFurde.Location = new System.Drawing.Point(684, 3);
            this.dgvFurde.Name = "dgvFurde";
            this.dgvFurde.ReadOnly = true;
            this.dgvFurde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvFurde.RowHeadersVisible = false;
            this.dgvFurde.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFurde.Size = new System.Drawing.Size(541, 291);
            this.dgvFurde.TabIndex = 2;
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "Fid";
            this.fidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            this.fidDataGridViewTextBoxColumn.ReadOnly = true;
            this.fidDataGridViewTextBoxColumn.Width = 30;
            // 
            // sasiagrfurdeDataGridViewTextBoxColumn
            // 
            this.sasiagrfurdeDataGridViewTextBoxColumn.DataPropertyName = "Sasia_gr_furde";
            this.sasiagrfurdeDataGridViewTextBoxColumn.HeaderText = "Sasia";
            this.sasiagrfurdeDataGridViewTextBoxColumn.Name = "sasiagrfurdeDataGridViewTextBoxColumn";
            this.sasiagrfurdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmimipergrfurdeDataGridViewTextBoxColumn
            // 
            this.cmimipergrfurdeDataGridViewTextBoxColumn.DataPropertyName = "Cmimi_per_gr_furde";
            this.cmimipergrfurdeDataGridViewTextBoxColumn.HeaderText = "Çmimi për gr.";
            this.cmimipergrfurdeDataGridViewTextBoxColumn.Name = "cmimipergrfurdeDataGridViewTextBoxColumn";
            this.cmimipergrfurdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cmimitotalfurdeDataGridViewTextBoxColumn
            // 
            this.cmimitotalfurdeDataGridViewTextBoxColumn.DataPropertyName = "Cmimi_total_furde";
            this.cmimitotalfurdeDataGridViewTextBoxColumn.HeaderText = "Çmimi total";
            this.cmimitotalfurdeDataGridViewTextBoxColumn.Name = "cmimitotalfurdeDataGridViewTextBoxColumn";
            this.cmimitotalfurdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datablerjesDataGridViewTextBoxColumn
            // 
            this.datablerjesDataGridViewTextBoxColumn.DataPropertyName = "Data_blerjes";
            this.datablerjesDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datablerjesDataGridViewTextBoxColumn.Name = "datablerjesDataGridViewTextBoxColumn";
            this.datablerjesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pershkrimiDataGridViewTextBoxColumn2
            // 
            this.pershkrimiDataGridViewTextBoxColumn2.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn2.HeaderText = "Përshkrimi";
            this.pershkrimiDataGridViewTextBoxColumn2.Name = "pershkrimiDataGridViewTextBoxColumn2";
            this.pershkrimiDataGridViewTextBoxColumn2.ReadOnly = true;
            this.pershkrimiDataGridViewTextBoxColumn2.Width = 120;
            // 
            // tblFurdeBindingSource
            // 
            this.tblFurdeBindingSource.DataMember = "TblFurde";
            this.tblFurdeBindingSource.DataSource = this.rubyDBDataSet_furde;
            // 
            // rubyDBDataSet_furde
            // 
            this.rubyDBDataSet_furde.DataSetName = "RubyDBDataSet_furde";
            this.rubyDBDataSet_furde.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbHistoria
            // 
            this.tbHistoria.Controls.Add(this.dtpData);
            this.tbHistoria.Controls.Add(this.dgvHistoria);
            this.tbHistoria.Controls.Add(this.lblShpenzime);
            this.tbHistoria.Controls.Add(this.lblShitje);
            this.tbHistoria.Controls.Add(this.lblHistoriaShitje);
            this.tbHistoria.Controls.Add(this.metroLabel3);
            this.tbHistoria.Controls.Add(this.metroLabel1);
            this.tbHistoria.Controls.Add(this.lblDataSot);
            this.tbHistoria.Controls.Add(this.lblSkaData);
            this.tbHistoria.HorizontalScrollbarBarColor = true;
            this.tbHistoria.HorizontalScrollbarHighlightOnWheel = false;
            this.tbHistoria.HorizontalScrollbarSize = 10;
            this.tbHistoria.Location = new System.Drawing.Point(4, 38);
            this.tbHistoria.Name = "tbHistoria";
            this.tbHistoria.Size = new System.Drawing.Size(1225, 600);
            this.tbHistoria.TabIndex = 1;
            this.tbHistoria.Text = "Historia";
            this.tbHistoria.VerticalScrollbarBarColor = true;
            this.tbHistoria.VerticalScrollbarHighlightOnWheel = false;
            this.tbHistoria.VerticalScrollbarSize = 10;
            // 
            // dgvHistoria
            // 
            this.dgvHistoria.AllowUserToDeleteRows = false;
            this.dgvHistoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoria.AutoGenerateColumns = false;
            this.dgvHistoria.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.malliEmriDataGridViewTextBoxColumn,
            this.malliCmimiDataGridViewTextBoxColumn,
            this.dataShitjesDataGridViewTextBoxColumn,
            this.pershkrimiDataGridViewTextBoxColumn});
            this.dgvHistoria.DataSource = this.tblMalliBindingSource1;
            this.dgvHistoria.Location = new System.Drawing.Point(684, 3);
            this.dgvHistoria.Name = "dgvHistoria";
            this.dgvHistoria.ReadOnly = true;
            this.dgvHistoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvHistoria.RowHeadersVisible = false;
            this.dgvHistoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHistoria.Size = new System.Drawing.Size(541, 620);
            this.dgvHistoria.TabIndex = 3;
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "Mid";
            this.midDataGridViewTextBoxColumn.HeaderText = "ID";
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.ReadOnly = true;
            this.midDataGridViewTextBoxColumn.Width = 30;
            // 
            // malliEmriDataGridViewTextBoxColumn
            // 
            this.malliEmriDataGridViewTextBoxColumn.DataPropertyName = "Malli_Emri";
            this.malliEmriDataGridViewTextBoxColumn.HeaderText = "Emri";
            this.malliEmriDataGridViewTextBoxColumn.Name = "malliEmriDataGridViewTextBoxColumn";
            this.malliEmriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malliCmimiDataGridViewTextBoxColumn
            // 
            this.malliCmimiDataGridViewTextBoxColumn.DataPropertyName = "Malli_Cmimi";
            this.malliCmimiDataGridViewTextBoxColumn.HeaderText = "Çmimi";
            this.malliCmimiDataGridViewTextBoxColumn.Name = "malliCmimiDataGridViewTextBoxColumn";
            this.malliCmimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataShitjesDataGridViewTextBoxColumn
            // 
            this.dataShitjesDataGridViewTextBoxColumn.DataPropertyName = "Data_Shitjes";
            this.dataShitjesDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataShitjesDataGridViewTextBoxColumn.Name = "dataShitjesDataGridViewTextBoxColumn";
            this.dataShitjesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pershkrimiDataGridViewTextBoxColumn
            // 
            this.pershkrimiDataGridViewTextBoxColumn.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.HeaderText = "Përshkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.Name = "pershkrimiDataGridViewTextBoxColumn";
            this.pershkrimiDataGridViewTextBoxColumn.ReadOnly = true;
            this.pershkrimiDataGridViewTextBoxColumn.Width = 220;
            // 
            // tblMalliBindingSource1
            // 
            this.tblMalliBindingSource1.DataMember = "TblMalli";
            this.tblMalliBindingSource1.DataSource = this.rubyDBDataSet_Malli;
            // 
            // lblShpenzime
            // 
            this.lblShpenzime.AutoSize = true;
            this.lblShpenzime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblShpenzime.Location = new System.Drawing.Point(95, 104);
            this.lblShpenzime.Name = "lblShpenzime";
            this.lblShpenzime.Size = new System.Drawing.Size(0, 0);
            this.lblShpenzime.TabIndex = 2;
            // 
            // lblShitje
            // 
            this.lblShitje.AutoSize = true;
            this.lblShitje.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblShitje.Location = new System.Drawing.Point(59, 71);
            this.lblShitje.Name = "lblShitje";
            this.lblShitje.Size = new System.Drawing.Size(0, 0);
            this.lblShitje.TabIndex = 2;
            // 
            // lblHistoriaShitje
            // 
            this.lblHistoriaShitje.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHistoriaShitje.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHistoriaShitje.Location = new System.Drawing.Point(97, 69);
            this.lblHistoriaShitje.Name = "lblHistoriaShitje";
            this.lblHistoriaShitje.Size = new System.Drawing.Size(110, 36);
            this.lblHistoriaShitje.TabIndex = 2;
            this.lblHistoriaShitje.Text = "5000";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(3, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Shitje:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Data:";
            // 
            // lblDataSot
            // 
            this.lblDataSot.AutoSize = true;
            this.lblDataSot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDataSot.Location = new System.Drawing.Point(98, 35);
            this.lblDataSot.Name = "lblDataSot";
            this.lblDataSot.Size = new System.Drawing.Size(57, 19);
            this.lblDataSot.TabIndex = 2;
            this.lblDataSot.Text = "Data_st";
            // 
            // lblSkaData
            // 
            this.lblSkaData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSkaData.AutoSize = true;
            this.lblSkaData.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSkaData.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSkaData.Location = new System.Drawing.Point(876, 7);
            this.lblSkaData.Name = "lblSkaData";
            this.lblSkaData.Size = new System.Drawing.Size(152, 25);
            this.lblSkaData.TabIndex = 2;
            this.lblSkaData.Text = "Nuk ka të dhëna";
            // 
            // tbStatistika
            // 
            this.tbStatistika.Controls.Add(this.cmbStatistika);
            this.tbStatistika.Controls.Add(this.metroLabel5);
            this.tbStatistika.Controls.Add(this.lblHyrje);
            this.tbStatistika.HorizontalScrollbarBarColor = true;
            this.tbStatistika.HorizontalScrollbarHighlightOnWheel = false;
            this.tbStatistika.HorizontalScrollbarSize = 10;
            this.tbStatistika.Location = new System.Drawing.Point(4, 38);
            this.tbStatistika.Name = "tbStatistika";
            this.tbStatistika.Size = new System.Drawing.Size(1225, 600);
            this.tbStatistika.TabIndex = 2;
            this.tbStatistika.Text = "Statistika";
            this.tbStatistika.VerticalScrollbarBarColor = true;
            this.tbStatistika.VerticalScrollbarHighlightOnWheel = false;
            this.tbStatistika.VerticalScrollbarSize = 10;
            // 
            // cmbStatistika
            // 
            this.cmbStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatistika.FormattingEnabled = true;
            this.cmbStatistika.ItemHeight = 23;
            this.cmbStatistika.Items.AddRange(new object[] {
            "Sot",
            "Java ",
            "Muaji",
            "Viti"});
            this.cmbStatistika.Location = new System.Drawing.Point(1149, 3);
            this.cmbStatistika.Name = "cmbStatistika";
            this.cmbStatistika.Size = new System.Drawing.Size(73, 29);
            this.cmbStatistika.TabIndex = 10;
            this.cmbStatistika.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(2, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Shpenzime:";
            // 
            // lblHyrje
            // 
            this.lblHyrje.AutoSize = true;
            this.lblHyrje.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHyrje.Location = new System.Drawing.Point(2, 26);
            this.lblHyrje.Name = "lblHyrje";
            this.lblHyrje.Size = new System.Drawing.Size(50, 19);
            this.lblHyrje.TabIndex = 14;
            this.lblHyrje.Text = "Hyrje:";
            // 
            // tbLive
            // 
            this.tbLive.Controls.Add(this.webBrowser1);
            this.tbLive.HorizontalScrollbarBarColor = true;
            this.tbLive.HorizontalScrollbarHighlightOnWheel = false;
            this.tbLive.HorizontalScrollbarSize = 10;
            this.tbLive.Location = new System.Drawing.Point(4, 38);
            this.tbLive.Name = "tbLive";
            this.tbLive.Size = new System.Drawing.Size(1225, 600);
            this.tbLive.TabIndex = 3;
            this.tbLive.Text = "Live";
            this.tbLive.VerticalScrollbarBarColor = true;
            this.tbLive.VerticalScrollbarHighlightOnWheel = false;
            this.tbLive.VerticalScrollbarSize = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1225, 600);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri(" https://www.bullionbypost.co.uk/gold-price/live-gold-price/", System.UriKind.Absolute);
            // 
            // tblMalliBindingSource
            // 
            this.tblMalliBindingSource.DataMember = "TblMalli";
            // 
            // rubyDBDataSet
            // 
            this.rubyDBDataSet.DataSetName = "RubyDBDataSet";
            this.rubyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMalliTableAdapter
            // 
            this.tblMalliTableAdapter.ClearBeforeFill = true;
            // 
            // tblFurdeTableAdapter
            // 
            this.tblFurdeTableAdapter.ClearBeforeFill = true;
            // 
            // rubyDBDataSet1
            // 
            this.rubyDBDataSet1.DataSetName = "RubyDBDataSet1";
            this.rubyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMalliTableAdapter1
            // 
            this.tblMalliTableAdapter1.ClearBeforeFill = true;
            // 
            // rubyDBDataSet_malli_shitje
            // 
            this.rubyDBDataSet_malli_shitje.DataSetName = "RubyDBDataSet_malli_shitje";
            this.rubyDBDataSet_malli_shitje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btShtoFurde
            // 
            this.btShtoFurde.Location = new System.Drawing.Point(98, 142);
            this.btShtoFurde.Name = "btShtoFurde";
            this.btShtoFurde.Size = new System.Drawing.Size(121, 23);
            this.btShtoFurde.TabIndex = 28;
            this.btShtoFurde.Text = "Shto";
            this.btShtoFurde.UseSelectable = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1273, 722);
            this.ContextMenuStrip = this.CxtMenu;
            this.Controls.Add(this.metroTab);
            this.Controls.Add(this.btnPdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Ruby";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyle)).EndInit();
            this.CxtMenu.ResumeLayout(false);
            this.metroTab.ResumeLayout(false);
            this.tbShitja.ResumeLayout(false);
            this.tbShitja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet_Malli)).EndInit();
            this.tbFurde.ResumeLayout(false);
            this.tbFurde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShpenzimet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblShpenzimetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet_shpenz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFurdeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet_furde)).EndInit();
            this.tbHistoria.ResumeLayout(false);
            this.tbHistoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource1)).EndInit();
            this.tbStatistika.ResumeLayout(false);
            this.tbStatistika.PerformLayout();
            this.tbLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet_malli_shitje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cmbMalli;
        private MetroFramework.Controls.MetroTextBox txtCmimi;
        private MetroFramework.Controls.MetroButton btnShto;
        private MetroFramework.Controls.MetroButton btnPdf;
        private MetroFramework.Controls.MetroDateTime dtpData;
        private MetroFramework.Controls.MetroLabel Malli;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroStyleManager metroStyle;
        private MaterialSkin.Controls.MaterialContextMenuStrip CxtMenu;
        private System.Windows.Forms.ToolStripMenuItem historikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroTabPage tbShitja;
        private MetroFramework.Controls.MetroTabPage tbHistoria;
        private MetroFramework.Controls.MetroTabPage tbStatistika;
        private System.Windows.Forms.DataGridView dgvShitja;
        private MetroFramework.Controls.MetroLabel lblDataSot;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblShpenzime;
        private MetroFramework.Controls.MetroLabel lblShitje;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblHyrje;
        private MetroFramework.Controls.MetroComboBox cmbStatistika;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MetroFramework.Controls.MetroTabControl metroTab;
        private MetroFramework.Controls.MetroLabel lblmShenimet;
        private MetroFramework.Controls.MetroTextBox txtbmPershkrimi;
        private RubyDBDataSet rubyDBDataSet;
        private System.Windows.Forms.BindingSource tblMalliBindingSource;
        private RubyDBDataSet1TableAdapters.TblMalliTableAdapter tblMalliTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblHistoriaShitje;
        private MetroFramework.Controls.MetroTabPage tbLive;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dgvHistoria;
        private MetroFramework.Controls.MetroDateTime dtpShitje;
        private MetroFramework.Controls.MetroLabel lblSkaData;
        private MetroFramework.Controls.MetroTabPage tbFurde;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.DataGridView dgvShpenzimet;
        private System.Windows.Forms.DataGridView dgvFurde;
        private RubyDBDataSet_furde rubyDBDataSet_furde;
        private System.Windows.Forms.BindingSource tblFurdeBindingSource;
        private RubyDBDataSet_furdeTableAdapters.TblFurdeTableAdapter tblFurdeTableAdapter;
        private System.Windows.Forms.BindingSource tblShpenzimetBindingSource;
        private RubyDBDataSet_shpenz rubyDBDataSet_shpenz;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sasiagrfurdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimipergrfurdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimitotalfurdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datablerjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn2;
        private RubyDBDataSet1 rubyDBDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rrymafatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ujifatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatimifatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafaturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn3;
        private RubyDBDataSet_Malli rubyDBDataSet_Malli;
        private System.Windows.Forms.BindingSource tblMalliBindingSource1;
        private RubyDBDataSet_MalliTableAdapters.TblMalliTableAdapter tblMalliTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliEmriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliCmimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataShitjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn;
        private RubyDBDataSet_malli_shitje rubyDBDataSet_malli_shitje;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliEmriDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliCmimiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataShitjesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tblMalliBindingSource2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton btShtoFurde;
    }
}

