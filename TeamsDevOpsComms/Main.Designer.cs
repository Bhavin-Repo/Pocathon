namespace TeamsDevOpsComms
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
            this.cmdSignOn = new System.Windows.Forms.Button();
            this.ResponseText = new System.Windows.Forms.TextBox();
            this.TokenDetails = new System.Windows.Forms.TextBox();
            this.GetTeamsBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CurrentStatusLabel = new System.Windows.Forms.Label();
            this.TeamsTreeView = new System.Windows.Forms.TreeView();
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
            // ResponseText
            // 
            this.ResponseText.Location = new System.Drawing.Point(17, 188);
            this.ResponseText.Margin = new System.Windows.Forms.Padding(4);
            this.ResponseText.Multiline = true;
            this.ResponseText.Name = "ResponseText";
            this.ResponseText.Size = new System.Drawing.Size(864, 309);
            this.ResponseText.TabIndex = 1;
            // 
            // TokenDetails
            // 
            this.TokenDetails.Location = new System.Drawing.Point(17, 505);
            this.TokenDetails.Margin = new System.Windows.Forms.Padding(4);
            this.TokenDetails.Multiline = true;
            this.TokenDetails.Name = "TokenDetails";
            this.TokenDetails.Size = new System.Drawing.Size(784, 44);
            this.TokenDetails.TabIndex = 2;
            // 
            // GetTeamsBtn
            // 
            this.GetTeamsBtn.Location = new System.Drawing.Point(201, 22);
            this.GetTeamsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GetTeamsBtn.Name = "GetTeamsBtn";
            this.GetTeamsBtn.Size = new System.Drawing.Size(101, 36);
            this.GetTeamsBtn.TabIndex = 3;
            this.GetTeamsBtn.Text = "Get Teams...";
            this.GetTeamsBtn.UseVisualStyleBackColor = true;
            this.GetTeamsBtn.Click += new System.EventHandler(this.GetTeamsBtn_Click);
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
            // TeamsTreeView
            // 
            this.TeamsTreeView.Location = new System.Drawing.Point(17, 79);
            this.TeamsTreeView.Name = "TeamsTreeView";
            this.TeamsTreeView.Size = new System.Drawing.Size(780, 102);
            this.TeamsTreeView.TabIndex = 6;
            this.TeamsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TeamsTreeView_AfterSelect);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 579);
            this.Controls.Add(this.TeamsTreeView);
            this.Controls.Add(this.CurrentStatusLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.GetTeamsBtn);
            this.Controls.Add(this.TokenDetails);
            this.Controls.Add(this.ResponseText);
            this.Controls.Add(this.cmdSignOn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Teams -> DevOps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSignOn;
        private System.Windows.Forms.TextBox ResponseText;
        private System.Windows.Forms.TextBox TokenDetails;
        private System.Windows.Forms.Button GetTeamsBtn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CurrentStatusLabel;
        private System.Windows.Forms.TreeView TeamsTreeView;
    }
}

