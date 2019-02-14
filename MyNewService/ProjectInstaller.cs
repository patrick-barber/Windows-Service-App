﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;


namespace WindowsService
{
    [RunInstallerAttribute(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        protected override void OnBeforeInstall(IDictionary savedState)
        {
            string parameter = "MySource1\" \"MyLogFile1";
            Context.Parameters["assemblypath"] = "\"" + Context.Parameters["assemblypath"] + "\" \"" + parameter + "\"";
            base.OnBeforeInstall(savedState);
        }
        private void serviceProcessInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            
        }
        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {

        }

    }
}
