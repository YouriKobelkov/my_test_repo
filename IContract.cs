using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]
    interface IContract//Златая цепь
    {
        [OperationContract]
        string Say(string input);
    }
}
