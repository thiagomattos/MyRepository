using System;
using System.Collections.Generic;
using System.Text;

namespace CarWash3.Serviços
{
    interface IDatabaseConnection
    {
        string GetCaminhoDB(string dbName);
    }
}
