
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
            this.lbRules.Location = new System.Drawing.Point(222, 32);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(251, 342);
            this.lbRules.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Правила";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(12, 32);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(204, 23);
            this.btnAddRule.TabIndex = 2;
            this.btnAddRule.Text = "Добавить правило";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.Location = new System.Drawing.Point(12, 61);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(204, 23);
            this.btnRemoveRule.TabIndex = 3;
            this.btnRemoveRule.Text = "Удалить правило";
            this.btnRemoveRule.UseVisualStyleBackColor = true;
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // btnStartKeyListen
            // 
            this.btnStartKeyListen.Location = new System.Drawing.Point(12, 322);
            this.btnStartKeyListen.Name = "btnStartKeyListen";
            this.btnStartKeyListen.Size = new System.Drawing.Size(204, 23);
            this.btnStartKeyListen.TabIndex = 4;
            this.btnStartKeyListen.Text = "Старт";
            this.btnStartKeyListen.UseVisualStyleBackColor = true;
            this.btnStartKeyListen.Click += new System.EventHandler(this.btnStartKeyListen_Click);
            // 
            // btnStopKeyListen
            // 
            this.btnStopKeyListen.Enabled = false;
            this.btnStopKeyListen.Location = new System.Drawing.Point(12, 351);
            this.btnStopKeyListen.Name = "btnStopKeyListen";
            this.btnStopKeyListen.Size = new System.Drawing.Size(204, 23);
            this.btnStopKeyListen.TabIndex = 5;
            this.btnStopKeyListen.Text = "Стоп";
            this.btnStopKeyListen.UseVisualStyleBackColor = true;
            this.btnStopKeyListen.Click += new System.EventHandler(this.btnStopKeyListen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 386);
            this.Controls.Add(this.btnStopKeyListen);
            this.Controls.Add(this.btnStartKeyListen);
            this.Controls.Add(this.btnRemoveRule);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(499, 425);
            this.MinimumSize = new System.Drawing.Size(499, 425);
            this.Name = "MainForm";
            this.Text = "KeysRemapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
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
    }
}

