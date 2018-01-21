using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;


namespace conexion_persona
{
     class Conexion

    {


        static void DbCommand(DbConnection connection)
{
    string queryString =
        "SELECT Nombre, Apellidos FROM personas";

    if (connection != null)
    {
        using (connection)
        {
            try
            {
              
                connection.Open();

                
                DbCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                command.CommandType = CommandType.Text;

                connection.Open();
                DbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Nombre = reader.GetString(1);
                    string Apellidos = reader.GetString(2);

                    // Console.WriteLine("id: " + id + " - nombre: " + Nombre + " - apellido: " + Apellidos);
                    Console.WriteLine("id: {0} - Nombre: {1} - Apellidos: {2}", Id, Nombre, Apellidos);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception.Message: {0}", ex.Message);
            }
        }
    }
    else
    {
        Console.WriteLine("conexion nula");
    }
            }
               
    }
 }