﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OrganizadorFutbol5.Ventanas;

namespace OrganizadorFutbol5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Application.Run(new HomeAdministrador(-1));
        }
    }
}
