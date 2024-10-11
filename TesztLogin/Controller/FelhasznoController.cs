using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesztLogin.DataBaseManager;
using TesztLogin.Models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TesztLogin.Controller
{
    public class FelhasznoController : BaseDataBaseManager, ISql
    {
        public List<Rekord> Select()
        {
            List<Rekord> list = new List<Rekord>();
            MySqlCommand cmd = new MySqlCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT * FROM `felhasznalok`" 
            };
            try
            {
                MySqlConnection conn = BaseDataBaseManager.connection;
                conn.Open();
                cmd.Connection = conn;
                //SQL Futtatás elokeszites!!!!!!!!!!!!!!!!!!!!!!!!!!!!,true
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Felhasznalo felhasznalo = new Felhasznalo()
                    {
                        Id = reader.GetInt32("Id"),
                        LoginNev=reader.GetString("LoginNev"),
                        HASH=reader.GetString("HASH"),
                        SALT=reader.GetString("SALT"),
                        Nev=reader.GetString("Nev"),
                        Jog=reader.GetInt32("Jog"),
                        Aktiv=reader.GetBoolean("Aktiv"),
                        Email=reader.GetString("Email"),
                        ProfilKep=reader.GetString("ProfilKep")
                        
                    };
                    list.Add(felhasznalo);
                    

                }
            }
            
            catch (Exception ex)
            {
                Felhasznalo felhasznalo = new Felhasznalo()
                {
                    Id = -1,
                    HASH = ex.Message
                };
                list.Add(felhasznalo);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }
        public string Delete(int id)
        {
           return "";
        }

        public string Insert(Rekord rekord)
        {
           return "";
        }
        public string Update(Rekord rekord)
        {
           return "";
        }
    }
}