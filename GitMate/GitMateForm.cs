using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitMate
{
    public partial class GitMateForm : Form
    {
        public GitMateForm()
        {
            InitializeComponent();
        }

        private void exitGitMateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
