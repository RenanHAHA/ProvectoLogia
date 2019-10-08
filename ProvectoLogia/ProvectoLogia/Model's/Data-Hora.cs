using System;
using System.Collections.Generic;
using System.Text;

namespace ProvectoLogia.Model_s
{
    public class Data_Hora
    {

        public int ID { get; set; }

        public string Info { get; set; }

        public bool Inserir()
        {
            try
            {

                var SQL = $"INSERT INTO DataHora (Horarios, Opcao) VALUES ('12:30', 'Disponivel')";
                
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um Erro... \n" + ex.Message);
                
            }

        }

    }
}
