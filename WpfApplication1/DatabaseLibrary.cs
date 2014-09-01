using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace RemindKitty.DataAccess
{
    public class DatabaseLibrary
    {
        /** Getting Paramters **/
        private static string GetConnectionString()
        {

            string constr = ConnectionParam.GetConnectionString();
            return constr;
        }
        /** Starting Process to Communicate with Database Server **/
        public static OleDbConnection GetConnection()
        {
            OleDbConnection sqlCon = new OleDbConnection(GetConnectionString());
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                {
                    sqlCon.Close();
                }
                if (sqlCon.State != System.Data.ConnectionState.Open)
                {
                    sqlCon.Open();
                }
                return sqlCon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } /** End of GetConnection() **/
        /** For SELECT QUERY ONLY  **/
        public static DataTable GetRecordset(string pSqlQuery, OleDbParameter[] pParam)
        {
            DataTable dtbl = null;
            OleDbConnection sqlCon = DatabaseLibrary.GetConnection();
            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd = sqlCon.CreateCommand();

            try
            {
                sqlCmd.CommandText = pSqlQuery;
                sqlCmd.CommandType = CommandType.Text;
                /** Adding Parameters **/
                if (pParam != null)
                    sqlCmd.Parameters.AddRange(pParam);
                sqlCmd.CommandTimeout = 0;
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlCmd);
                dtbl = new DataTable();
                adapter.Fill(dtbl);
                sqlCon.Close();
                sqlCon.Dispose();
                sqlCmd.Dispose();
                return dtbl;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } /** End of GetRecordSet() **/
        /** FOR INSERT/DELETE/UPDATE **/
        public static void ExecSQLStatement(string pSQLString, OleDbParameter[] pParam)
        {

            OleDbConnection sqlCon = DatabaseLibrary.GetConnection();
            OleDbCommand sqlCmd = new OleDbCommand();
            try
            {
                sqlCmd.CommandText = pSQLString;
                sqlCmd.CommandType = CommandType.Text;
                /** Adding Parameters **/
                sqlCmd.Parameters.Clear();
                if (pParam != null)
                    sqlCmd.Parameters.AddRange(pParam);
                sqlCmd.CommandTimeout = 0;
                sqlCmd.ExecuteNonQuery(); /** Executing Procedures **/
                //con.Close();
                sqlCmd.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } /** End of ExecProcedure() **/
    }


}
