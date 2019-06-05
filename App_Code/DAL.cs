using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    private string server = "localhost";
    private string database = "estoque";
    private string user = "root";
    private string password = "";
    private string connectonString = "Server={0}; DataBase={1};Uid={2};Pwd={3};";
    private  MySqlConnection connection;

    public DAL()
    {
        connectonString = String.Format(connectonString, server, database, user, password);
        connection = new MySqlConnection();
        connection.Open();

    }

    public DataTable RetDataTable( string sql) {

        DataTable dataTable = new DataTable();
        MySqlCommand commando = new MySqlCommand(sql, connection);
        MySqlDataAdapter da = new MySqlDataAdapter(commando);
        da.Fill(dataTable);
        return dataTable;
    }

    public void ExecutarComandoSql(string sql){

        MySqlCommand comando = new MySqlCommand(sql, connection);
        comando.ExecuteNonQuery();   

    } 
}

