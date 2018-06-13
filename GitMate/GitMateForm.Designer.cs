namespace GitMate
{
    partial class GitMateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitMateForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gitMateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGitMateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.commitSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commitAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.pushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.createBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitMateToolStripMenuItem,
            this.repositoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gitMateToolStripMenuItem
            // 
            this.gitMateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitGitMateToolStripMenuItem});
            this.gitMateToolStripMenuItem.Name = "gitMateToolStripMenuItem";
            this.gitMateToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.gitMateToolStripMenuItem.Text = "File";
            this.gitMateToolStripMenuItem.Click += new System.EventHandler(this.gitMateToolStripMenuItem_Click);
            // 
            // repositoryToolStripMenuItem
            // 
            this.repositoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commitToolStripMenuItem,
            this.aToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.commitSelectedToolStripMenuItem,
            this.commitAllToolStripMenuItem,
            this.toolStripMenuItem3,
            this.pushToolStripMenuItem,
            this.pullToolStripMenuItem,
            this.fetchToolStripMenuItem,
            this.toolStripMenuItem4,
            this.createBranchToolStripMenuItem,
            this.mergeBranchToolStripMenuItem});
            this.repositoryToolStripMenuItem.Name = "repositoryToolStripMenuItem";
            this.repositoryToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.repositoryToolStripMenuItem.Text = "Repository";
            // 
            // exitGitMateToolStripMenuItem
            // 
            this.exitGitMateToolStripMenuItem.Name = "exitGitMateToolStripMenuItem";
            this.exitGitMateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitGitMateToolStripMenuItem.Text = "Exit GitMate";
            this.exitGitMateToolStripMenuItem.Click += new System.EventHandler(this.exitGitMateToolStripMenuItem_Click);
            // 
            // commitToolStripMenuItem
            // 
            this.commitToolStripMenuItem.Name = "commitToolStripMenuItem";
            this.commitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commitToolStripMenuItem.Text = "Refresh Status";
            this.commitToolStripMenuItem.Click += new System.EventHandler(this.commitToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Stage File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // commitSelectedToolStripMenuItem
            // 
            this.commitSelectedToolStripMenuItem.Name = "commitSelectedToolStripMenuItem";
            this.commitSelectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commitSelectedToolStripMenuItem.Text = "Commit Selected";
            // 
            // commitAllToolStripMenuItem
            // 
            this.commitAllToolStripMenuItem.Name = "commitAllToolStripMenuItem";
            this.commitAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commitAllToolStripMenuItem.Text = "Commit All";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // pushToolStripMenuItem
            // 
            this.pushToolStripMenuItem.Name = "pushToolStripMenuItem";
            this.pushToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pushToolStripMenuItem.Text = "Push..";
            // 
            // pullToolStripMenuItem
            // 
            this.pullToolStripMenuItem.Name = "pullToolStripMenuItem";
            this.pullToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pullToolStripMenuItem.Text = "Pull..";
            // 
            // fetchToolStripMenuItem
            // 
            this.fetchToolStripMenuItem.Name = "fetchToolStripMenuItem";
            this.fetchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fetchToolStripMenuItem.Text = "Fetch..";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // createBranchToolStripMenuItem
            // 
            this.createBranchToolStripMenuItem.Name = "createBranchToolStripMenuItem";
            this.createBranchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createBranchToolStripMenuItem.Text = "Create Branch";
            // 
            // mergeBranchToolStripMenuItem
            // 
            this.mergeBranchToolStripMenuItem.Name = "mergeBranchToolStripMenuItem";
            this.mergeBranchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mergeBranchToolStripMenuItem.Text = "Merge Branch";
            // 
            // GitMateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GitMateForm";
            this.Text = "GitMate";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gitMateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGitMateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commitSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commitAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fetchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem createBranchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeBranchToolStripMenuItem;
    }
}

