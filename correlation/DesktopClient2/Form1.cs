using Microsoft.ApplicationInsights.DataContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Log(string message, string opId = null)
        {
            string msgToLog = $"Thread Id-{Thread.CurrentThread.ManagedThreadId},OpId - {opId}, Message - {message}";
            Trace.WriteLine(msgToLog);
            new AppInsightLogger().TrackTrace(msgToLog);
        }

        private double GetAreaFromAspNetRestAPI(double radius, string operation_id)
        {
            //return Task.Run<double>(async () =>
            //{
                operation_id = System.Diagnostics.Activity.Current.Id;

                var url = $"http://localhost:53370/api/shapes/circle/{radius}";
                var wc = new WebClient();
                //wc.Headers.Add("Request-Id", operation_id); //TODO: Don't do anything, assume Application Insights will do this correctly.
                //wc.Headers.Add("traceparent", operation_id); 
                string value = wc.DownloadString(url);
                value = Regex.Matches(value, @"\d+").OfType<Match>().Select(m => m.Value).LastOrDefault();
                Log($"GetAreaFromAspNetResTAPI - Value from AspNet Rest service - {value}");
                return Convert.ToDouble(value);
            //});
        }
        private void BtnAspNet_Click(object sender, EventArgs e)
        {
            var activity = new Activity("Root");
            activity.AddBaggage("foo1", "bar1");
            activity.Start();

            string opId = "opid_not_set";  //Guid.NewGuid().ToString();
            var opHolder = new AppInsightLogger().StartOperation<RequestTelemetry>("btnAspNet_Click", opId);

            Log("btnAspNet_Click - Entered", opId);

            double area = GetAreaFromAspNetRestAPI(GetRadiusFromUI(), opId);

            Log($"btnAspNet_Click - Area is - {area}", opId);
            new AppInsightLogger().StopOperation(opHolder);

        }

        private double GetRadiusFromUI()
        {
            string radiusString = "10";
            double radius = Convert.ToDouble(radiusString);
            int delay = new Random().Next() % 8000;
            Task.Delay(delay).GetAwaiter().GetResult();
            Log($"Inside GetRadiusFromUI - Radius - {radius},Delay-{delay}");
            return radius;
        }
    }
}
