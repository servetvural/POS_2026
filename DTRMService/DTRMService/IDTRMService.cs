using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DTRMService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDTRMService" in both code and config file together.
    [ServiceContract]
    public interface IDTRMService {
        [OperationContract]
        string GetMessage(string name);
    }
}
