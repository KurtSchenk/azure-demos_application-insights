using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FrontEndWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class FrontEndService : IFrontEndService
    {
        public static TelemetryClient InitAiConfigAndGetTelemetyrClient()
        {         
            TelemetryClient tc = new TelemetryClient(TelemetryConfiguration.Active);
            tc.InstrumentationKey = TelemetryConfiguration.Active.InstrumentationKey;
            return tc;
        }


        internal static async Task<double> GetPiFromApiPiDelivery()
        {
            WebClient client = new WebClient();
            string pi = await client.DownloadStringTaskAsync("https://api.pi.delivery/v1/pi?start=0&numberOfDigits=5");
            // value of pi will come as JSON like {"content":"3.141"}. Using RegEx to extract value
            pi = Regex.Match(pi, @"[\d.]+").Value;
            return Convert.ToDouble(pi);
        }

        public string GetAreaOfCircle(string value)
        {
            var client = InitAiConfigAndGetTelemetyrClient();

            ////var helper = TestHelper.NetNamedPipes;
            //var activity = new Activity("Root");
            //activity.AddBaggage("foo", "bar");
            //var id = activity.Id;
            //activity.Start();


            //TelemetryClient client = GetTelemetryClient();

            //IOperationHolder<DependencyTelemetry> holder = client.StartOperation<DependencyTelemetry>("Custom operation from FrontEndWCFService");
            //holder.Telemetry.Type = "Custom";
            double radius = Convert.ToDouble(value);
            double pi = GetValueOfPi().Result;
            //client.StopOperation<DependencyTelemetry>(holder);
            return string.Format("Area of circle with {0} raidus is {1}", value, pi * radius * radius);
        }

        private static TelemetryClient GetTelemetryClient()
        {
            return new TelemetryClient(TelemetryConfiguration.Active);
        }


        static readonly Random random = new Random();
        private static async Task<double> GetValueOfPi()
        {            
            double pi;
            bool shouldGetValueFromServiceConfig = Convert.ToBoolean(ConfigurationManager.AppSettings["ShouldGetPiFromService"]);
            //bool shouldGetPiFromService = shouldGetValueFromServiceConfig | random.Next() % 2 == 0;
            //bool shouldGetPiFromService = false;
            //shouldGetPiFromService = false; // Hack if the netPipeService is not working.
            if (shouldGetValueFromServiceConfig) {

                InternalServiceReference.InternalServiceClient serviceClient = new InternalServiceReference.InternalServiceClient();
                pi = await serviceClient.GetValueOfPiAsync();

                //pi = await GetPiFromApiPiDelivery();
            }
            else
            {
                pi = 3.14;
            }
            
            await Task.Delay(1000);
            EventTelemetry et = new EventTelemetry();
            et.Name = "FrontEndService.GetValueOfPi()";
            et.Properties.Add("message", $"value of pi obtained= {pi}");
            GetTelemetryClient().TrackTrace($"{nameof(GetValueOfPi)}Value of pi obtained= {pi}");
            
            return pi;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
