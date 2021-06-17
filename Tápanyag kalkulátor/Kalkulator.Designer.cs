
namespace Tápanyag_kalkulátor
{
    partial class Kalkulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_megjegyzes = new System.Windows.Forms.RichTextBox();
            this.btn_MennyisegModosito = new System.Windows.Forms.Button();
            this.btn_TeljesListaBetolt = new System.Windows.Forms.Button();
            this.btn_osszes_torlese = new System.Windows.Forms.Button();
            this.btn_kijelotek_torlese = new System.Windows.Forms.Button();
            this.tb_mennyiseg = new System.Windows.Forms.TextBox();
            this.lbl_mennyiseg = new System.Windows.Forms.Label();
            this.lbl_osszkaloria = new System.Windows.Forms.Label();
            this.lbl_osszfeherje = new System.Windows.Forms.Label();
            this.lbl_osszzsir = new System.Windows.Forms.Label();
            this.lbl_osszszenhidrat = new System.Windows.Forms.Label();
            this.dgv_Kivalasztott_etelek = new System.Windows.Forms.DataGridView();
            this.cb_Kategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Alapanyag_lista = new System.Windows.Forms.DataGridView();
            this.rtb_recept = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_receptNev = new System.Windows.Forms.TextBox();
            this.btn_recept_mentese = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kivalasztott_etelek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alapanyag_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Alapanyagok, élelmiszerek lista";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(845, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Megjegyzés:";
            // 
            // rtb_megjegyzes
            // 
            this.rtb_megjegyzes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_megjegyzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_megjegyzes.Location = new System.Drawing.Point(845, 53);
            this.rtb_megjegyzes.Name = "rtb_megjegyzes";
            this.rtb_megjegyzes.ReadOnly = true;
            this.rtb_megjegyzes.Size = new System.Drawing.Size(265, 90);
            this.rtb_megjegyzes.TabIndex = 35;
            this.rtb_megjegyzes.TabStop = false;
            this.rtb_megjegyzes.Text = "";
            // 
            // btn_MennyisegModosito
            // 
            this.btn_MennyisegModosito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_MennyisegModosito.Location = new System.Drawing.Point(518, 221);
            this.btn_MennyisegModosito.Name = "btn_MennyisegModosito";
            this.btn_MennyisegModosito.Size = new System.Drawing.Size(160, 28);
            this.btn_MennyisegModosito.TabIndex = 3;
            this.btn_MennyisegModosito.Text = "Mennyiség módosítása";
            this.btn_MennyisegModosito.UseVisualStyleBackColor = true;
            this.btn_MennyisegModosito.Click += new System.EventHandler(this.btn_MennyisegModosito_Click);
            // 
            // btn_TeljesListaBetolt
            // 
            this.btn_TeljesListaBetolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_TeljesListaBetolt.Location = new System.Drawing.Point(20, 331);
            this.btn_TeljesListaBetolt.Name = "btn_TeljesListaBetolt";
            this.btn_TeljesListaBetolt.Size = new System.Drawing.Size(156, 28);
            this.btn_TeljesListaBetolt.TabIndex = 33;
            this.btn_TeljesListaBetolt.TabStop = false;
            this.btn_TeljesListaBetolt.Text = "Teljes lista betöltése";
            this.btn_TeljesListaBetolt.UseVisualStyleBackColor = true;
            this.btn_TeljesListaBetolt.Click += new System.EventHandler(this.btn_TeljesListaBetolt_Click);
            // 
            // btn_osszes_torlese
            // 
            this.btn_osszes_torlese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_osszes_torlese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_osszes_torlese.Location = new System.Drawing.Point(846, 221);
            this.btn_osszes_torlese.Name = "btn_osszes_torlese";
            this.btn_osszes_torlese.Size = new System.Drawing.Size(109, 28);
            this.btn_osszes_torlese.TabIndex = 32;
            this.btn_osszes_torlese.TabStop = false;
            this.btn_osszes_torlese.Text = "Összes törlése";
            this.btn_osszes_torlese.UseVisualStyleBackColor = true;
            this.btn_osszes_torlese.Click += new System.EventHandler(this.btn_osszes_torlese_Click);
            // 
            // btn_kijelotek_torlese
            // 
            this.btn_kijelotek_torlese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kijelotek_torlese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kijelotek_torlese.Location = new System.Drawing.Point(724, 221);
            this.btn_kijelotek_torlese.Name = "btn_kijelotek_torlese";
            this.btn_kijelotek_torlese.Size = new System.Drawing.Size(116, 28);
            this.btn_kijelotek_torlese.TabIndex = 31;
            this.btn_kijelotek_torlese.TabStop = false;
            this.btn_kijelotek_torlese.Text = "Kijelöltek törlése";
            this.btn_kijelotek_torlese.UseVisualStyleBackColor = true;
            this.btn_kijelotek_torlese.Click += new System.EventHandler(this.btn_kijelotek_torlese_Click);
            // 
            // tb_mennyiseg
            // 
            this.tb_mennyiseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_mennyiseg.Location = new System.Drawing.Point(412, 224);
            this.tb_mennyiseg.MaxLength = 10;
            this.tb_mennyiseg.Name = "tb_mennyiseg";
            this.tb_mennyiseg.Size = new System.Drawing.Size(100, 22);
            this.tb_mennyiseg.TabIndex = 2;
            // 
            // lbl_mennyiseg
            // 
            this.lbl_mennyiseg.AutoSize = true;
            this.lbl_mennyiseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_mennyiseg.Location = new System.Drawing.Point(237, 227);
            this.lbl_mennyiseg.Name = "lbl_mennyiseg";
            this.lbl_mennyiseg.Size = new System.Drawing.Size(169, 16);
            this.lbl_mennyiseg.TabIndex = 29;
            this.lbl_mennyiseg.Text = "Kívánt mennyiség (gramm):";
            // 
            // lbl_osszkaloria
            // 
            this.lbl_osszkaloria.AutoSize = true;
            this.lbl_osszkaloria.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_osszkaloria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osszkaloria.Location = new System.Drawing.Point(237, 275);
            this.lbl_osszkaloria.Name = "lbl_osszkaloria";
            this.lbl_osszkaloria.Size = new System.Drawing.Size(184, 20);
            this.lbl_osszkaloria.TabIndex = 28;
            this.lbl_osszkaloria.Text = "Összkalória mennyisége:";
            // 
            // lbl_osszfeherje
            // 
            this.lbl_osszfeherje.AutoSize = true;
            this.lbl_osszfeherje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osszfeherje.Location = new System.Drawing.Point(237, 350);
            this.lbl_osszfeherje.Name = "lbl_osszfeherje";
            this.lbl_osszfeherje.Size = new System.Drawing.Size(192, 20);
            this.lbl_osszfeherje.TabIndex = 27;
            this.lbl_osszfeherje.Text = "Össz-fehérje mennyisége:";
            // 
            // lbl_osszzsir
            // 
            this.lbl_osszzsir.AutoSize = true;
            this.lbl_osszzsir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osszzsir.Location = new System.Drawing.Point(237, 325);
            this.lbl_osszzsir.Name = "lbl_osszzsir";
            this.lbl_osszzsir.Size = new System.Drawing.Size(167, 20);
            this.lbl_osszzsir.TabIndex = 26;
            this.lbl_osszzsir.Text = "Össz-zsír mennyisége:";
            // 
            // lbl_osszszenhidrat
            // 
            this.lbl_osszszenhidrat.AutoSize = true;
            this.lbl_osszszenhidrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osszszenhidrat.Location = new System.Drawing.Point(237, 300);
            this.lbl_osszszenhidrat.Name = "lbl_osszszenhidrat";
            this.lbl_osszszenhidrat.Size = new System.Drawing.Size(217, 20);
            this.lbl_osszszenhidrat.TabIndex = 25;
            this.lbl_osszszenhidrat.Text = "Össz-szénhidrát mennyisége:";
            // 
            // dgv_Kivalasztott_etelek
            // 
            this.dgv_Kivalasztott_etelek.AllowUserToAddRows = false;
            this.dgv_Kivalasztott_etelek.AllowUserToDeleteRows = false;
            this.dgv_Kivalasztott_etelek.AllowUserToResizeColumns = false;
            this.dgv_Kivalasztott_etelek.AllowUserToResizeRows = false;
            this.dgv_Kivalasztott_etelek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Kivalasztott_etelek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Kivalasztott_etelek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Kivalasztott_etelek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Kivalasztott_etelek.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Kivalasztott_etelek.Location = new System.Drawing.Point(240, 35);
            this.dgv_Kivalasztott_etelek.Name = "dgv_Kivalasztott_etelek";
            this.dgv_Kivalasztott_etelek.ReadOnly = true;
            this.dgv_Kivalasztott_etelek.RowHeadersVisible = false;
            this.dgv_Kivalasztott_etelek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kivalasztott_etelek.Size = new System.Drawing.Size(600, 180);
            this.dgv_Kivalasztott_etelek.StandardTab = true;
            this.dgv_Kivalasztott_etelek.TabIndex = 1;
            this.dgv_Kivalasztott_etelek.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_Kivalasztott_etelek_CellPainting);
            // 
            // cb_Kategoria
            // 
            this.cb_Kategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Kategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_Kategoria.FormattingEnabled = true;
            this.cb_Kategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Kategoria.Location = new System.Drawing.Point(20, 397);
            this.cb_Kategoria.Name = "cb_Kategoria";
            this.cb_Kategoria.Size = new System.Drawing.Size(124, 24);
            this.cb_Kategoria.TabIndex = 23;
            this.cb_Kategoria.TabStop = false;
            this.cb_Kategoria.TextChanged += new System.EventHandler(this.cb_Kategoria_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Keresés kategória szerint";
            // 
            // dgv_Alapanyag_lista
            // 
            this.dgv_Alapanyag_lista.AllowUserToAddRows = false;
            this.dgv_Alapanyag_lista.AllowUserToDeleteRows = false;
            this.dgv_Alapanyag_lista.AllowUserToResizeColumns = false;
            this.dgv_Alapanyag_lista.AllowUserToResizeRows = false;
            this.dgv_Alapanyag_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Alapanyag_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alapanyag_lista.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Alapanyag_lista.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Alapanyag_lista.Location = new System.Drawing.Point(20, 35);
            this.dgv_Alapanyag_lista.Name = "dgv_Alapanyag_lista";
            this.dgv_Alapanyag_lista.ReadOnly = true;
            this.dgv_Alapanyag_lista.RowHeadersVisible = false;
            this.dgv_Alapanyag_lista.Size = new System.Drawing.Size(190, 290);
            this.dgv_Alapanyag_lista.StandardTab = true;
            this.dgv_Alapanyag_lista.TabIndex = 0;
            this.dgv_Alapanyag_lista.TabStop = false;
            this.dgv_Alapanyag_lista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Alapanyag_lista_CellDoubleClick);
            // 
            // rtb_recept
            // 
            this.rtb_recept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_recept.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_recept.Location = new System.Drawing.Point(660, 330);
            this.rtb_recept.MaxLength = 10000;
            this.rtb_recept.Name = "rtb_recept";
            this.rtb_recept.Size = new System.Drawing.Size(450, 155);
            this.rtb_recept.TabIndex = 41;
            this.rtb_recept.TabStop = false;
            this.rtb_recept.Text = "Írj egy receptet!";
            this.rtb_recept.Click += new System.EventHandler(this.rtb_recept_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(657, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Recept neve:";
            // 
            // tb_receptNev
            // 
            this.tb_receptNev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_receptNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_receptNev.Location = new System.Drawing.Point(751, 305);
            this.tb_receptNev.MaxLength = 300;
            this.tb_receptNev.Name = "tb_receptNev";
            this.tb_receptNev.Size = new System.Drawing.Size(150, 22);
            this.tb_receptNev.TabIndex = 39;
            this.tb_receptNev.TabStop = false;
            // 
            // btn_recept_mentese
            // 
            this.btn_recept_mentese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recept_mentese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_recept_mentese.Location = new System.Drawing.Point(985, 491);
            this.btn_recept_mentese.Name = "btn_recept_mentese";
            this.btn_recept_mentese.Size = new System.Drawing.Size(125, 28);
            this.btn_recept_mentese.TabIndex = 38;
            this.btn_recept_mentese.TabStop = false;
            this.btn_recept_mentese.Text = "Recept mentése";
            this.btn_recept_mentese.UseVisualStyleBackColor = true;
            this.btn_recept_mentese.Click += new System.EventHandler(this.btn_recept_mentese_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(237, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Étkezés összetevői";
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtb_recept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_receptNev);
            this.Controls.Add(this.btn_recept_mentese);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_megjegyzes);
            this.Controls.Add(this.btn_MennyisegModosito);
            this.Controls.Add(this.btn_TeljesListaBetolt);
            this.Controls.Add(this.btn_osszes_torlese);
            this.Controls.Add(this.btn_kijelotek_torlese);
            this.Controls.Add(this.tb_mennyiseg);
            this.Controls.Add(this.lbl_mennyiseg);
            this.Controls.Add(this.lbl_osszkaloria);
            this.Controls.Add(this.lbl_osszfeherje);
            this.Controls.Add(this.lbl_osszzsir);
            this.Controls.Add(this.lbl_osszszenhidrat);
            this.Controls.Add(this.dgv_Kivalasztott_etelek);
            this.Controls.Add(this.cb_Kategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Alapanyag_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kivalasztott_etelek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alapanyag_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_megjegyzes;
        private System.Windows.Forms.Button btn_MennyisegModosito;
        private System.Windows.Forms.Button btn_TeljesListaBetolt;
        private System.Windows.Forms.Button btn_osszes_torlese;
        private System.Windows.Forms.Button btn_kijelotek_torlese;
        private System.Windows.Forms.TextBox tb_mennyiseg;
        private System.Windows.Forms.Label lbl_mennyiseg;
        private System.Windows.Forms.Label lbl_osszkaloria;
        private System.Windows.Forms.Label lbl_osszfeherje;
        private System.Windows.Forms.Label lbl_osszzsir;
        private System.Windows.Forms.Label lbl_osszszenhidrat;
        private System.Windows.Forms.DataGridView dgv_Kivalasztott_etelek;
        private System.Windows.Forms.ComboBox cb_Kategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Alapanyag_lista;
        private System.Windows.Forms.RichTextBox rtb_recept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_receptNev;
        private System.Windows.Forms.Button btn_recept_mentese;
        private System.Windows.Forms.Label label5;
    }
}