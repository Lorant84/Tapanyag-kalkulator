using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Tápanyag_kalkulátor
{
    class adatbazis
    {
        public static SQLiteConnection con;
        public static SQLiteCommand cmd;

        public static void Kapcsolodas()
        {
            con = new SQLiteConnection("DataSource=adatbazis.db; FailIfMissing=true");
            cmd = con.CreateCommand();

            bool adatbazis_letrehozva = true;

            if (!File.Exists("adatbazis.db"))
            {
                try
                {
                    SQLiteConnection.CreateFile("adatbazis.db");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Nem sikerült létrehozni az adatbázist! Hiba:" + e.Message);
                    adatbazis_letrehozva = false;
                }
                if (adatbazis_letrehozva)
                {
                    con.Open();
                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Kategoriak
                                        (id INTEGER PRIMARY KEY,
                                        Nev TEXT);

                                        CREATE TABLE IF NOT EXISTS Alapanyagok
                                        (id INTEGER PRIMARY KEY,
                                        Nev TEXT, 
                                        Energia REAL,
                                        Szenhidrat REAL,
                                        Zsir REAL,
                                        Feherje REAL,
                                        Megjegyzes TEXT,
                                        Kategoriak_id INTEGER);

                                        CREATE TABLE IF NOT EXISTS Kalkulator
                                        (id INTEGER PRIMARY KEY,
                                        Nev TEXT,
                                        Energia REAL,
                                        Szenhidrat REAL,
                                        Zsir REAL,
                                        Feherje REAL,
                                        Megjegyzes TEXT,
                                        Mennyiseg REAL DEFAULT 100,
                                        Alapanyagok_id INTEGER);

                                        CREATE TABLE IF NOT EXISTS Receptek
                                        (id INTEGER PRIMARY KEY,
                                        Nev TEXT,
                                        Energia REAL,
                                        Szenhidrat REAL,
                                        Zsir REAL,
                                        Feherje REAL,
                                        Alapanyagok TEXT,
                                        Recept TEXT);
                                        ";


                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
