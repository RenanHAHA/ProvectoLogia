using System;
using System.Collections.Generic;
using System.Text;

namespace ProvectoLogia.Model_s
{
    class Usuarios
    {

        public int ID { get; set; }

        public string NomedeUsuario { get; set; }

        public string SenhaDeUsuario { get; set; }

        public bool Entrar(string Nome, string Senha)
        {

            var sql = $"select count(*) from Usuarios where NomeDeUsuario = '{Nome}' and SenhaDeUsuario = '{Senha}'";
            return true;
        }


    }
}
