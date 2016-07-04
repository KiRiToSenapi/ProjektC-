using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelKundenManagementDLL;
using System.Data.OleDb;

namespace DLL
{
    public class DTO 
    {
        private OleDbConnection con = null;

        public DTO()
        {
            OleDbConnectionStringBuilder sb = new OleDbConnectionStringBuilder();
            sb.Provider = "Microsoft.ACE.OLEDB.12.0";
            sb.DataSource = "H:/FI11/A B A P/Projekt Blutbank/Blutbank.accdb";
            con = new OleDbConnection(sb.ConnectionString);
        }

        private bool OpenConnection()
        {
            bool result = true;

            if (con.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    result = false;
                }
            }

            return result;
        }

        public bool DeletePatient(Patient patient)
        {
            if (OpenConnection())
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Patient WHERE patient_id = " + patient.patient_id;
                cmd.ExecuteNonQuery();

                return true;
            }

            return false;
        }

        public List<Patient> GetAllePatienten()
        {
            List<Patient> lPatient = new List<Patient>();

            if (OpenConnection())
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Patient";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lPatient.Add(mkPatient(reader));
                }
                reader.Close();
            }

            return lPatient;
        }

        public bool InsertPatient(Patient patient)
        {
            if (OpenConnection())
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Patient VALUES (" +
                    "'" + patient.patient_id + "'," +
                    "'" + patient.Name + "'," +
                    "'" + patient.Vorname + "'," +
                    "'" + patient.Bluttgruppe + "'," +
                    "'" + patient.Erkrankung + "')";

                cmd.ExecuteNonQuery();

                return true;
            }

            return false;
        }

        public bool UpdatePatient(Patient patient)
        {
            if (OpenConnection())
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Kunden SET " +
                    "Patient_ID = " + patient.patient_id + "," +
                    "Name = " + patient.Name + "," +
                    "Vorname = " + patient.Vorname + "," +
                    "GebDatum = " + patient.Bluttgruppe + "," +
                    "Strasse = " + patient.Erkrankung + "," +
                    "WHERE Patient_ID = " + patient.patient_id;

                return true;
            }

            return false;
        }

        private Patient mkPatient(OleDbDataReader reader)
        {
            Patient patient = new Patient();
            int i = 0;

            patient.patient_id = Convert.ToInt32(reader[i++]);
            patient.Name = Convert.ToString(reader[i++]);
            patient.Vorname = Convert.ToString(reader[i++]);
            patient.Bluttgruppe = Convert.ToString(reader[i++]);
            patient.Erkrankung = Convert.ToString(reader[i++]);
            
            return patient;
        }
    }
}
