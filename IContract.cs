using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]
    interface IContract//Златая
    {
        [OperationContract]
        string Say(string input);
    }
}
