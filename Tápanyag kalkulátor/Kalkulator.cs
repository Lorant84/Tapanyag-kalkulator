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
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();

            adatbazis.Kapcsolodas();

            Alapanyag_lista_megjelenito();
            Kivalasztott_etelek_megjelenito();
        }
        private void Alapanyag_lista_megjelenito()
        {
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Kategoriak; SELECT * FROM Alapanyagok; SELECT * FROM Kalkulator", adatbazis.con);
            da.Fill(ds);

            cb_Kategoria.DataSource = ds.Tables[0];
            cb_Kategoria.DisplayMember = "Nev";
            cb_Kategoria.ValueMember = "id";

            dgv_Alapanyag_lista.DataSource = ds.Tables[1];
            dgv_Alapanyag_lista.Columns["id"].Visible = false;
            dgv_Alapanyag_lista.Columns["Megjegyzes"].Visible = false;
            dgv_Alapanyag_lista.Columns["Energia"].Visible = false;
            dgv_Alapanyag_lista.Columns["Szenhidrat"].Visible = false;
            dgv_Alapanyag_lista.Columns["Zsir"].Visible = false;
            dgv_Alapanyag_lista.Columns["Feherje"].Visible = false;
            dgv_Alapanyag_lista.Columns["Kategoriak_id"].Visible = false;

            da.Dispose();
        }
        private void Kivalasztott_etelek_megjelenito()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Kalkulator ORDER BY id DESC", adatbazis.con);
            da.Fill(dt);

            dgv_Kivalasztott_etelek.DataSource = dt;
            dgv_Kivalasztott_etelek.Columns["id"].Visible = false;
            dgv_Kivalasztott_etelek.Columns["Megjegyzes"].Visible = false;
            dgv_Kivalasztott_etelek.Columns["Nev"].HeaderText = "Megnevezés";
            dgv_Kivalasztott_etelek.Columns["Szenhidrat"].HeaderText = "Szénhidrát";
            dgv_Kivalasztott_etelek.Columns["Zsir"].HeaderText = "Zsír";
            dgv_Kivalasztott_etelek.Columns["Feherje"].HeaderText = "Fehérje";
            dgv_Kivalasztott_etelek.Columns["Mennyiseg"].HeaderText = "Mennyiség (gramm)";
            dgv_Kivalasztott_etelek.Columns["Alapanyagok_id"].Visible = false;

            OsszBevitelSzamitas();

            da.Dispose();
        }
        private void dgv_Alapanyag_lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Nev = dgv_Alapanyag_lista.CurrentRow.Cells["Nev"].Value.ToString();
            string Megjegyzes = dgv_Alapanyag_lista.CurrentRow.Cells["Megjegyzes"].Value.ToString();
            double Energia = Convert.ToDouble(dgv_Alapanyag_lista.CurrentRow.Cells["Energia"].Value);
            double Szenhidrat = Convert.ToDouble(dgv_Alapanyag_lista.CurrentRow.Cells["Szenhidrat"].Value);
            double Zsir = Convert.ToDouble(dgv_Alapanyag_lista.CurrentRow.Cells["Zsir"].Value);
            double Feherje = Convert.ToDouble(dgv_Alapanyag_lista.CurrentRow.Cells["Feherje"].Value);
            int Alapanyagok_id = Convert.ToInt32(dgv_Alapanyag_lista.CurrentRow.Cells["id"].Value);

            bool felveve = false;
            if (dgv_Kivalasztott_etelek.Rows.Count > 0)
            {
                for (int i = 0; i < dgv_Kivalasztott_etelek.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgv_Kivalasztott_etelek.Rows[i].Cells["Alapanyagok_id"].Value) == Convert.ToInt32(dgv_Alapanyag_lista.CurrentRow.Cells["id"].Value))
                    {
                        felveve = true;
                    }
                }
            }

            if (felveve == false)
            {
                adatbazis.con.Open();
                adatbazis.cmd.CommandText = "INSERT INTO Kalkulator (Nev, Megjegyzes, Energia, Szenhidrat, Zsir, Feherje, Alapanyagok_id) VALUES (@Nev, @Megjegyzes, @Energia, @Szenhidrat, @Zsir, @Feherje, @Alapanyagok_id)";

                adatbazis.cmd.Parameters.AddWithValue("@Nev", Nev);
                adatbazis.cmd.Parameters.AddWithValue("@Megjegyzes", Megjegyzes);
                adatbazis.cmd.Parameters.AddWithValue("@Energia", Energia);
                adatbazis.cmd.Parameters.AddWithValue("@Szenhidrat", Szenhidrat);
                adatbazis.cmd.Parameters.AddWithValue("@Zsir", Zsir);
                adatbazis.cmd.Parameters.AddWithValue("@Feherje", Feherje);
                adatbazis.cmd.Parameters.AddWithValue("@Alapanyagok_id", Alapanyagok_id);

                adatbazis.cmd.ExecuteNonQuery();
                adatbazis.con.Close();

                Kivalasztott_etelek_megjelenito();
            }
        }
        private void OsszBevitelSzamitas()
        #region
        {
            double osszKaloria;
            double osszSzenhidrat;
            double osszZsir;
            double osszFeherje;

            if (dgv_Kivalasztott_etelek.Rows.Count > 0)
            {
                adatbazis.con.Open();

                adatbazis.cmd.CommandText = "SELECT SUM((Energia)*(Mennyiseg/100)) FROM Kalkulator";
                osszKaloria = Convert.ToDouble(adatbazis.cmd.ExecuteScalar());
                adatbazis.cmd.CommandText = "SELECT SUM((Szenhidrat)*(Mennyiseg/100)) FROM Kalkulator";
                osszSzenhidrat = Convert.ToDouble(adatbazis.cmd.ExecuteScalar());
                adatbazis.cmd.CommandText = "SELECT SUM((Zsir)*(Mennyiseg/100)) FROM Kalkulator";
                osszZsir = Convert.ToDouble(adatbazis.cmd.ExecuteScalar());
                adatbazis.cmd.CommandText = "SELECT SUM((Feherje)*(Mennyiseg/100)) FROM Kalkulator";
                osszFeherje = Convert.ToDouble(adatbazis.cmd.ExecuteScalar());

                adatbazis.con.Close();

                lbl_osszkaloria.Text = "Összkalória mennyisége: " + osszKaloria + " kcal";
                lbl_osszszenhidrat.Text = "Össz-szénhidrát mennyisége: " + osszSzenhidrat + " gramm";
                lbl_osszzsir.Text = "Össz-zsír mennyisége: " + osszZsir + " gramm";
                lbl_osszfeherje.Text = "Össz-fehérje mennyisége: " + osszFeherje + " gramm";
            }
            else
            {
                lbl_osszkaloria.Text = "Összkalória mennyisége:";
                lbl_osszszenhidrat.Text = "Össz-szénhidrát mennyisége:";
                lbl_osszzsir.Text = "Össz-zsír mennyisége:";
                lbl_osszfeherje.Text = "Össz-fehérje mennyisége:";
            }
        }
        #endregion
        private void btn_kijelotek_torlese_Click(object sender, EventArgs e)
        #region
        {
            if (dgv_Kivalasztott_etelek.SelectedRows.Count > 0)
            {
                adatbazis.con.Open();

                foreach (DataGridViewRow sor in dgv_Kivalasztott_etelek.SelectedRows)
                {
                    int id = Convert.ToInt32(sor.Cells["id"].Value);

                    adatbazis.cmd.CommandText = "DELETE FROM Kalkulator WHERE id=@id";
                    adatbazis.cmd.Parameters.AddWithValue("@id", id);
                    adatbazis.cmd.ExecuteNonQuery();

                    dgv_Kivalasztott_etelek.Rows.Remove(sor);
                }
                adatbazis.con.Close();

                OsszBevitelSzamitas();
            }
        }
        #endregion
        private void btn_osszes_torlese_Click(object sender, EventArgs e)
        {
            adatbazis.con.Open();
            adatbazis.cmd.CommandText = "DELETE FROM Kalkulator";
            adatbazis.cmd.ExecuteNonQuery();
            adatbazis.con.Close();

            Kivalasztott_etelek_megjelenito();
        }
        private void cb_Kategoria_TextChanged(object sender, EventArgs e)
        #region
        {
            for (int i = 0; i < dgv_Alapanyag_lista.Rows.Count; i++)
            {
                int alapanyag_kategoria_id = Convert.ToInt32(dgv_Alapanyag_lista.Rows[i].Cells["Kategoriak_id"].Value);
                int kategoria_id = Convert.ToInt32(cb_Kategoria.SelectedValue);

                if (alapanyag_kategoria_id != kategoria_id)
                {
                    dgv_Alapanyag_lista.CurrentCell = null;
                    dgv_Alapanyag_lista.Rows[i].Visible = false;
                }
                else
                {
                    dgv_Alapanyag_lista.Rows[i].Visible = true;
                }
            }
        }
        #endregion
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
        private void btn_MennyisegModosito_Click(object sender, EventArgs e)
        #region
        {
            if (tb_mennyiseg.Text != "")
            {
                string hiba = "";

                if (dgv_Kivalasztott_etelek.SelectedRows.Count < 1)
                {
                    hiba = "Nincs kiválasztva élelmiszer!";
                }
                else if (dgv_Kivalasztott_etelek.SelectedRows.Count > 1)
                {
                    hiba = "Egyszerre csak egy élelmiszer lehet kiválasztva!";
                }
                else if (!Szamellenorzo(tb_mennyiseg.Text.Trim().Replace(',', '.')))
                {
                    hiba = "Csak pozitív tizedes tört, illetve egész számok adhatóak meg.\r\n\r\n Tizedes tört három tizedesjegy pontosságig, maximum kilenc számjegyig, egész szám maximum tíz számjegyig adható meg.";
                }



                if (dgv_Kivalasztott_etelek.SelectedRows.Count == 1 && hiba == "")
                {
                    int id = Convert.ToInt32(dgv_Kivalasztott_etelek.CurrentRow.Cells["id"].Value);
                    string Mennyiseg = tb_mennyiseg.Text.Trim().Replace(',', '.');
                    adatbazis.con.Open();
                    adatbazis.cmd.CommandText = "UPDATE Kalkulator SET Mennyiseg=@Mennyiseg WHERE id=@id";
                    adatbazis.cmd.Parameters.AddWithValue("@Mennyiseg", Mennyiseg);
                    adatbazis.cmd.Parameters.AddWithValue("@id", id);
                    adatbazis.cmd.ExecuteNonQuery();
                    adatbazis.con.Close();

                    Kivalasztott_etelek_megjelenito();
                    tb_mennyiseg.Text = "";
                    tb_mennyiseg.Focus();
                }
                else
                {
                    MessageBox.Show("" + hiba, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_mennyiseg.Text = "";
                    tb_mennyiseg.Focus();
                }
            }
        }
        #endregion
        private void btn_TeljesListaBetolt_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow sor in dgv_Alapanyag_lista.Rows)
            {
                sor.Visible = true;
            }
        }
        private void dgv_Kivalasztott_etelek_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgv_Kivalasztott_etelek.SelectedRows.Count > 1 || dgv_Kivalasztott_etelek.SelectedRows.Count < 1) 
            {
                rtb_megjegyzes.Clear();
            }
            else if (dgv_Kivalasztott_etelek.SelectedRows.Count == 1) 
            {
                rtb_megjegyzes.Text = dgv_Kivalasztott_etelek.CurrentRow.Cells["Megjegyzes"].Value.ToString();
            }
        }

        private void btn_recept_mentese_Click(object sender, EventArgs e)
        {
            if (dgv_Kivalasztott_etelek.Rows.Count > 0 && tb_receptNev.Text != "")
            {
                adatbazis.con.Open();

                string Nev = tb_receptNev.Text.Trim();
                double Energia;
                double Szenhidrat;
                double Zsir;
                double Feherje;
                string Recept = rtb_recept.Text.Trim();

                string Alapanyagok = "";


                adatbazis.cmd.CommandText = "SELECT SUM((Energia)*(Mennyiseg/100)) FROM Kalkulator";
                Energia = Convert.ToDouble(adatbazis.cmd.ExecuteScalar());
                adatbazis.cmd.CommandText = "SELECT SUM((Szenhidrat)*(Mennyiseg/100)) FROM Kalkulator";
                Szenhidrat = Convert.ToDouble(adatbazis.cmd.ExecuteScalar());
                adatbazis.cmd.CommandText = "SELECT SUM((Zsir)*(Mennyiseg/100)) FROM Kalkulator";
                Zsir = Convert.ToDouble(adatbazis.cmd.ExecuteScalar());
                adatbazis.cmd.CommandText = "SELECT SUM((Feherje)*(Mennyiseg/100)) FROM Kalkulator";
                Feherje = Convert.ToDouble(adatbazis.cmd.ExecuteScalar());


                foreach (DataGridViewRow sor in dgv_Kivalasztott_etelek.Rows)
                {
                    int id = Convert.ToInt32(sor.Cells["id"].Value);

                    adatbazis.cmd.CommandText = "SELECT Mennyiseg FROM Kalkulator WHERE id=@id";
                    adatbazis.cmd.Parameters.AddWithValue("@id", id);
                    Alapanyagok += adatbazis.cmd.ExecuteScalar() + " gramm ";

                    adatbazis.cmd.CommandText = "SELECT Nev FROM Kalkulator WHERE id=@id";
                    Alapanyagok += adatbazis.cmd.ExecuteScalar() + "\n";

                }
                adatbazis.cmd.CommandText = "INSERT INTO Receptek (Alapanyagok, Nev, Energia, Szenhidrat, Zsir, Feherje, Recept) VALUES (@Alapanyagok, @Nev, @Energia, @Szenhidrat, @Zsir, @Feherje, @Recept)";
                adatbazis.cmd.Parameters.AddWithValue("@Alapanyagok", Alapanyagok);
                adatbazis.cmd.Parameters.AddWithValue("@Nev", Nev);
                adatbazis.cmd.Parameters.AddWithValue("@Energia", Energia);
                adatbazis.cmd.Parameters.AddWithValue("@Szenhidrat", Szenhidrat);
                adatbazis.cmd.Parameters.AddWithValue("@Zsir", Zsir);
                adatbazis.cmd.Parameters.AddWithValue("@Feherje", Feherje);
                adatbazis.cmd.Parameters.AddWithValue("@Recept", Recept);
                adatbazis.cmd.ExecuteNonQuery();

                adatbazis.con.Close();

                tb_receptNev.Text = "";
                rtb_recept.Text = "Írj egy receptet!";
            }
            else if (dgv_Kivalasztott_etelek.Rows.Count > 0 && tb_receptNev.Text == "")
            {
                MessageBox.Show("Az elmenteni kívánt receptnek nem lett név megadva!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dgv_Kivalasztott_etelek.Rows.Count < 1 && tb_receptNev.Text != "")
            {
                MessageBox.Show("Az összetevők ablak üres!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rtb_recept_Click(object sender, EventArgs e)
        {
            if (rtb_recept.Text == "Írj egy receptet!")
            {
                rtb_recept.Text = "";
            }
        }
    }
}