namespace EVOGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._mainDrawingBox = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this._tpWorld = new System.Windows.Forms.TabPage();
            this._tlpWorld = new System.Windows.Forms.TableLayoutPanel();
            this._lWorldName = new System.Windows.Forms.Label();
            this._bStdPainter = new System.Windows.Forms.Button();
            this._bTemperaturePainter = new System.Windows.Forms.Button();
            this._bHumidityPainter = new System.Windows.Forms.Button();
            this._bPassabilityPainter = new System.Windows.Forms.Button();
            this._btnTimerToggle = new System.Windows.Forms.Button();
            this._tpTiles = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._lTileName = new System.Windows.Forms.Label();
            this._tpOrganism = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this._tpHistory = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this._tpStatistic = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this._timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this._tpWorld.SuspendLayout();
            this._tlpWorld.SuspendLayout();
            this._tpTiles.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._tpOrganism.SuspendLayout();
            this._tpHistory.SuspendLayout();
            this._tpStatistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Olive;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._mainDrawingBox);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(704, 436);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 1;
            // 
            // _mainDrawingBox
            // 
            this._mainDrawingBox.AccumBits = ((byte)(0));
            this._mainDrawingBox.AutoCheckErrors = false;
            this._mainDrawingBox.AutoFinish = false;
            this._mainDrawingBox.AutoMakeCurrent = true;
            this._mainDrawingBox.AutoSwapBuffers = true;
            this._mainDrawingBox.BackColor = System.Drawing.Color.Black;
            this._mainDrawingBox.ColorBits = ((byte)(32));
            this._mainDrawingBox.DepthBits = ((byte)(16));
            this._mainDrawingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainDrawingBox.Location = new System.Drawing.Point(6, 3);
            this._mainDrawingBox.Name = "_mainDrawingBox";
            this._mainDrawingBox.Size = new System.Drawing.Size(446, 430);
            this._mainDrawingBox.StencilBits = ((byte)(0));
            this._mainDrawingBox.TabIndex = 0;
            this._mainDrawingBox.SizeChanged += new System.EventHandler(this.mainBoxSizeChanged);
            this._mainDrawingBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainDrawingBoxMouseClick);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl.Controls.Add(this._tpWorld);
            this.tabControl.Controls.Add(this._tpTiles);
            this.tabControl.Controls.Add(this._tpOrganism);
            this.tabControl.Controls.Add(this._tpHistory);
            this.tabControl.Controls.Add(this._tpStatistic);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(245, 436);
            this.tabControl.TabIndex = 0;
            // 
            // _tpWorld
            // 
            this._tpWorld.BackColor = System.Drawing.Color.Transparent;
            this._tpWorld.Controls.Add(this._tlpWorld);
            this._tpWorld.Location = new System.Drawing.Point(4, 4);
            this._tpWorld.Name = "_tpWorld";
            this._tpWorld.Padding = new System.Windows.Forms.Padding(3);
            this._tpWorld.Size = new System.Drawing.Size(218, 428);
            this._tpWorld.TabIndex = 0;
            this._tpWorld.Text = "World";
            this._tpWorld.UseVisualStyleBackColor = true;
            // 
            // _tlpWorld
            // 
            this._tlpWorld.ColumnCount = 1;
            this._tlpWorld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpWorld.Controls.Add(this._lWorldName, 0, 0);
            this._tlpWorld.Controls.Add(this._bStdPainter, 0, 2);
            this._tlpWorld.Controls.Add(this._bTemperaturePainter, 0, 3);
            this._tlpWorld.Controls.Add(this._bHumidityPainter, 0, 4);
            this._tlpWorld.Controls.Add(this._bPassabilityPainter, 0, 5);
            this._tlpWorld.Controls.Add(this._btnTimerToggle, 0, 7);
            this._tlpWorld.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpWorld.Location = new System.Drawing.Point(3, 3);
            this._tlpWorld.Name = "_tlpWorld";
            this._tlpWorld.RowCount = 9;
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.535147F));
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.545946F));
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this._tlpWorld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.91891F));
            this._tlpWorld.Size = new System.Drawing.Size(212, 422);
            this._tlpWorld.TabIndex = 0;
            // 
            // _lWorldName
            // 
            this._lWorldName.AutoSize = true;
            this._lWorldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lWorldName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lWorldName.Location = new System.Drawing.Point(3, 0);
            this._lWorldName.Name = "_lWorldName";
            this._lWorldName.Size = new System.Drawing.Size(206, 40);
            this._lWorldName.TabIndex = 0;
            this._lWorldName.Text = "World Name";
            this._lWorldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _bStdPainter
            // 
            this._bStdPainter.BackColor = System.Drawing.Color.LightGray;
            this._bStdPainter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bStdPainter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bStdPainter.Location = new System.Drawing.Point(3, 48);
            this._bStdPainter.Name = "_bStdPainter";
            this._bStdPainter.Size = new System.Drawing.Size(206, 44);
            this._bStdPainter.TabIndex = 1;
            this._bStdPainter.Text = "STD";
            this._bStdPainter.UseVisualStyleBackColor = false;
            this._bStdPainter.Click += new System.EventHandler(this.StdPainterClick);
            // 
            // _bTemperaturePainter
            // 
            this._bTemperaturePainter.BackColor = System.Drawing.Color.LightGray;
            this._bTemperaturePainter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bTemperaturePainter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bTemperaturePainter.Location = new System.Drawing.Point(3, 98);
            this._bTemperaturePainter.Name = "_bTemperaturePainter";
            this._bTemperaturePainter.Size = new System.Drawing.Size(206, 44);
            this._bTemperaturePainter.TabIndex = 2;
            this._bTemperaturePainter.Text = "Temperature";
            this._bTemperaturePainter.UseVisualStyleBackColor = false;
            this._bTemperaturePainter.Click += new System.EventHandler(this.TemperaturePainterClick);
            // 
            // _bHumidityPainter
            // 
            this._bHumidityPainter.BackColor = System.Drawing.Color.LightGray;
            this._bHumidityPainter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bHumidityPainter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bHumidityPainter.Location = new System.Drawing.Point(3, 148);
            this._bHumidityPainter.Name = "_bHumidityPainter";
            this._bHumidityPainter.Size = new System.Drawing.Size(206, 44);
            this._bHumidityPainter.TabIndex = 3;
            this._bHumidityPainter.Text = "Humidity";
            this._bHumidityPainter.UseVisualStyleBackColor = false;
            this._bHumidityPainter.Click += new System.EventHandler(this.HumidityPainterClick);
            // 
            // _bPassabilityPainter
            // 
            this._bPassabilityPainter.BackColor = System.Drawing.Color.LightGray;
            this._bPassabilityPainter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bPassabilityPainter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._bPassabilityPainter.Location = new System.Drawing.Point(3, 198);
            this._bPassabilityPainter.Name = "_bPassabilityPainter";
            this._bPassabilityPainter.Size = new System.Drawing.Size(206, 44);
            this._bPassabilityPainter.TabIndex = 4;
            this._bPassabilityPainter.Text = "Passability";
            this._bPassabilityPainter.UseVisualStyleBackColor = false;
            this._bPassabilityPainter.Click += new System.EventHandler(this.PassabilityPainterClick);
            // 
            // _btnTimerToggle
            // 
            this._btnTimerToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnTimerToggle.Location = new System.Drawing.Point(3, 254);
            this._btnTimerToggle.Name = "_btnTimerToggle";
            this._btnTimerToggle.Size = new System.Drawing.Size(206, 44);
            this._btnTimerToggle.TabIndex = 5;
            this._btnTimerToggle.Text = "Timer Toggle";
            this._btnTimerToggle.UseVisualStyleBackColor = true;
            this._btnTimerToggle.Click += new System.EventHandler(this.button1_Click);
            // 
            // _tpTiles
            // 
            this._tpTiles.Controls.Add(this.tableLayoutPanel1);
            this._tpTiles.Location = new System.Drawing.Point(4, 4);
            this._tpTiles.Name = "_tpTiles";
            this._tpTiles.Size = new System.Drawing.Size(218, 428);
            this._tpTiles.TabIndex = 4;
            this._tpTiles.Text = "Tiles";
            this._tpTiles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._lTileName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 428);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _lTileName
            // 
            this._lTileName.AutoSize = true;
            this._lTileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lTileName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lTileName.Location = new System.Drawing.Point(3, 0);
            this._lTileName.Name = "_lTileName";
            this._lTileName.Size = new System.Drawing.Size(212, 50);
            this._lTileName.TabIndex = 0;
            this._lTileName.Text = "Tile Name";
            this._lTileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tpOrganism
            // 
            this._tpOrganism.Controls.Add(this.label2);
            this._tpOrganism.Location = new System.Drawing.Point(4, 4);
            this._tpOrganism.Name = "_tpOrganism";
            this._tpOrganism.Padding = new System.Windows.Forms.Padding(3);
            this._tpOrganism.Size = new System.Drawing.Size(218, 428);
            this._tpOrganism.TabIndex = 1;
            this._tpOrganism.Text = "Organism";
            this._tpOrganism.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 396);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coming soon...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tpHistory
            // 
            this._tpHistory.Controls.Add(this.label3);
            this._tpHistory.Location = new System.Drawing.Point(4, 4);
            this._tpHistory.Name = "_tpHistory";
            this._tpHistory.Size = new System.Drawing.Size(218, 428);
            this._tpHistory.TabIndex = 2;
            this._tpHistory.Text = "History";
            this._tpHistory.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 399);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Coming soon...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tpStatistic
            // 
            this._tpStatistic.Controls.Add(this.label4);
            this._tpStatistic.Location = new System.Drawing.Point(4, 4);
            this._tpStatistic.Name = "_tpStatistic";
            this._tpStatistic.Size = new System.Drawing.Size(218, 428);
            this._tpStatistic.TabIndex = 3;
            this._tpStatistic.Text = "Statistic";
            this._tpStatistic.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 399);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Coming soon...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _timer
            // 
            this._timer.Interval = 1500;
            this._timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(704, 460);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "E.V.O";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this._tpWorld.ResumeLayout(false);
            this._tlpWorld.ResumeLayout(false);
            this._tlpWorld.PerformLayout();
            this._tpTiles.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._tpOrganism.ResumeLayout(false);
            this._tpOrganism.PerformLayout();
            this._tpHistory.ResumeLayout(false);
            this._tpHistory.PerformLayout();
            this._tpStatistic.ResumeLayout(false);
            this._tpStatistic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage _tpWorld;
        private System.Windows.Forms.TabPage _tpOrganism;
        private System.Windows.Forms.TabPage _tpHistory;
        private System.Windows.Forms.TabPage _tpStatistic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Tao.Platform.Windows.SimpleOpenGlControl _mainDrawingBox;
        private System.Windows.Forms.TableLayoutPanel _tlpWorld;
        private System.Windows.Forms.Label _lWorldName;
        private System.Windows.Forms.TabPage _tpTiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _lTileName;
        private System.Windows.Forms.Button _bStdPainter;
        private System.Windows.Forms.Button _bTemperaturePainter;
        private System.Windows.Forms.Button _bHumidityPainter;
        private System.Windows.Forms.Button _bPassabilityPainter;
        private System.Windows.Forms.Button _btnTimerToggle;
        private System.Windows.Forms.Timer _timer;
    }
}