using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TesztLogin.Models;
using TesztLogin.Controller;

namespace TesztLogin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public List<Felhasznalo> FelhasznaloLista()
        
        {
            List<Rekord> rlist = new FelhasznoController().Select();
            List<Felhasznalo>flist =new List<Felhasznalo>();
            foreach (var item in rlist)
            {
                flist.Add(item as Felhasznalo);
            }
            return flist;
        }

        public List<Jogosultsagok> JogosultsagLista()
        {
            return new List<Jogosultsagok>();
        }

        public string ModositFelhasznalo(Felhasznalo modositFelhasznalo)
        {
            return "";
        }

        public string ModositJogosultsag(Jogosultsagok modositJogosoultsag)
        {
            return "";
        }

        public string TorolFelhasznalo(int id)
        {
            return "";
        }

        public string TorolJogosultsag(int id)
        {
            return "";
        }

        public string UjFelhasznalo(Felhasznalo ujfelhasznalo)
        {
            return "";
        }

        public string UjJogosultsag(Jogosultsagok ujjogosultsag)
        {
            return "";
        }
    }
}
