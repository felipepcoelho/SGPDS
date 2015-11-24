using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using UTILS;

namespace CONTROLLER
{
    public abstract class ConcreteController:IController 
    {
        protected void executeCommand(SqlCommand command){
            SqlConnection conn = new SqlConnection(Conexao.Local);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                command.Connection = conn;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                conn.Close();
            }
        }
        
        public abstract void cadastrar(IModel model);

        public abstract void deletar(IModel model);

        public abstract Object consultar(IModel model);
    }
}
