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
    public interface IFelhasznalo
    {
        [OperationContract] List<Felhasznalo> FelhasznaloLista();
        [OperationContract] string UjFelhasznalo(Felhasznalo ujfelhasznalo);
        [OperationContract] string ModositFelhasznalo(Felhasznalo modositFelhasznalo);
        [OperationContract] string TorolFelhasznalo(int id);
    }
    
}
