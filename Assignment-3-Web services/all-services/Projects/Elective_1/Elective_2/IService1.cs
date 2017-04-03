using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Elective_2
{

    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double bindingEnergy(Int32 A, Int32 Z);
    }
}