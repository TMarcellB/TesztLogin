using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TesztLogin.Models;

namespace TesztLogin.Interfaces
{
    [ServiceContract]
    public interface IJogosultsagok
    {
        [OperationContract] List<Jogosultsagok> JogosultsagLista();
        [OperationContract] string UjJogosultsag(Jogosultsagok ujjogosultsag);
        [OperationContract] string ModositJogosultsag(Jogosultsagok modositJogosoultsag);
        [OperationContract] string TorolJogosultsag(int id);
    }
}
