using Microsoft.ApplicationInsights.DependencyCollector;
using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = TelemetryConfiguration.Active;

            //Not needed with ApplicationInsights.config, and NuGet refernce
            //DependencyTrackingTelemetryModule depModule = new DependencyTrackingTelemetryModule();
            //depModule.Initialize(TelemetryConfiguration.Active);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
