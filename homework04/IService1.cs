using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace homework04
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(ResponseFormat =WebMessageFormat.Json, UriTemplate ="/verification?xmlURL={xmlURL}&xsdURL={xsdURL}")]
        string verification(string xmlURL, string xsdURL);

        [OperationContract]
        [WebGet(ResponseFormat =WebMessageFormat.Json, UriTemplate ="/xPathSearch?xmlURL={xmlURL}&expression={expression}")]
        string xPathSearch(string xmlURL, string expression);
    }
}
