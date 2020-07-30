using System;
using System.Collections.Generic;
using System.Text;

namespace TA.Application.ConnectionString
{
    public class ConnectionString
    {
        public const string DataBase = "TurnoApp";

        public const string Server = "DESKTOP-E6HAIL7";

        public static string AcessConnection => $"Data Source={Server};"+
                                              $"Initial Catalog ={DataBase};" +
                                              $"Integrated Security = True";

    }
}
