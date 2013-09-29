using System;
using System.Data;
using Npgsql;

namespace StockMonitor.Utils
{
    public static class StockMarketTools
    {
        public static String GetStockMarket(int id)
        {
            String sqlStr = "SELECT scode FROM stocksite_stock WHERE ID=" + id + "LIMIT 1";
            var conn = new NpgsqlConnection(MdiMain.ConnStr);
            conn.Open();
            var da = new NpgsqlDataAdapter(sqlStr, conn);
            var ds = new DataSet();
            da.Fill(ds);
            var myStockDatatable = ds.Tables[0];
            var dr = myStockDatatable.Rows[0];
            var scode = Convert.ToString(dr["scode"]);
            return scode.Substring(0, 2);
        }
    }
}
