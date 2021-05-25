using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var myFile = @"c:\temp\DesktopClient.log";
            TextWriterTraceListener myTextListener = new
                TextWriterTraceListener(myFile);
            Trace.Listeners.Add(myTextListener);

            var config = TelemetryConfiguration.Active;
 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
