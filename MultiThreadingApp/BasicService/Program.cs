﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BasicService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
		/// Test
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new BasicService.Services.BasicSer()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
