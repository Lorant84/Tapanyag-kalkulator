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

namespace Tápanyag_kalkulátor
{
    public partial class Receptek : Form
    {
        public Receptek()
        {
            InitializeComponent();

            Receptek_megjelenito();
        }
        private void Receptek_megjelenito()
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Receptek", adatbazis.con);
            da.Fill(dt);
            dgv_Recept_lista.DataSource = dt;
            dgv_Recept_lista.Columns["id"].Visible = false;
            dgv_Recept_lista.Columns["Energia"].Visible = false;
            dgv_Recept_lista.Columns["Szenhidrat"].Visible = false;
            dgv_Recept_lista.Columns["Zsir"].Visible = false;
            dgv_Recept_lista.Columns["Feherje"].Visible = false;
            dgv_Recept_lista.Columns["Alapanyagok"].Visible = false;
            dgv_Recept_lista.Columns["Recept"].Visible = false;

            da.Dispose();
        }
        private void dgv_Recept_lista_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgv_Recept_lista.SelectedRows.Count > 1 || dgv_Recept_lista.SelectedRows.Count < 1)
            {
                rtb_recept.Clear();
                rtb_hozzavalok.Clear();

                lbl_osszkaloria.Text = "Összkalória mennyisége:";
                lbl_osszszenhidrat.Text = "Össz-szénhidrát mennyisége:";
                lbl_osszzsir.Text = "Össz-zsír mennyisége:";
                lbl_osszfeherje.Text = "Össz-fehérje mennyisége:";
            }
            else if (dgv_Recept_lista.SelectedRows.Count == 1)
            {
                rtb_recept.Text = dgv_Recept_lista.CurrentRow.Cells["Recept"].Value.ToString();
                rtb_hozzavalok.Text = dgv_Recept_lista.CurrentRow.Cells["Alapanyagok"].Value.ToString();

                double osszKaloria = Convert.ToDouble(dgv_Recept_lista.CurrentRow.Cells["Energia"].Value);
                double osszSzenhidrat = Convert.ToDouble(dgv_Recept_lista.CurrentRow.Cells["Szenhidrat"].Value);
                double osszZsir = Convert.ToDouble(dgv_Recept_lista.CurrentRow.Cells["Zsir"].Value);
                double osszFeherje = Convert.ToDouble(dgv_Recept_lista.CurrentRow.Cells["Feherje"].Value);

                lbl_osszkaloria.Text = "Összkalória mennyisége: " + osszKaloria + " kcal";
                lbl_osszszenhidrat.Text = "Össz-szénhidrát mennyisége: " + osszSzenhidrat + " gramm";
                lbl_osszzsir.Text = "Össz-zsír mennyisége: " + osszZsir + " gramm";
                lbl_osszfeherje.Text = "Össz-fehérje mennyisége: " + osszFeherje + " gramm";
            }
        }
        private void btn_kijeloltek_torlese_Click(object sender, EventArgs e)
        {
            if (dgv_Recept_lista.SelectedRows.Count > 0)
            {
                adatbazis.con.Open();

                foreach (DataGridViewRow sor in dgv_Recept_lista.SelectedRows)
                {
                    int id = Convert.ToInt32(sor.Cells["id"].Value);
                    adatbazis.cmd.CommandText = "DELETE FROM Receptek WHERE id=@id";
                    adatbazis.cmd.Parameters.AddWithValue("@id", id);
                    adatbazis.cmd.ExecuteNonQuery();

                    dgv_Recept_lista.Rows.Remove(sor);
                }

                adatbazis.con.Close();

                rtb_recept.Clear();
                rtb_hozzavalok.Clear();

                lbl_osszkaloria.Text = "Összkalória mennyisége:";
                lbl_osszszenhidrat.Text = "Össz-szénhidrát mennyisége:";
                lbl_osszzsir.Text = "Össz-zsír mennyisége:";
                lbl_osszfeherje.Text = "Össz-fehérje mennyisége:";
            }
        }
        private void btn_receptmodosito_Click(object sender, EventArgs e)
        {
            if (dgv_Recept_lista.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv_Recept_lista.CurrentRow.Cells["id"].Value);
                string Recept = rtb_recept.Text.Trim();
                adatbazis.con.Open();
                adatbazis.cmd.CommandText = "UPDATE Receptek SET Recept=@Recept WHERE id=@id";
                adatbazis.cmd.Parameters.AddWithValue("@id", id);
                adatbazis.cmd.Parameters.AddWithValue("@Recept", Recept);
                adatbazis.cmd.ExecuteNonQuery();
                adatbazis.con.Close();

                Receptek_megjelenito();
            }
        }
    }
}