using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudicMarinAdresar.Store
{
    public class StoreAdresa
    {
        public  List<Osoba> GetOsoba()
        {
             List<Osoba> lista= new List<Osoba>();
            var connectionManager = new SqlConnectionFactory();
            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    using (var command = new MySqlCommand("SELECT*FROM adresar,osoba,telefon WHERE adresar.KontaktID=osoba.Id AND " +
                        "telefon.KontaktID=osoba.Id", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Osoba osoba = new Osoba();
                                osoba.Id = reader.GetInt32("Id");
                                osoba.Ime = reader.GetString("Ime");
                                osoba.Prezime = reader.GetString("Prezime");
                                osoba.Broj = reader.GetString("Broj");
                                osoba.Ulica = reader.GetString("Ulica");
                                osoba.Grad = reader.GetString("Grad");
                                osoba.PostanskiBroj = reader.GetString("PostanskiBroj");
                                osoba.Drzava = reader.GetString("Drzava");

                                lista.Add(osoba);

                            }
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }

            }
            return lista;
        }
        public void AddOsoba(Osoba osoba)
        {
            var connectionManager = new SqlConnectionFactory();
            using (var connection = connectionManager.GetNewConnection())
            {
                if (connection != null)
                {
                    var command = new MySqlCommand("INSERT INTO  osoba(Ime,Prezime) VALUES('" +
                                "')   INSERT INTO adresar(Ulica,Grad,Drzava,PostanskiBroj) VALUES('') INSERT INTO telefon(Broj) VALUES('') ", connection) ;
                    
                    command.Parameters.AddWithValue("@Ime",osoba.Ime);
                    command.Parameters.AddWithValue("@Prezime",osoba.Prezime);
                    command.Parameters.AddWithValue("@Ulica", osoba.Ulica);
                    command.Parameters.AddWithValue("@Grada",osoba.Grad);
                    command.Parameters.AddWithValue("@Drzava",osoba.Drzava);
                    command.Parameters.AddWithValue("@PostanskiBroj", osoba.PostanskiBroj);
                    command.Parameters.AddWithValue("@Broj", osoba.Broj);
                    
                    connectionManager.CloseConnection(connection);
                }

            }
        }
    }
}
