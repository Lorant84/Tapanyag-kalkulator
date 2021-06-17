
namespace Tápanyag_kalkulátor
{
    partial class Receptek
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_receptmodosito = new System.Windows.Forms.Button();
            this.lbl_osszzsir = new System.Windows.Forms.Label();
            this.lbl_osszszenhidrat = new System.Windows.Forms.Label();
            this.lbl_osszkaloria = new System.Windows.Forms.Label();
            this.btn_kijeloltek_torlese = new System.Windows.Forms.Button();
            this.lbl_osszfeherje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_hozzavalok = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_recept = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Recept_lista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recept_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_receptmodosito
            // 
            this.btn_receptmodosito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_receptmodosito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_receptmodosito.Location = new System.Drawing.Point(888, 349);
            this.btn_receptmodosito.Name = "btn_receptmodosito";
            this.btn_receptmodosito.Size = new System.Drawing.Size(142, 28);
            this.btn_receptmodosito.TabIndex = 48;
            this.btn_receptmodosito.TabStop = false;
            this.btn_receptmodosito.Text = "Recept módosítása";
            this.btn_receptmodosito.UseVisualStyleBackColor = true;
            this.btn_receptmodosito.Click += new System.EventHandler(this.btn_receptmodosito_Click);
            // 
            // lbl_osszzsir
            // 
            this.lbl_osszzsir.AutoSize = true;
            this.lbl_osszzsir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osszzsir.Location = new System.Drawing.Point(476, 405);
            this.lbl_osszzsir.Name = "lbl_osszzsir";
            this.lbl_osszzsir.Size = new System.Drawing.Size(167, 20);
            this.lbl_osszzsir.TabIndex = 44;
            this.lbl_osszzsir.Text = "Össz-zsír mennyisége:";
            // 
            // lbl_osszszenhidrat
            // 
            this.lbl_osszszenhidrat.AutoSize = true;
            this.lbl_osszszenhidrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osszszenhidrat.Location = new System.Drawing.Point(476, 380);
            this.lbl_osszszenhidrat.Name = "lbl_osszszenhidrat";
            this.lbl_osszszenhidrat.Size = new System.Drawing.Size(217, 20);
            this.lbl_osszszenhidrat.TabIndex = 43;
            this.lbl_osszszenhidrat.Text = "Össz-szénhidrát mennyisége:";
            // 
            // lbl_osszkaloria
            // 
            this.lbl_osszkaloria.AutoSize = true;
            this.lbl_osszkaloria.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_osszkaloria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osszkaloria.Location = new System.Drawing.Point(476, 355);
            this.lbl_osszkaloria.Name = "lbl_osszkaloria";
            this.lbl_osszkaloria.Size = new System.Drawing.Size(184, 20);
            this.lbl_osszkaloria.TabIndex = 46;
            this.lbl_osszkaloria.Text = "Összkalória mennyisége:";
            // 
            // btn_kijeloltek_torlese
            // 
            this.btn_kijeloltek_torlese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kijeloltek_torlese.Location = new System.Drawing.Point(20, 456);
            this.btn_kijeloltek_torlese.Name = "btn_kijeloltek_torlese";
            this.btn_kijeloltek_torlese.Size = new System.Drawing.Size(126, 28);
            this.btn_kijeloltek_torlese.TabIndex = 47;
            this.btn_kijeloltek_torlese.TabStop = false;
            this.btn_kijeloltek_torlese.Text = "Kijelöltek törlése";
            this.btn_kijeloltek_torlese.UseVisualStyleBackColor = true;
            this.btn_kijeloltek_torlese.Click += new System.EventHandler(this.btn_kijeloltek_torlese_Click);
            // 
            // lbl_osszfeherje
            // 
            this.lbl_osszfeherje.AutoSize = true;
            this.lbl_osszfeherje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_osszfeherje.Location = new System.Drawing.Point(476, 430);
            this.lbl_osszfeherje.Name = "lbl_osszfeherje";
            this.lbl_osszfeherje.Size = new System.Drawing.Size(192, 20);
            this.lbl_osszfeherje.TabIndex = 45;
            this.lbl_osszfeherje.Text = "Össz-fehérje mennyisége:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(237, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hozzávalók";
            // 
            // rtb_hozzavalok
            // 
            this.rtb_hozzavalok.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_hozzavalok.Location = new System.Drawing.Point(240, 68);
            this.rtb_hozzavalok.Name = "rtb_hozzavalok";
            this.rtb_hozzavalok.ReadOnly = true;
            this.rtb_hozzavalok.Size = new System.Drawing.Size(190, 382);
            this.rtb_hozzavalok.TabIndex = 41;
            this.rtb_hozzavalok.TabStop = false;
            this.rtb_hozzavalok.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(477, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Recept";
            // 
            // rtb_recept
            // 
            this.rtb_recept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_recept.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_recept.Location = new System.Drawing.Point(480, 68);
            this.rtb_recept.Name = "rtb_recept";
            this.rtb_recept.Size = new System.Drawing.Size(550, 275);
            this.rtb_recept.TabIndex = 39;
            this.rtb_recept.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Recept lista";
            // 
            // dgv_Recept_lista
            // 
            this.dgv_Recept_lista.AllowUserToAddRows = false;
            this.dgv_Recept_lista.AllowUserToDeleteRows = false;
            this.dgv_Recept_lista.AllowUserToResizeColumns = false;
            this.dgv_Recept_lista.AllowUserToResizeRows = false;
            this.dgv_Recept_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Recept_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recept_lista.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Recept_lista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Recept_lista.Location = new System.Drawing.Point(20, 35);
            this.dgv_Recept_lista.Name = "dgv_Recept_lista";
            this.dgv_Recept_lista.ReadOnly = true;
            this.dgv_Recept_lista.RowHeadersVisible = false;
            this.dgv_Recept_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Recept_lista.Size = new System.Drawing.Size(190, 415);
            this.dgv_Recept_lista.TabIndex = 37;
            this.dgv_Recept_lista.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_Recept_lista_CellPainting);
            // 
            // Receptek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 600);
            this.Controls.Add(this.btn_receptmodosito);
            this.Controls.Add(this.lbl_osszzsir);
            this.Controls.Add(this.lbl_osszszenhidrat);
            this.Controls.Add(this.lbl_osszkaloria);
            this.Controls.Add(this.btn_kijeloltek_torlese);
            this.Controls.Add(this.lbl_osszfeherje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_hozzavalok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_recept);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Recept_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receptek";
            this.Text = "Receptek";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recept_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_receptmodosito;
        private System.Windows.Forms.Label lbl_osszzsir;
        private System.Windows.Forms.Label lbl_osszszenhidrat;
        private System.Windows.Forms.Label lbl_osszkaloria;
        private System.Windows.Forms.Button btn_kijeloltek_torlese;
        private System.Windows.Forms.Label lbl_osszfeherje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_hozzavalok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_recept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Recept_lista;
    }
}