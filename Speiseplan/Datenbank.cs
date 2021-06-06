using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Speiseplan
{
    class Datenbank
    {
        private OleDbConnection verbindung;
        private OleDbCommand cmd;
        private string cn;
        private static int startNr = 11;

        public Datenbank()
        {
            cn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Speiseplan.accdb";
            verbindung = new OleDbConnection(cn);
            
        }

        public OleDbDataReader Einlesen(string sql)
        {
            try
            {
                verbindung.Close();
                verbindung.Open();
                cmd = new OleDbCommand(sql, verbindung);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen: " + ex.Message);
            }
        }

        public void Ausfuehren(string sql)
        {
            try
            {
                verbindung.Close();
                verbindung.Open();
                cmd = new OleDbCommand(sql, verbindung);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Ausführen: " + ex.Message);
            }
            finally
            {
                verbindung.Close();
            }

            
        }
        public static int getStartNr()
        {
            return startNr;
        }
    }
}
