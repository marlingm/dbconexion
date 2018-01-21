using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace conexionpostgrsql
{
    class Program
    {
        static void Main(string[] args)
        {
            NpgsqlConnection conn = new NpgsqlConnection(@" Server=baasu.db.elephantsql.com;Database=jrdkibpv;User Id=jrdkibpv;Password=65hxdEfRt-7GeWf3CnWw_5iI7Yx_wdRB;Port=5432");
            conn.Open();

           NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM \"public\".\"spatial_ref_sys\" LIMIT 100", conn);
           NpgsqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);

                Console.WriteLine("id: {0} - name: {1}", id, name);
            }

         
            conn.Close();
            Console.ReadKey();
        }
        }
    }

