using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]//У Лукоморья дуб зеленый
    interface IContract
    {
        [OperationContract]
        string Say(string input);
    }
}
