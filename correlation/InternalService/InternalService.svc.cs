using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace InternalService
{
    public class InternalService : IInternalService
    {
         static InternalService()
        {
            TelemetryAdder.AddToActive();
            var myFile = @"c:\temp\InternalService.log";
            TextWriterTraceListener myTextListener = new
                TextWriterTraceListener(myFile);
            Trace.Listeners.Add(myTextListener);

        }

        public string GetData(int value)
        {
            
            return string.Format("InternalService. You entered: {0}", value);
        }

        public double GetValueOfPi()
        {
            TelemetryClient client = new TelemetryClient(TelemetryConfiguration.Active);
            //IOperationHolder<DependencyTelemetry> holder = client.StartOperation<DependencyTelemetry>("Custom operation from Internal service");
            client.TrackTrace("GetValueOfPi: Custom trace from Internal service");
            //client.StopOperation<DependencyTelemetry>(holder);
            return 3.14d;
        }

        public async Task<double> GetValueOfPi2Async()
        {
            TelemetryClient client = new TelemetryClient(TelemetryConfiguration.Active);
            client.TrackTrace("InternalService.GetValueOfPiAsync: Custom trace from Internal service");
            return await Task.FromResult(3.14d);
        }

        public async Task<string> GetActivityRootId2Async()
        {
            TelemetryClient tc = new TelemetryClient();
            tc.TrackTrace("InternalService.GetActivityRootId2Async start");

            var activity = Activity.Current;
            if (activity == null)
            {
                return null;
            }

            tc.TrackTrace("InternalService.GetActivityRootId2Async end");

            return await Task.FromResult(activity.RootId);
        }
    }
}
