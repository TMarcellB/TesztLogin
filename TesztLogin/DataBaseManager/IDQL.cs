using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesztLogin.Models;

namespace TesztLogin.DataBaseManager
{
    internal interface IDQL
    {
        List<Rekord> Select();
    }
}
