using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace conexion_persona
{
    static class Program
    {
       
       
        static void Main()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=persona;Integrated Security=True");
            conn.Open();
            MessageBox.Show("Conectado");
            SqlCommand comando = new SqlCommand("SELECT * FROM personas", conn);

        }
    }
      
}
