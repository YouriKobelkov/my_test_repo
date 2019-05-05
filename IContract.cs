using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]//Лукоморье и дуб
    interface IContract//Златая 
    {
        [OperationContract]
        string Say(string input);
    }
}
