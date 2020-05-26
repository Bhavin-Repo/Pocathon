﻿namespace TeamsDevOpsComms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cmdSignOn = new System.Windows.Forms.Button();
            this.TokenDetails = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CurrentStatusLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TeamsTreeView = new System.Windows.Forms.TreeView();
            this.GetTeamsBtn = new System.Windows.Forms.Button();
            this.ResponseText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSignOn
            // 
            this.cmdSignOn.Location = new System.Drawing.Point(17, 22);
            this.cmdSignOn.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSignOn.Name = "cmdSignOn";
            this.cmdSignOn.Size = new System.Drawing.Size(101, 36);
            this.cmdSignOn.TabIndex = 0;
            this.cmdSignOn.Text = "Sign On";
            this.cmdSignOn.UseVisualStyleBackColor = true;
            this.cmdSignOn.Click += new System.EventHandler(this.cmdSignOn_Click);
            // 
            // TokenDetails
            // 
            this.TokenDetails.Location = new System.Drawing.Point(17, 307);
            this.TokenDetails.Margin = new System.Windows.Forms.Padding(4);
            this.TokenDetails.Multiline = true;
            this.TokenDetails.Name = "TokenDetails";
            this.TokenDetails.Size = new System.Drawing.Size(633, 44);
            this.TokenDetails.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(123, 553);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(103, 17);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Not signed in...";
            // 
            // CurrentStatusLabel
            // 
            this.CurrentStatusLabel.AutoSize = true;
            this.CurrentStatusLabel.Location = new System.Drawing.Point(14, 553);
            this.CurrentStatusLabel.Name = "CurrentStatusLabel";
            this.CurrentStatusLabel.Size = new System.Drawing.Size(103, 17);
            this.CurrentStatusLabel.TabIndex = 5;
            this.CurrentStatusLabel.Text = "Current Status:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 402);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TeamsTreeView);
            this.tabPage1.Controls.Add(this.GetTeamsBtn);
            this.tabPage1.Controls.Add(this.ResponseText);
            this.tabPage1.Controls.Add(this.TokenDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TeamsTreeView
            // 
            this.TeamsTreeView.Location = new System.Drawing.Point(17, 62);
            this.TeamsTreeView.Name = "TeamsTreeView";
            this.TeamsTreeView.Size = new System.Drawing.Size(633, 87);
            this.TeamsTreeView.TabIndex = 7;
            this.TeamsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TeamsTreeView_AfterSelect);
            // 
            // GetTeamsBtn
            // 
            this.GetTeamsBtn.Location = new System.Drawing.Point(17, 7);
            this.GetTeamsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GetTeamsBtn.Name = "GetTeamsBtn";
            this.GetTeamsBtn.Size = new System.Drawing.Size(101, 36);
            this.GetTeamsBtn.TabIndex = 4;
            this.GetTeamsBtn.Text = "List Teams";
            this.GetTeamsBtn.UseVisualStyleBackColor = true;
            this.GetTeamsBtn.Click += new System.EventHandler(this.GetTeamsBtn_Click);
            // 
            // ResponseText
            // 
            this.ResponseText.Location = new System.Drawing.Point(20, 168);
            this.ResponseText.Margin = new System.Windows.Forms.Padding(4);
            this.ResponseText.Multiline = true;
            this.ResponseText.Name = "ResponseText";
            this.ResponseText.Size = new System.Drawing.Size(630, 120);
            this.ResponseText.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CurrentStatusLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.cmdSignOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Teams -> DevOps";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSignOn;
        private System.Windows.Forms.TextBox TokenDetails;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CurrentStatusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView TeamsTreeView;
        private System.Windows.Forms.Button GetTeamsBtn;
        private System.Windows.Forms.TextBox ResponseText;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

