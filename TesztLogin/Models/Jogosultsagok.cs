﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TesztLogin.Models
{
    public class Jogosultsagok:Rekord
    {
        [DataMember]
        public int Szint { get; set; }

        [DataMember]
        public string Nev { get; set; }

        [DataMember]
        public string Leiras { get; set; }
    }
}