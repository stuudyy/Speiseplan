using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Speiseplan
{
    public partial class Form1 : Form
    {
        internal static Form1 f1;
        public Form1()
        {
            f1 = this;
            InitializeComponent();
        }

        ListViewItem lvItem;
        Datenbank db;
        OleDbDataReader dr;
        string sql;
        internal OleDbCommand cmd;
        internal string cn;
        internal bool vorspeise = false;
        internal bool hauptspeise = false;
        internal bool nachspeise = false;

        internal void einlesenVorspeise()
        {
            lvVorspeise.Items.Clear();
            sql = "Select * from Vorspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());

                lvVorspeise.Items.Add(lvItem);
            }
            lvVorspeise.FullRowSelect = true;
        }

        internal void einlesenHauptspeise()
        {
            lvHauptspeise.Items.Clear();
            sql = "Select * from Hauptspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());

                lvHauptspeise.Items.Add(lvItem);
            }
            lvHauptspeise.FullRowSelect = true;
        }

        internal void einlesenNachspeise()
        {
            lvNachspeise.Items.Clear();
            sql = "Select * from Nachspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());

                lvNachspeise.Items.Add(lvItem);
            }
            lvNachspeise.FullRowSelect = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 226;
            db = new Datenbank();
            einlesenVorspeise();
            einlesenHauptspeise();
            einlesenNachspeise();
        }

        private void btnVorspeise_Click(object sender, EventArgs e)
        {
            this.Width = 642;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            lvVorspeise.Visible = true;
            lvHauptspeise.Visible = false;
            lvNachspeise.Visible = false;
            einlesenVorspeise();
            vorspeise = true;
            hauptspeise = false;
            nachspeise = false;
        }

        private void btnHauptspeise_Click(object sender, EventArgs e)
        {
            this.Width = 642;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            lvVorspeise.Visible = false;
            lvHauptspeise.Visible = true;
            lvNachspeise.Visible = false;
            einlesenHauptspeise();
            vorspeise = false;
            hauptspeise = true;
            nachspeise = false;
        }

        private void btnNachspeise_Click(object sender, EventArgs e)
        {
            this.Width = 642;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            lvVorspeise.Visible = false;
            lvHauptspeise.Visible = false;
            lvNachspeise.Visible = true;
            einlesenNachspeise();
            vorspeise = false;
            hauptspeise = false;
            nachspeise = true;
        }


        private void anlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Speise anlegen";
            f2.txtID.Text = (Datenbank.getStartNr()).ToString();
            f2.ShowDialog();
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.f1.vorspeise == true)
            {
                if (lvVorspeise.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Wählen Sie bitte eine Speise aus!");
                    return;
                }
                lvItem = lvVorspeise.SelectedItems[0];
                Form2 f2 = new Form2();
                f2.Text = "Speise ändern";
                f2.txtID.Text = lvItem.SubItems[0].Text;
                f2.txtSpeise.Text = lvItem.SubItems[1].Text;


                f2.ShowDialog();
                einlesenVorspeise();
            }
            else if (Form1.f1.hauptspeise == true)
            {
                if (lvHauptspeise.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Wählen Sie bitte eine Speise aus!");
                    return;
                }
                lvItem = lvHauptspeise.SelectedItems[0];
                Form2 f2 = new Form2();
                f2.Text = "Speise ändern";
                f2.txtID.Text = lvItem.SubItems[0].Text;
                f2.txtSpeise.Text = lvItem.SubItems[1].Text;
                

                f2.ShowDialog();
                einlesenHauptspeise();
            }
            else if (Form1.f1.nachspeise == true)
            {
                if (lvNachspeise.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Wählen Sie bitte eine Speise aus!");
                    return;
                }
                lvItem = lvNachspeise.SelectedItems[0];
                Form2 f2 = new Form2();
                f2.Text = "Speise ändern";
                f2.txtID.Text = lvItem.SubItems[0].Text;
                f2.txtSpeise.Text = lvItem.SubItems[1].Text;
                

                f2.ShowDialog();
                einlesenNachspeise();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            int idV;
            int idH;
            int idN;

            if (Form1.f1.vorspeise == true)
            {
                DialogResult dr = MessageBox.Show("Wollen Sie diese Speise wirklich löschen?", "Achtung!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    lvItem = lvVorspeise.SelectedItems[0];
                    index = lvItem.Index;
                    idV = Convert.ToInt32(lvVorspeise.Items[index].SubItems[0].Text.ToString());

                    lvVorspeise.Items.RemoveAt(index);
                    sql = "DELETE FROM Vorspeise WHERE VorspeiseID=" + idV + "";
                    MessageBox.Show("Die Vorspeise wurde gelöscht!");
                    db.Ausfuehren(sql);
                }


            }
            else if (Form1.f1.hauptspeise == true)
            {
                DialogResult dr = MessageBox.Show("Wollen Sie diese Speise wirklich löschen?", "Achtung!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    lvItem = lvHauptspeise.SelectedItems[0];
                    index = lvItem.Index;
                    idH = Convert.ToInt32(lvHauptspeise.Items[index].SubItems[0].Text.ToString());

                    lvHauptspeise.Items.RemoveAt(index);
                    sql = "DELETE FROM Hauptspeise WHERE HauptspeiseID=" + idH + "";
                    MessageBox.Show("Die Hauptspeise wurde gelöscht!");
                    db.Ausfuehren(sql);
                }
            }

            else if (Form1.f1.nachspeise == true)
            {
                DialogResult dr = MessageBox.Show("Wollen Sie diese Speise wirklich löschen?", "Achtung!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    lvItem = lvNachspeise.SelectedItems[0];
                    index = lvItem.Index;
                    idN = Convert.ToInt32(lvNachspeise.Items[index].SubItems[0].Text.ToString());

                    lvNachspeise.Items.RemoveAt(index);
                    sql = "DELETE FROM Nachspeise WHERE NachspeiseID=" + idN + "";
                    MessageBox.Show("Die Nachspeise wurde gelöscht!");
                    db.Ausfuehren(sql);
                }
            }

        }

        private void lvHauptspeise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeiseplan_Click(object sender, EventArgs e)
        {
            SpeiseplanZufällig f3 = new SpeiseplanZufällig();
            f3.Text = "Speiseplan der Woche";
            f3.ShowDialog();
        }
    }
}



