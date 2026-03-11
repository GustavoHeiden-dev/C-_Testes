using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PrimeiroProjeto.Dicionario.Data
{
    public class Conexao
    {
        private string connectioString =
        "server=localhost;database=mercandoDB;user=root;password=heiden123";

        public MySqlConnection Conectar()
        {
            return new MySqlConnection(connectioString);
        }
        
    }
}