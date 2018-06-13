using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitMate
{
    class Git
    {
        private static readonly string GitConfigName = ConfigurationManager.AppSettings.Get("GitConfigName");
        private static readonly string GitConfigEmail = ConfigurationManager.AppSettings.Get("GitConfigEmail");

        public string Root { get; private set; }

        private static Git instance = null;
        private static readonly object gitLock = new object();

        /// <summary>
        /// Simple Thread-safe Singleton Instance of Git
        /// </summary>
        public static Git Instance
        {
            get
            {
                lock(gitLock) { return instance ?? (instance = new Git()); }
            }
        }

        private static Signature Committer
        {
            get { return new Signature(GitConfigName, GitConfigEmail, DateTime.Now); }
        }
        /// <summary>
        /// Initializes a GIT repository at the location specified 
        /// </summary>
        public void Init()
        {

        }
    }
}
