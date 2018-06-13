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
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.exitGitMateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoryMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.fileMenu,
            this.repositoryMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRepo,
            this.toolStripMenuItem7,
            this.toolStripMenuItem9,
            this.exitGitMateToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            //this.fileMenu.Click += new System.EventHandler(this.gitMateToolStripMenuItem_Click);
            // 
            // openRepo
            // 
            this.openRepo.Name = "openRepo";
            this.openRepo.Size = new System.Drawing.Size(199, 22);
            this.openRepo.Text = "Open Repository";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem7.Text = "New/Clone Repository..";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(196, 6);
            // 
            // exitGitMateToolStripMenuItem
            // 
            this.exitGitMateToolStripMenuItem.Name = "exitGitMateToolStripMenuItem";
            this.exitGitMateToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exitGitMateToolStripMenuItem.Text = "Exit GitMate";
            this.exitGitMateToolStripMenuItem.Click += new System.EventHandler(this.exitGitMateToolStripMenuItem_Click);
            // 
            // repositoryMenu
            // 
            this.repositoryMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.repositoryMenu.Name = "repositoryMenu";
            this.repositoryMenu.Size = new System.Drawing.Size(75, 20);
            this.repositoryMenu.Text = "Repository";
            // 
            // commitToolStripMenuItem
            // 
            this.commitToolStripMenuItem.Name = "commitToolStripMenuItem";
            this.commitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commitToolStripMenuItem.Text = "Refresh Status";
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
            this.ClientSize = new System.Drawing.Size(578, 383);
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
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitGitMateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositoryMenu;
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
        private System.Windows.Forms.ToolStripMenuItem openRepo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
    }
}

