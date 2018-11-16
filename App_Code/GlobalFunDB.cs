using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Summary description for GlobalFunDB
/// </summary>
public class GlobalFunDB
{
    
    public static void LoadParent()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["MainConn"].ConnectionString);
        con.Open();
        SqlCommand Cmd = new SqlCommand();
        string Sql = "Select * From T_Parent";
        Cmd.Connection = con;
        Cmd.CommandText = Sql;
        SqlDataReader rd = Cmd.ExecuteReader();
        List<Parent> ArrParent = new List<Parent>();

        while (rd.Read())
        {
            ArrParent.Add(new Parent((int)rd["Pid"], (string)rd["PfName"], (string)rd["Pemail"], (string)rd["Ppass"], (int)rd["PidChild"]));
        }
        con.Close();
        HttpContext.Current.Application["ArrParent"] = ArrParent;
    }
    public static void LoadNani()
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["MainConn"].ConnectionString);
        con.Open();
        SqlCommand Cmd = new SqlCommand();
        string Sql = "Select * From T_Nani";
        Cmd.Connection = con;
        Cmd.CommandText = Sql;
        SqlDataReader rd = Cmd.ExecuteReader();
        List<Nani> ArrNani = new List<Nani>();

        while (rd.Read())
        {
            ArrNani.Add(new Nani((int)rd["Nid"], (string)rd["NfName"], (string)rd["Naddress"], (string)rd["Ncity"], (string)rd["Nphon"], (string)rd["Nmail"], (string)rd["Npass"],(int)rd["NidChild"]));
        }
        con.Close();
        HttpContext.Current.Application["ArrNani"] = ArrNani;
    }

}