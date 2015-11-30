namespace EVOGUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGenerateMap = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._tlpName = new System.Windows.Forms.TableLayoutPanel();
            this._lName = new System.Windows.Forms.Label();
            this._tbName = new System.Windows.Forms.TextBox();
            this._preGenPictureBox = new Tao.Platform.Windows.SimpleOpenGlControl();
            this._tlpHeight = new System.Windows.Forms.TableLayoutPanel();
            this._lHeight = new System.Windows.Forms.Label();
            this._tbHeight = new System.Windows.Forms.TextBox();
            this._tlpWidth = new System.Windows.Forms.TableLayoutPanel();
            this._lWidth = new System.Windows.Forms.Label();
            this._tbWidth = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this._cbSmoothing = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this._bGenerate = new System.Windows.Forms.Button();
            this._bSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this._lbTilesInWorld = new System.Windows.Forms.ListBox();
            this._lbAllTiles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this._bAdd = new System.Windows.Forms.Button();
            this._lPriority = new System.Windows.Forms.Label();
            this._tbPriority = new System.Windows.Forms.TextBox();
            this._bClear = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpGenerateMap.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this._tlpName.SuspendLayout();
            this._tlpHeight.SuspendLayout();
            this._tlpWidth.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tpGenerateMap);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tpGenerateMap
            // 
            this.tpGenerateMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpGenerateMap.Controls.Add(this.tableLayoutPanel1);
            this.tpGenerateMap.Location = new System.Drawing.Point(4, 25);
            this.tpGenerateMap.Name = "tpGenerateMap";
            this.tpGenerateMap.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenerateMap.Size = new System.Drawing.Size(620, 372);
            this.tpGenerateMap.TabIndex = 0;
            this.tpGenerateMap.Text = "Генерация мира";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.03546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.96454F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this._tlpName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._preGenPictureBox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this._tlpHeight, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this._tlpWidth, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 366);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _tlpName
            // 
            this._tlpName.BackColor = System.Drawing.SystemColors.ControlLight;
            this._tlpName.ColumnCount = 2;
            this._tlpName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09678F));
            this._tlpName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90322F));
            this._tlpName.Controls.Add(this._lName, 0, 0);
            this._tlpName.Controls.Add(this._tbName, 1, 0);
            this._tlpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpName.Location = new System.Drawing.Point(3, 3);
            this._tlpName.Name = "_tlpName";
            this._tlpName.RowCount = 1;
            this._tlpName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpName.Size = new System.Drawing.Size(270, 27);
            this._tlpName.TabIndex = 0;
            // 
            // _lName
            // 
            this._lName.AutoSize = true;
            this._lName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lName.Location = new System.Drawing.Point(3, 0);
            this._lName.Name = "_lName";
            this._lName.Size = new System.Drawing.Size(94, 27);
            this._lName.TabIndex = 0;
            this._lName.Text = "Название мира";
            this._lName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tbName
            // 
            this._tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbName.Location = new System.Drawing.Point(103, 3);
            this._tbName.MaxLength = 15;
            this._tbName.Multiline = true;
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(164, 21);
            this._tbName.TabIndex = 1;
            // 
            // _preGenPictureBox
            // 
            this._preGenPictureBox.AccumBits = ((byte)(0));
            this._preGenPictureBox.AutoCheckErrors = false;
            this._preGenPictureBox.AutoFinish = false;
            this._preGenPictureBox.AutoMakeCurrent = true;
            this._preGenPictureBox.AutoSwapBuffers = true;
            this._preGenPictureBox.BackColor = System.Drawing.Color.Black;
            this._preGenPictureBox.ColorBits = ((byte)(32));
            this._preGenPictureBox.DepthBits = ((byte)(16));
            this._preGenPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._preGenPictureBox.Location = new System.Drawing.Point(3, 135);
            this._preGenPictureBox.Name = "_preGenPictureBox";
            this._preGenPictureBox.Size = new System.Drawing.Size(270, 228);
            this._preGenPictureBox.StencilBits = ((byte)(0));
            this._preGenPictureBox.TabIndex = 2;
            // 
            // _tlpHeight
            // 
            this._tlpHeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this._tlpHeight.ColumnCount = 2;
            this._tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09678F));
            this._tlpHeight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90322F));
            this._tlpHeight.Controls.Add(this._lHeight, 0, 0);
            this._tlpHeight.Controls.Add(this._tbHeight, 1, 0);
            this._tlpHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpHeight.Location = new System.Drawing.Point(3, 36);
            this._tlpHeight.Name = "_tlpHeight";
            this._tlpHeight.RowCount = 1;
            this._tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpHeight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this._tlpHeight.Size = new System.Drawing.Size(270, 27);
            this._tlpHeight.TabIndex = 1;
            // 
            // _lHeight
            // 
            this._lHeight.AutoSize = true;
            this._lHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lHeight.Location = new System.Drawing.Point(3, 0);
            this._lHeight.Name = "_lHeight";
            this._lHeight.Size = new System.Drawing.Size(94, 27);
            this._lHeight.TabIndex = 0;
            this._lHeight.Text = "Высота";
            this._lHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tbHeight
            // 
            this._tbHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbHeight.Location = new System.Drawing.Point(103, 3);
            this._tbHeight.MaxLength = 3;
            this._tbHeight.Multiline = true;
            this._tbHeight.Name = "_tbHeight";
            this._tbHeight.Size = new System.Drawing.Size(164, 21);
            this._tbHeight.TabIndex = 1;
            this._tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPress);
            // 
            // _tlpWidth
            // 
            this._tlpWidth.BackColor = System.Drawing.SystemColors.ControlLight;
            this._tlpWidth.ColumnCount = 2;
            this._tlpWidth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.69355F));
            this._tlpWidth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.30645F));
            this._tlpWidth.Controls.Add(this._lWidth, 0, 0);
            this._tlpWidth.Controls.Add(this._tbWidth, 1, 0);
            this._tlpWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpWidth.Location = new System.Drawing.Point(3, 69);
            this._tlpWidth.Name = "_tlpWidth";
            this._tlpWidth.RowCount = 1;
            this._tlpWidth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpWidth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this._tlpWidth.Size = new System.Drawing.Size(270, 27);
            this._tlpWidth.TabIndex = 2;
            // 
            // _lWidth
            // 
            this._lWidth.AutoSize = true;
            this._lWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lWidth.Location = new System.Drawing.Point(3, 0);
            this._lWidth.Name = "_lWidth";
            this._lWidth.Size = new System.Drawing.Size(93, 27);
            this._lWidth.TabIndex = 0;
            this._lWidth.Text = "Ширина";
            this._lWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tbWidth
            // 
            this._tbWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbWidth.Location = new System.Drawing.Point(102, 3);
            this._tbWidth.MaxLength = 3;
            this._tbWidth.Multiline = true;
            this._tbWidth.Name = "_tbWidth";
            this._tbWidth.Size = new System.Drawing.Size(165, 21);
            this._tbWidth.TabIndex = 1;
            this._tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPress);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this._cbSmoothing, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(270, 27);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сглаживание";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cbSmoothing
            // 
            this._cbSmoothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cbSmoothing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSmoothing.FormattingEnabled = true;
            this._cbSmoothing.Items.AddRange(new object[] {
            "0",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this._cbSmoothing.Location = new System.Drawing.Point(102, 3);
            this._cbSmoothing.Name = "_cbSmoothing";
            this._cbSmoothing.Size = new System.Drawing.Size(165, 21);
            this._cbSmoothing.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(276, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.31694F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.68306F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(338, 366);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 272);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(338, 94);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this._bGenerate, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this._bSave, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(67, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(202, 94);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // _bGenerate
            // 
            this._bGenerate.BackColor = System.Drawing.Color.White;
            this._bGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bGenerate.Location = new System.Drawing.Point(3, 5);
            this._bGenerate.Name = "_bGenerate";
            this._bGenerate.Size = new System.Drawing.Size(196, 39);
            this._bGenerate.TabIndex = 0;
            this._bGenerate.Text = "Генерировать";
            this._bGenerate.UseVisualStyleBackColor = false;
            this._bGenerate.Click += new System.EventHandler(this.GenerateClick);
            // 
            // _bSave
            // 
            this._bSave.BackColor = System.Drawing.Color.White;
            this._bSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bSave.Enabled = false;
            this._bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bSave.Location = new System.Drawing.Point(3, 50);
            this._bSave.Name = "_bSave";
            this._bSave.Size = new System.Drawing.Size(196, 39);
            this._bSave.TabIndex = 1;
            this._bSave.Text = "Сохранить";
            this._bSave.UseVisualStyleBackColor = false;
            this._bSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this._lbTilesInWorld, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this._lbAllTiles, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(338, 272);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // _lbTilesInWorld
            // 
            this._lbTilesInWorld.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbTilesInWorld.FormattingEnabled = true;
            this._lbTilesInWorld.Location = new System.Drawing.Point(3, 3);
            this._lbTilesInWorld.Name = "_lbTilesInWorld";
            this._lbTilesInWorld.Size = new System.Drawing.Size(106, 266);
            this._lbTilesInWorld.TabIndex = 0;
            // 
            // _lbAllTiles
            // 
            this._lbAllTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbAllTiles.FormattingEnabled = true;
            this._lbAllTiles.Location = new System.Drawing.Point(227, 3);
            this._lbAllTiles.Name = "_lbAllTiles";
            this._lbAllTiles.Size = new System.Drawing.Size(108, 266);
            this._lbAllTiles.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this._bAdd, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this._lPriority, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this._tbPriority, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this._bClear, 0, 4);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(112, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00001F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(112, 272);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // _bAdd
            // 
            this._bAdd.BackColor = System.Drawing.Color.White;
            this._bAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bAdd.Location = new System.Drawing.Point(3, 58);
            this._bAdd.Name = "_bAdd";
            this._bAdd.Size = new System.Drawing.Size(106, 49);
            this._bAdd.TabIndex = 0;
            this._bAdd.Text = "Добавить";
            this._bAdd.UseVisualStyleBackColor = false;
            this._bAdd.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _lPriority
            // 
            this._lPriority.AutoSize = true;
            this._lPriority.BackColor = System.Drawing.SystemColors.ControlLight;
            this._lPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lPriority.Location = new System.Drawing.Point(3, 110);
            this._lPriority.Name = "_lPriority";
            this._lPriority.Size = new System.Drawing.Size(106, 20);
            this._lPriority.TabIndex = 1;
            this._lPriority.Text = "Приоритет";
            this._lPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tbPriority
            // 
            this._tbPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbPriority.Location = new System.Drawing.Point(3, 130);
            this._tbPriority.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this._tbPriority.Multiline = true;
            this._tbPriority.Name = "_tbPriority";
            this._tbPriority.Size = new System.Drawing.Size(106, 24);
            this._tbPriority.TabIndex = 2;
            // 
            // _bClear
            // 
            this._bClear.BackColor = System.Drawing.Color.White;
            this._bClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bClear.Location = new System.Drawing.Point(3, 163);
            this._bClear.Name = "_bClear";
            this._bClear.Size = new System.Drawing.Size(106, 49);
            this._bClear.TabIndex = 3;
            this._bClear.Text = "Очистить";
            this._bClear.UseVisualStyleBackColor = false;
            this._bClear.Click += new System.EventHandler(this.bClearClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coming soon...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 401);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsFormLoad);
            this.tabControl1.ResumeLayout(false);
            this.tpGenerateMap.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this._tlpName.ResumeLayout(false);
            this._tlpName.PerformLayout();
            this._tlpHeight.ResumeLayout(false);
            this._tlpHeight.PerformLayout();
            this._tlpWidth.ResumeLayout(false);
            this._tlpWidth.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGenerateMap;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button _bGenerate;
        private System.Windows.Forms.Button _bSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ListBox _lbTilesInWorld;
        private System.Windows.Forms.ListBox _lbAllTiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button _bAdd;
        private System.Windows.Forms.Label _lPriority;
        private System.Windows.Forms.TextBox _tbPriority;
        private System.Windows.Forms.Button _bClear;
        private System.Windows.Forms.TableLayoutPanel _tlpName;
        private System.Windows.Forms.Label _lName;
        private System.Windows.Forms.TextBox _tbName;
        private System.Windows.Forms.TableLayoutPanel _tlpHeight;
        private System.Windows.Forms.Label _lHeight;
        private System.Windows.Forms.TextBox _tbHeight;
        private System.Windows.Forms.TableLayoutPanel _tlpWidth;
        private System.Windows.Forms.Label _lWidth;
        private System.Windows.Forms.TextBox _tbWidth;
        private Tao.Platform.Windows.SimpleOpenGlControl _preGenPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cbSmoothing;
    }
}