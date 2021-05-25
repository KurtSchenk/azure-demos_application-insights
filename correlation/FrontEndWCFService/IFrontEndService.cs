using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFrontEndService
    {
        [OperationContract]
        [WebGet (UriTemplate ="areaOf/{radius}")]
        string GetAreaOfCircle(string radius);

        [OperationContract]
        [WebGet(UriTemplate = "areaOfAsync/{radius}")]
        Task<string> GetAreaOfCircle2Async(string radius);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        [WebGet(UriTemplate = "rootId")]
        string GetActivityRootId();

        [OperationContract]
        //string GetActivityRootId2Hop([CallerMemberName] string instancePath = "");
        [WebGet(UriTemplate = "rootId2Hop")]
        string GetActivityRootId2Hop();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
