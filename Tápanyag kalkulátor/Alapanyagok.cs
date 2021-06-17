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
    public partial class Alapanyagok : Form
    {
        public Alapanyagok()
        {
            InitializeComponent();

            adatbazis.Kapcsolodas();

            Alapanyagok_megjelenito();
            Kategoriak_Megjelenito();
            KategoriakComboBox_megjelenito();
        }
        private void btn_Alapanyag_Felvetele_Click(object sender, EventArgs e)
        #region
        {
            string Nev = tb_Alapanyag_Neve.Text.Trim();
            string Megjegyzes = tb_megjegyzes.Text.Trim();

            string Energia = tb_Energia.Text.Trim().Replace(',', '.');
            string Szenhidrat = tb_Szenhidrat.Text.Trim().Replace(',', '.');
            string Zsir = tb_Zsir.Text.Trim().Replace(',', '.');
            string Feherje = tb_Feherje.Text.Trim().Replace(',', '.');

            int Kategoriak_id = Convert.ToInt32(cb_Kategoria_kivalasztasa.SelectedValue);

            if (Nev != "" && Energia != "" && Szenhidrat != "" && Zsir != "" && Feherje != "")
            {
                string hiba = "";

                if (!Szamellenorzo(Energia) || !Szamellenorzo(Szenhidrat) || !Szamellenorzo(Zsir) || !Szamellenorzo(Feherje))
                {
                    hiba = "Az Energia, Szénhidrát, Zsír, és Fehérje mezőkben csak pozitív tizedes tört, illetve egész számok adhatóak meg.\r\n\r\n Tizedes tört három tizedesjegy pontosságig, maximum kilenc számjegyig, egész szám maximum tíz számjegyig adható meg.";
                }
                else if (cb_Kategoria_kivalasztasa.Text == "") 
                {
                    hiba = "Még nincs kategória létrehozva! Az alapanyagok felvételéhez legalább egy kategóriát létre kell hozni!";
                }

                if (hiba == "")
                {
                    adatbazis.con.Open();
                    adatbazis.cmd.CommandText = @"INSERT INTO Alapanyagok (Nev, Megjegyzes, Energia, Szenhidrat, Zsir, Feherje, Kategoriak_id) VALUES
                                        (@Nev, @Megjegyzes, @Energia, @Szenhidrat, @Zsir, @Feherje, @Kategoriak_id)";

                    adatbazis.cmd.Parameters.AddWithValue("@Nev", Nev);
                    adatbazis.cmd.Parameters.AddWithValue("@Megjegyzes", Megjegyzes);
                    adatbazis.cmd.Parameters.AddWithValue("@Energia", Energia);
                    adatbazis.cmd.Parameters.AddWithValue("@Szenhidrat", Szenhidrat);
                    adatbazis.cmd.Parameters.AddWithValue("@Zsir", Zsir);
                    adatbazis.cmd.Parameters.AddWithValue("@Feherje", Feherje);
                    adatbazis.cmd.Parameters.AddWithValue("@Kategoriak_id", Kategoriak_id);

                    adatbazis.cmd.ExecuteNonQuery();
                    adatbazis.con.Close();

                    Alapanyagok_megjelenito();

                    foreach (Control c in gb_Alapanyagok_felvetele.Controls)
                    {
                        if (c.GetType() == typeof(TextBox))
                        {
                            c.ResetText();
                        }
                    }

                    tb_Alapanyag_Neve.Focus();
                }
                else
                {
                    MessageBox.Show("" + hiba, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Egy vagy több mező nincs kitöltve!\n\r"+"(a Megjegyzés mező kitöltése nem kötelező)", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
        private void Alapanyagok_megjelenito()
        #region
        {
            DataTable Alapanyagok_tabla = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Alapanyagok ORDER BY id DESC", adatbazis.con);
            da.Fill(Alapanyagok_tabla);
            dgv_Alapanyagok.DataSource = Alapanyagok_tabla;

            dgv_Alapanyagok.Columns["id"].Visible = false;
            dgv_Alapanyagok.Columns["Kategoriak_id"].Visible = false;

            dgv_Alapanyagok.Columns["Nev"].HeaderText = "Megnevezés";
            dgv_Alapanyagok.Columns["Megjegyzes"].HeaderText = "Megjegyzés";
            dgv_Alapanyagok.Columns["Szenhidrat"].HeaderText = "Szénhidrát";
            dgv_Alapanyagok.Columns["Zsir"].HeaderText = "Zsír";
            dgv_Alapanyagok.Columns["Feherje"].HeaderText = "Fehérje";

            da.Dispose();
        }
        #endregion
        private void KategoriakComboBox_megjelenito()
        #region
        {
            DataTable Kategoriak_tabla = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Kategoriak", adatbazis.con);
            da.Fill(Kategoriak_tabla);

            cb_Kategoria_kivalasztasa.DataSource = Kategoriak_tabla;
            cb_Kategoria_kivalasztasa.DisplayMember = "Nev";
            cb_Kategoria_kivalasztasa.ValueMember = "id";
            da.Dispose();
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
        private void btn_kijelotek_torlese_Click(object sender, EventArgs e)
        #region
        {
            if (dgv_Alapanyagok.SelectedRows.Count > 0)
            {
                adatbazis.con.Open();

                foreach (DataGridViewRow sor in dgv_Alapanyagok.SelectedRows)
                {
                    int id = Convert.ToInt32(sor.Cells["id"].Value);

                    adatbazis.cmd.CommandText = "DELETE FROM Alapanyagok WHERE id=@id";
                    adatbazis.cmd.Parameters.AddWithValue("@id", id);
                    adatbazis.cmd.ExecuteNonQuery();

                    dgv_Alapanyagok.Rows.Remove(sor);
                }
                adatbazis.con.Close();
            }
        }
        #endregion
        private void btn_Modosit_Click(object sender, EventArgs e)
        #region
        {
            if (dgv_Alapanyagok.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_Alapanyagok.CurrentRow.Cells["id"].Value);

                Alapanyagok_modositasa AlapanyagModosit = new Alapanyagok_modositasa(id);
                AlapanyagModosit.ShowDialog();

                Alapanyagok_megjelenito();
            }
            else if (dgv_Alapanyagok.SelectedRows.Count < 1) 
            {
                MessageBox.Show("Nincs kijelölve alapanyag!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Csak egy alapanyag lehet kijelölve a módosításhoz!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        private void btn_kategoria_letrehoz_Click(object sender, EventArgs e)
        {
            if (tb_kategoria_letrehoz.Text != "")
            {
                string Nev = tb_kategoria_letrehoz.Text.Trim();
                adatbazis.con.Open();
                adatbazis.cmd.CommandText = "INSERT INTO Kategoriak (Nev) VALUES (@Nev)";
                adatbazis.cmd.Parameters.AddWithValue("@Nev", Nev);
                adatbazis.cmd.ExecuteNonQuery();
                adatbazis.con.Close();

                tb_kategoria_letrehoz.Text = "";
                tb_kategoria_letrehoz.Focus();

                Kategoriak_Megjelenito();
                KategoriakComboBox_megjelenito();
            }
        }
        private void Kategoriak_Megjelenito()
        #region
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Kategoriak ORDER BY id DESC", adatbazis.con);
            da.Fill(dt);

            dgv_Kategoriak.DataSource = dt;
            dgv_Kategoriak.Columns["id"].Visible = false;

            da.Dispose();
        }
        #endregion

        private void btn_Torles_Click(object sender, EventArgs e)
        {   
            if (dgv_Kategoriak.SelectedRows.Count > 0)
            {
                string hiba = "Kategória nem törölhető amíg alapanyaghoz van rendelve!\r\nA kijelölt kategóriák közül a következők használatban vannak: ";
                bool torolheto = true;

                for (int i = 0; i < dgv_Kategoriak.SelectedRows.Count; i++)
                {
                    if (Torolheto_e(Convert.ToInt32(dgv_Kategoriak.SelectedRows[i].Cells["id"].Value)) == false)
                    {
                        hiba += dgv_Kategoriak.SelectedRows[i].Cells["Nev"].Value.ToString() + " ,";
                        torolheto = false;
                    }
                }

                if (torolheto)
                {
                    adatbazis.con.Open();
                    foreach (DataGridViewRow sor in dgv_Kategoriak.SelectedRows)
                    {
                        int id = Convert.ToInt32(sor.Cells["id"].Value);

                        adatbazis.cmd.CommandText = "DELETE FROM Kategoriak WHERE id=@id";
                        adatbazis.cmd.Parameters.AddWithValue("@id", id);
                        adatbazis.cmd.ExecuteNonQuery();

                        dgv_Kategoriak.Rows.Remove(sor);
                    }
                    adatbazis.con.Close();

                    KategoriakComboBox_megjelenito();
                }
                else
                {
                    MessageBox.Show(hiba, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private bool Torolheto_e(int id)
        #region
        {
            bool torolheto = true;

            adatbazis.con.Open();
            adatbazis.cmd.CommandText = "SELECT Kategoriak_id FROM Alapanyagok";
            SQLiteDataReader iro = adatbazis.cmd.ExecuteReader();

            List<int> kategoria_id = new List<int>();
            if (iro.HasRows)
            {
                while (iro.Read())
                {
                    kategoria_id.Add(Convert.ToInt32(iro["Kategoriak_id"]));
                }
            }
            iro.Close();
            adatbazis.con.Close();

            for (int i = 0; i < kategoria_id.Count; i++)
            {
                if (kategoria_id[i] == id)
                {
                    torolheto = false;
                }
            }
            return torolheto;
        }
        #endregion
    }
}