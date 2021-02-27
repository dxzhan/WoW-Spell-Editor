﻿using NLog;
using System;
using System.Windows;

namespace SpellEditor
{
    public partial class App
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            Logger.Info("######################################################");
            Logger.Info($"Stopped WoW Spell Editor - {DateTime.Now.ToString()}");
            Logger.Info("######################################################");
            Console.Out.Flush();
        }
    }
}
