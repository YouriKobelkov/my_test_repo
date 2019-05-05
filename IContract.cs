using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]//Лукоморье и дуб
    interface IContract//Златая цепь
    {
        [OperationContract]
        string Say(string input);
    }
}
