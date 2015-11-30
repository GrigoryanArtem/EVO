namespace EVOGUI
{
    partial class LauncherForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this._cbSelectWorld = new System.Windows.Forms.ComboBox();
            this.lName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(19, 12);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(137, 75);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "EVO";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.White;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Location = new System.Drawing.Point(24, 159);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(132, 45);
            this.bStart.TabIndex = 3;
            this.bStart.Text = "Старт";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStartClick);
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.Color.White;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.Location = new System.Drawing.Point(24, 210);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(132, 45);
            this.bSettings.TabIndex = 4;
            this.bSettings.Text = "Настройки";
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettingsClick);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.White;
            this.bExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Location = new System.Drawing.Point(24, 261);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(132, 45);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // _cbSelectWorld
            // 
            this._cbSelectWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSelectWorld.FormattingEnabled = true;
            this._cbSelectWorld.Location = new System.Drawing.Point(24, 117);
            this._cbSelectWorld.Name = "_cbSelectWorld";
            this._cbSelectWorld.Size = new System.Drawing.Size(132, 21);
            this._cbSelectWorld.TabIndex = 6;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.BackColor = System.Drawing.Color.Transparent;
            this.lName.Location = new System.Drawing.Point(21, 101);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(80, 13);
            this.lName.TabIndex = 7;
            this.lName.Text = "Выберете мир";
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EVOGUI.Properties.Resources.LauncherBackground;
            this.ClientSize = new System.Drawing.Size(178, 321);
            this.Controls.Add(this.lName);
            this.Controls.Add(this._cbSelectWorld);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LauncherForm";
            this.Text = "EVO";
            this.Load += new System.EventHandler(this.LauncherFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ComboBox _cbSelectWorld;
        private System.Windows.Forms.Label lName;
    }
}

