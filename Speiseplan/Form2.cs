using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections;

namespace Speiseplan
{
    public partial class Form2 : Form
    {
        internal static Form2 f2;

        public Form2()
        {
            f2 = this;
            InitializeComponent();
        }

        string sql;
        Datenbank db;
        ListViewItem lvItem;

        int index;
        internal int vorspeiseId = 0;
        internal int hauptspeiseId = 0;
        internal int nachspeiseId = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtSpeise.Text.Equals(""))
            {
                MessageBox.Show("Die Felder dürfen nicht leer sein!");
                return;
            }

            if (this.Text.Equals("Speise anlegen"))
            {
                if (Form1.f1.vorspeise == true)
                {
                    sql = "INSERT INTO Vorspeise (VorspeiseID, Vorspeise) VALUES ('" + txtID.Text + "', '" + txtSpeise.Text +  "');";
                    MessageBox.Show("Die Vorspeise wurde gespeichert!");
                    Form1.f1.einlesenVorspeise();

                }
                else if (Form1.f1.hauptspeise == true)
                {
                    sql = "INSERT INTO Hauptspeise (HauptspeiseID, Hauptspeise) VALUES ('" + txtID.Text + "', '" + txtSpeise.Text + "');";
                    MessageBox.Show("Die Hauptspeise wurde gespeichert!");
                    Form1.f1.einlesenHauptspeise();
                }

                else if (Form1.f1.nachspeise == true)
                {
                    sql = "INSERT INTO Nachspeise (NachspeiseID, Nachspeise) VALUES ('" + txtID.Text + "', '" + txtSpeise.Text + "');";
                    MessageBox.Show("Die Nachspeise wurde gespeichert!");
                    Form1.f1.einlesenNachspeise();
                }

                Form1.f1.vorspeise = false;
                Form1.f1.hauptspeise = false;
                Form1.f1.nachspeise = false;
            }
            else //bearbeiten
            {
                if (Form1.f1.vorspeise == true)
                {
                    lvItem = Form1.f1.lvVorspeise.SelectedItems[0];
                    index = lvItem.Index;
                    vorspeiseId = Convert.ToInt32(Form1.f1.lvVorspeise.Items[index].SubItems[0].Text.ToString());

                    sql = "UPDATE Vorspeise set Vorspeise = '" + txtSpeise.Text + "' WHERE VorspeiseID = " + vorspeiseId;
                    MessageBox.Show(sql);
                }

                else if (Form1.f1.hauptspeise == true)
                {
                    lvItem = Form1.f1.lvHauptspeise.SelectedItems[0];
                    index = lvItem.Index;
                    hauptspeiseId = Convert.ToInt32(Form1.f1.lvHauptspeise.Items[index].SubItems[0].Text.ToString());

                    sql = "UPDATE Hauptspeise set Hauptspeise = '" + txtSpeise.Text + "' WHERE HauptspeiseID = " + hauptspeiseId;
                    //MessageBox.Show(sql);
                }

                else if (Form1.f1.nachspeise == true)
                {
                    lvItem = Form1.f1.lvNachspeise.SelectedItems[0];
                    index = lvItem.Index;
                    nachspeiseId = Convert.ToInt32(Form1.f1.lvNachspeise.Items[index].SubItems[0].Text.ToString());

                    sql = "UPDATE Nachspeise set Nachspeise = '" + txtSpeise.Text + "' WHERE NachspeiseID = " + nachspeiseId;
                    //MessageBox.Show(sql);
                }

            }
            db.Ausfuehren(sql);
            this.Close();
        
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
            

