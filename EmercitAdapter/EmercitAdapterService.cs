using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Configuration;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace EmercitAdapter
{
  [WebService(Namespace = "http://emercitadapter.pins.iskratel.si/")]
  [WebServiceBinding(Name = "EmercitAdapterServiceSoapBinding", Namespace = "http://emercitadapter.pins.iskratel.si/")]
  public class EmercitAdapterService : IEmercitAdapterServiceSoapBinding
  {
    string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    string dbLogin = ConfigurationManager.AppSettings["Login"];
    string dbPass = ConfigurationManager.AppSettings["Pass"];
    string sqlQuery = ConfigurationManager.AppSettings["SQLQuery"];

    NpgsqlConnection conn;

    public EmercitAdapterService()
    {
      ConnectToDatabase();
    }

    [WebMethod]                                   
    public bool newIER(ier ier)
    {
      try
      {
        string jss = JsonConvert.SerializeObject(ier);

        if (conn.State != System.Data.ConnectionState.Open)
        {
          ConnectToDatabase();
        }
        using (var cmd = new NpgsqlCommand(sqlQuery, conn))
        {
          cmd.Parameters.Add(new NpgsqlParameter("d", NpgsqlDbType.Jsonb) { Value = jss });
          cmd.ExecuteNonQuery();
        }

        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    private void ConnectToDatabase()
    {
      if (conn == null)
      {
        conn = new NpgsqlConnection(connectionString);
        conn.TypeMapper.UseJsonNet();
      }
      conn.Open();
    }
  }
}