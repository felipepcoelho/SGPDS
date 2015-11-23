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
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexao.Local;
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                command.Connection = con;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                con.Close();
            }
        }
        
        public abstract void cadastrar(IModel model);

        public abstract void deletar(IModel model);

        public abstract IModel consultar(IModel model);
    }
}
