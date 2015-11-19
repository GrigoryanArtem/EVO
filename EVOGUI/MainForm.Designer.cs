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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this._tpWorld = new System.Windows.Forms.TabPage();
            this._tpOrganism = new System.Windows.Forms.TabPage();
            this._tpHistory = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(704, 436);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl.Controls.Add(this._tpWorld);
            this.tabControl.Controls.Add(this._tpOrganism);
            this.tabControl.Controls.Add(this._tpHistory);
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
            this._tpWorld.Location = new System.Drawing.Point(4, 4);
            this._tpWorld.Name = "_tpWorld";
            this._tpWorld.Padding = new System.Windows.Forms.Padding(3);
            this._tpWorld.Size = new System.Drawing.Size(218, 428);
            this._tpWorld.TabIndex = 0;
            this._tpWorld.Text = "World";
            this._tpWorld.UseVisualStyleBackColor = true;
            // 
            // _tpOrganism
            // 
            this._tpOrganism.Location = new System.Drawing.Point(4, 4);
            this._tpOrganism.Name = "_tpOrganism";
            this._tpOrganism.Padding = new System.Windows.Forms.Padding(3);
            this._tpOrganism.Size = new System.Drawing.Size(218, 428);
            this._tpOrganism.TabIndex = 1;
            this._tpOrganism.Text = "Organism";
            this._tpOrganism.UseVisualStyleBackColor = true;
            // 
            // _tpHistory
            // 
            this._tpHistory.Location = new System.Drawing.Point(4, 4);
            this._tpHistory.Name = "_tpHistory";
            this._tpHistory.Size = new System.Drawing.Size(218, 428);
            this._tpHistory.TabIndex = 2;
            this._tpHistory.Text = "History";
            this._tpHistory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 460);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "E.V.O";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
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
    }
}