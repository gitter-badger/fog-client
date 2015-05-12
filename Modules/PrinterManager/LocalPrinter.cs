﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using FOG.Handlers;

namespace FOG.Modules
{
    class LocalPrinter : Printer
    {
        public LocalPrinter(string name, string file, string port, string model, bool defaulted)
        {
            Name = name;
            Port = port;
            File = file;
            Model = model;
            Default = defaulted;
            LogName = "LocalPrinter";
        }

        public override void Add()
        {
            LogHandler.Log(LogName, "Attempting to add printer:");
            LogHandler.Log(LogName, string.Format("--> Name = {0}", Name));
            LogHandler.Log(LogName, string.Format("--> Port = {0}", Port));
            LogHandler.Log(LogName, string.Format("--> File = {0}", File));
            LogHandler.Log(LogName, string.Format("--> Model = {0}", Model));

            var proc = Process.Start("rundll32.exe", 
                string.Format(" printui.dll,PrintUIEntry /if /q /b \"{0}\" /f \"{1}\" /r \"{2}\" /m \"{3}\"", Name, File, Port, Model));
            proc.WaitForExit(120000);
        }
    }
}
