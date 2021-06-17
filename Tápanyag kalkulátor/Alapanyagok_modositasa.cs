using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace Tápanyag_kalkulátor
{
    public partial class Alapanyagok_modositasa : Form
    {
        int id;

        public Alapanyagok_modositasa(int id)
        {
            InitializeComponent();

            this.id = id;

            KategoriakComboBox_megjelenito();

            adatbazis.con.Open();

            adatbazis.cmd.CommandText = "SELECT * FROM Alapanyagok WHERE id=@id";
            adatbazis.cmd.Parameters.AddWithValue("@id", id);

            SQLiteDataReader iro = adatbazis.cmd.ExecuteReader();

            if (iro.HasRows)
            {
                iro.Read();

                tb_Alapanyag_Neve.Text = iro["Nev"].ToString();
                tb_Energia.Text = iro["Energia"].ToString();
                tb_Szenhidrat.Text = iro["Szenhidrat"].ToString();
                tb_Zsir.Text = iro["Zsir"].ToString();
                tb_Feherje.Text = iro["Feherje"].ToString();
                tb_megjegyzes.Text = iro["Megjegyzes"].ToString();

                cb_Kategoria_kivalasztasa.SelectedValue = Convert.ToInt32(iro["Kategoriak_id"]);
            }
            iro.Close();
            adatbazis.con.Close();
        }
        private DataTable KategoriaMegjelenito(string sql)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, adatbazis.con);
            da.Fill(dt);
            da.Dispose();

            return dt;
        }
        private void KategoriakComboBox_megjelenito()
        {
            DataTable Kategoriak_tabla = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Kategoriak", adatbazis.con);
            da.Fill(Kategoriak_tabla);

            cb_Kategoria_kivalasztasa.DataSource = Kategoriak_tabla;
            cb_Kategoria_kivalasztasa.DisplayMember = "Nev";
            cb_Kategoria_kivalasztasa.ValueMember = "id";

            da.Dispose();
        }
        private bool Szamellenorzo(string szam)//0, 0-0.999, 1-9999999999, 1-999999.999
        #region
        {
            bool megfelel = true;
            if (Regex.IsMatch(szam, @"^[1-9]\d{0,5}(.\d){0,1}\d{0,2}$") || Regex.IsMatch(szam, @"^0.\d{1,3}$") || (szam == "0"))
            {
                return megfelel;
            }
            else
            {
                megfelel = false;
                return megfelel;
            }
        }
        #endregion
        private void btn_Modosit_Click(object sender, EventArgs e)
        #region
        {
            string hiba = "";

            string Nev = tb_Alapanyag_Neve.Text.Trim();
            string Megjegyzes = tb_megjegyzes.Text.Trim();
            string Energia = tb_Energia.Text.Trim().Replace(',', '.');
            string Szenhidrat = tb_Szenhidrat.Text.Trim().Replace(',', '.');
            string Zsir = tb_Zsir.Text.Trim().Replace(',', '.');
            string Feherje = tb_Feherje.Text.Trim().Replace(',', '.');
            int Kategoriak_id = Convert.ToInt32(cb_Kategoria_kivalasztasa.SelectedValue);

            if (Nev != "" && Energia != "" && Szenhidrat != "" && Zsir != "" && Feherje != "")
            {

                if (!Szamellenorzo(Energia) || !Szamellenorzo(Szenhidrat) || !Szamellenorzo(Zsir) || !Szamellenorzo(Feherje))
                {
                    hiba = "Az Energia, Szénhidrát, Zsír, és Fehérje mezőkben csak pozitív tizedes tört, illetve egész számok adhatóak meg.\r\n\r\n Tizedes tört három tizedesjegy pontosságig, maximum kilenc számjegyig, egész szám maximum tíz számjegyig adható meg.";
                }

                if (hiba == "")
                {
                    adatbazis.con.Open();
                    adatbazis.cmd.CommandText = "UPDATE Alapanyagok SET Nev=@Nev, Megjegyzes=@Megjegyzes, Energia=@Energia, Szenhidrat=@Szenhidrat, Zsir=@Zsir, Feherje=@Feherje, Kategoriak_id=@Kategoriak_id WHERE @id=id";

                    adatbazis.cmd.Parameters.AddWithValue("@id", id);
                    adatbazis.cmd.Parameters.AddWithValue("@Nev", Nev);
                    adatbazis.cmd.Parameters.AddWithValue("@Megjegyzes", Megjegyzes);
                    adatbazis.cmd.Parameters.AddWithValue("@Energia", Energia);
                    adatbazis.cmd.Parameters.AddWithValue("@Szenhidrat", Szenhidrat);
                    adatbazis.cmd.Parameters.AddWithValue("@Zsir", Zsir);
                    adatbazis.cmd.Parameters.AddWithValue("@Feherje", Feherje);
                    adatbazis.cmd.Parameters.AddWithValue("@Kategoriak_id", Kategoriak_id);
                    adatbazis.cmd.ExecuteNonQuery();
                    adatbazis.con.Close();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("" + hiba, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Egy vagy több mező nincs kitöltve!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        private void btn_Bezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}