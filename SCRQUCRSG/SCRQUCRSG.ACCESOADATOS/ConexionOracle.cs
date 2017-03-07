using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace SCRQUCRSG.ACCESOADATOS
{
   public class ConexionOracle
    {


        string conexionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;//variable que invoca el string de conexion que se hizo el appconfig del 
                                                                                                    //proyecto ui
        OracleConnection conexion;

        public ConexionOracle()// este es el constructor de la clase aqui se inicializa la conexion cuando se crea un objeto de la clase conexion
        {
            conexion = new OracleConnection(conexionString);

        }
        //metodo conectar abrir la conexion al esquema de oracle
        public OracleConnection Conectar()
        {

            try
            {
                Desconectar();
            }
            catch (Exception)
            {

                throw;
            }
            conexion.Open();
            return conexion;

        }

        //metodo desconectar, cerrar la conexion a la base de datos
        public void Desconectar()
        {

            conexion.Close();
        }

        //metodo query, este me realiza las operaciones dml al esquema (select, insert, update, delete)
        public void OperacionDML(string query)
        {// este metodo me recibe como parametro la consulta a ejecutar a la base de datos
            Conectar();
            OracleCommand sql = new OracleCommand(query, conexion);
            OracleDataAdapter dataAdapter = new OracleDataAdapter();
            dataAdapter.InsertCommand = sql;
            dataAdapter.InsertCommand.ExecuteNonQuery();
            Desconectar();

        }
        //llenar una lista (combobox en c#)
        public DataSet LlenarCombo(String query, ComboBox comboBox, string id, string descripcion, string nombreTabla)
        //los parametros que me recibe son: la consulta select, el objeto combobox, el valor que retorna(id del registro), el valor que se va a mostrar en la lista
        //y el nombre de la tabla a realizar la consulta
        {
            Conectar();

            OracleCommand comando = new OracleCommand(query, conexion);

            comando.CommandTimeout = 0;

            OracleDataAdapter adapter = new OracleDataAdapter(comando);

            DataSet ds = new DataSet();

            adapter.Fill(ds, nombreTabla);

            comboBox.DataSource = ds.Tables[0].DefaultView;
            comboBox.ValueMember = id;
            comboBox.DisplayMember = descripcion;

            Desconectar();

            return ds;
        }



        //llenar grid
        public DataSet LlenarGrid(String query, DataGridView grid)//los parametros que reciben son la consulta y el objeto grid(datagrdview en c#)
        {
            Conectar();

            OracleCommand comando = new OracleCommand(query, conexion);

            comando.CommandTimeout = 0;

            OracleDataAdapter adapter = new OracleDataAdapter(comando);


            DataSet ds = new DataSet();

            adapter.Fill(ds);

            grid.DataSource = ds.Tables[0];

            Desconectar();

            return ds;
        }
        //public OracleDataReader Query(String query)
        //{
        //    Conectar();

        //    OracleCommand comando = new OracleCommand(query, conexion);//conexion es la variable que contiene el string de conexion al esquema
        //    OracleDataAdapter dataAdapter = new OracleDataAdapter();
        //    dataAdapter.InsertCommand = comando;

        //    return dataAdapter.InsertCommand.ExecuteReader();
        //    //return comando.ExecuteReader();

        //}

        public OracleDataReader Query(String query)
        {
            Conectar();

            OracleCommand comando = new OracleCommand(query, conexion);

            return comando.ExecuteReader();
        }

        public OracleCommand Validar(string query)
        {// este metodo me recibe como parametro la consulta a ejecutar a la base de datos
            Conectar();
            OracleCommand sql = new OracleCommand(query, conexion);
            sql.ExecuteScalar();
            return sql;

        }





    }
}
