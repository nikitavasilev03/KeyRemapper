
namespace KeyRemapper
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbRules = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.btnRemoveRule = new System.Windows.Forms.Button();
            this.btnStartKeyListen = new System.Windows.Forms.Button();
            this.btnStopKeyListen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuICloseWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIService = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIReference = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxProfiles = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuIProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIProfileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIProfileEditCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIProfileRemoveCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "KeysRemapper";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 17;
            this.lbRules.Location = new System.Drawing.Point(159, 59);
            this.lbRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(292, 429);
            this.lbRules.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Правила";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(14, 59);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(139, 30);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Добавить правило";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.Location = new System.Drawing.Point(14, 97);
            this.btnRemoveRule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(139, 30);
            this.btnRemoveRule.TabIndex = 3;
            this.btnRemoveRule.Text = "Удалить правило";
            this.btnRemoveRule.UseVisualStyleBackColor = true;
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // btnStartKeyListen
            // 
            this.btnStartKeyListen.Location = new System.Drawing.Point(14, 421);
            this.btnStartKeyListen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartKeyListen.Name = "btnStartKeyListen";
            this.btnStartKeyListen.Size = new System.Drawing.Size(139, 30);
            this.btnStartKeyListen.TabIndex = 4;
            this.btnStartKeyListen.Text = "Старт";
            this.btnStartKeyListen.UseVisualStyleBackColor = true;
            this.btnStartKeyListen.Click += new System.EventHandler(this.btnStartKeyListen_Click);
            // 
            // btnStopKeyListen
            // 
            this.btnStopKeyListen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStopKeyListen.Enabled = false;
            this.btnStopKeyListen.Location = new System.Drawing.Point(14, 459);
            this.btnStopKeyListen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStopKeyListen.Name = "btnStopKeyListen";
            this.btnStopKeyListen.Size = new System.Drawing.Size(139, 29);
            this.btnStopKeyListen.TabIndex = 5;
            this.btnStopKeyListen.Text = "Стоп";
            this.btnStopKeyListen.UseVisualStyleBackColor = true;
            this.btnStopKeyListen.Click += new System.EventHandler(this.btnStopKeyListen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuIService,
            this.toolStripMenuIReference,
            this.toolStripComboBoxProfiles,
            this.toolStripMenuIProfile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuICloseWindow,
            this.toolStripMenuIExit});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(48, 23);
            this.toolStripMenuFile.Text = "Файл";
            // 
            // toolStripMenuICloseWindow
            // 
            this.toolStripMenuICloseWindow.Name = "toolStripMenuICloseWindow";
            this.toolStripMenuICloseWindow.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuICloseWindow.Text = "Закрыть окно";
            this.toolStripMenuICloseWindow.Click += new System.EventHandler(this.toolStripMenuICloseWindow_Click);
            // 
            // toolStripMenuIExit
            // 
            this.toolStripMenuIExit.Name = "toolStripMenuIExit";
            this.toolStripMenuIExit.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuIExit.Text = "Выход";
            this.toolStripMenuIExit.Click += new System.EventHandler(this.toolStripMenuIExit_Click);
            // 
            // toolStripMenuIService
            // 
            this.toolStripMenuIService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuIOptions});
            this.toolStripMenuIService.Name = "toolStripMenuIService";
            this.toolStripMenuIService.Size = new System.Drawing.Size(59, 23);
            this.toolStripMenuIService.Text = "Сервис";
            // 
            // toolStripMenuIOptions
            // 
            this.toolStripMenuIOptions.Name = "toolStripMenuIOptions";
            this.toolStripMenuIOptions.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuIOptions.Text = "Настройки";
            this.toolStripMenuIOptions.Click += new System.EventHandler(this.toolStripMenuIOptions_Click);
            // 
            // toolStripMenuIReference
            // 
            this.toolStripMenuIReference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuIAbout});
            this.toolStripMenuIReference.Name = "toolStripMenuIReference";
            this.toolStripMenuIReference.Size = new System.Drawing.Size(65, 23);
            this.toolStripMenuIReference.Text = "Справка";
            // 
            // toolStripMenuIAbout
            // 
            this.toolStripMenuIAbout.Name = "toolStripMenuIAbout";
            this.toolStripMenuIAbout.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuIAbout.Text = "О программе";
            this.toolStripMenuIAbout.Click += new System.EventHandler(this.toolStripMenuIAbout_Click);
            // 
            // toolStripComboBoxProfiles
            // 
            this.toolStripComboBoxProfiles.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxProfiles.Name = "toolStripComboBoxProfiles";
            this.toolStripComboBoxProfiles.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripMenuIProfile
            // 
            this.toolStripMenuIProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuIProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuIProfileCreate,
            this.toolStripMenuIProfileEditCurrent,
            this.toolStripMenuIProfileRemoveCurrent});
            this.toolStripMenuIProfile.Name = "toolStripMenuIProfile";
            this.toolStripMenuIProfile.Size = new System.Drawing.Size(71, 23);
            this.toolStripMenuIProfile.Text = "Профиль";
            // 
            // toolStripMenuIProfileCreate
            // 
            this.toolStripMenuIProfileCreate.Name = "toolStripMenuIProfileCreate";
            this.toolStripMenuIProfileCreate.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuIProfileCreate.Text = "Создать";
            this.toolStripMenuIProfileCreate.Click += new System.EventHandler(this.toolStripMenuIProfileCreate_Click);
            // 
            // toolStripMenuIProfileEditCurrent
            // 
            this.toolStripMenuIProfileEditCurrent.Name = "toolStripMenuIProfileEditCurrent";
            this.toolStripMenuIProfileEditCurrent.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuIProfileEditCurrent.Text = "Изменить текущий";
            this.toolStripMenuIProfileEditCurrent.Click += new System.EventHandler(this.toolStripMenuIProfileEditCurrent_Click);
            // 
            // toolStripMenuIProfileRemoveCurrent
            // 
            this.toolStripMenuIProfileRemoveCurrent.Name = "toolStripMenuIProfileRemoveCurrent";
            this.toolStripMenuIProfileRemoveCurrent.Size = new System.Drawing.Size(179, 22);
            this.toolStripMenuIProfileRemoveCurrent.Text = "Удалить текущий";
            this.toolStripMenuIProfileRemoveCurrent.Click += new System.EventHandler(this.toolStripMenuIProfileRemoveCurrent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 494);
            this.Controls.Add(this.btnStopKeyListen);
            this.Controls.Add(this.btnStartKeyListen);
            this.Controls.Add(this.btnRemoveRule);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRules);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(474, 533);
            this.MinimumSize = new System.Drawing.Size(474, 533);
            this.Name = "MainForm";
            this.Text = "KeysRemapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnRemoveRule;
        private System.Windows.Forms.Button btnStartKeyListen;
        private System.Windows.Forms.Button btnStopKeyListen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuICloseWindow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIService;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIReference;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIAbout;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxProfiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIProfile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIProfileCreate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIProfileEditCurrent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIProfileRemoveCurrent;
    }
}

