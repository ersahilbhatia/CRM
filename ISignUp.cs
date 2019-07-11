using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRM
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISignUp" in both code and config file together.
    [ServiceContract]
    public interface ISignUp
    {
        [OperationContract]
        string create_account(Model.Users Users);
    }
}
