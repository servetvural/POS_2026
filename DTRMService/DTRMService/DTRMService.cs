using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DTRMService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DTRMService" in both code and config file together.
    public class DTRMService : IDTRMService {
        public string GetMessage(string name) {
            return "Hello " + name;
        }
    }
}
