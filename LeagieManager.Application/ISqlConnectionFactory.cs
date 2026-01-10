using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LeagueManager.Application
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
        IDbConnection CreateNewConnection();
        string GetConnectionString();
    }
}
