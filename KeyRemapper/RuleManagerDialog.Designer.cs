﻿
namespace KeyRemapper
{
    partial class RuleManagerDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleManagerDialog));
            this.cbCurrentKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbChange = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChangeKey = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCurrentKey
            // 
            this.cbCurrentKey.FormattingEnabled = true;
            this.cbCurrentKey.Location = new System.Drawing.Point(12, 36);
            this.cbCurrentKey.Name = "cbCurrentKey";
            this.cbCurrentKey.Size = new System.Drawing.Size(240, 21);
            this.cbCurrentKey.TabIndex = 0;
            this.cbCurrentKey.SelectedIndexChanged += new System.EventHandler(this.cbCurrentKey_SelectedIndexChanged);
            this.cbCurrentKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCurrentKey_KeyDown);
            this.cbCurrentKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbCurrentKey_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клавиша";
            // 
            // gbChange
            // 
            this.gbChange.Controls.Add(this.label2);
            this.gbChange.Controls.Add(this.cbChangeKey);
            this.gbChange.Location = new System.Drawing.Point(15, 63);
            this.gbChange.Name = "gbChange";
            this.gbChange.Size = new System.Drawing.Size(237, 72);
            this.gbChange.TabIndex = 4;
            this.gbChange.TabStop = false;
            this.gbChange.Text = "Заменить на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Клавиша";
            // 
            // cbChangeKey
            // 
            this.cbChangeKey.FormattingEnabled = true;
            this.cbChangeKey.Location = new System.Drawing.Point(9, 41);
            this.cbChangeKey.Name = "cbChangeKey";
            this.cbChangeKey.Size = new System.Drawing.Size(222, 21);
            this.cbChangeKey.TabIndex = 5;
            this.cbChangeKey.SelectedIndexChanged += new System.EventHandler(this.cbChangeKey_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RuleManagerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 203);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurrentKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(288, 242);
            this.MinimumSize = new System.Drawing.Size(288, 242);
            this.Name = "RuleManagerDialog";
            this.Text = "RuleManagerDialog";
            this.Load += new System.EventHandler(this.RuleManagerDialog_Load);
            this.gbChange.ResumeLayout(false);
            this.gbChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurrentKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChangeKey;
        private System.Windows.Forms.Button button1;
    }
}