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

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {


            if (this.Text.Equals("Speise anlegen"))
            {
                if (Form1.f1.vorspeise == true)
                {
                    sql = "INSERT INTO Vorspeise (VID, Vorspeise, Preis) VALUES ('" + txtID.Text + "', '" + txtSpeise.Text +  "');";
                    //MessageBox.Show(sql);
                    MessageBox.Show("Die Vorspeise wurde gespeichert!");
                    Form1.f1.einlesenVorspeise();

                }
                else if (Form1.f1.hauptspeise == true)
                {
                    sql = "INSERT INTO Hauptspeise (HID, Hauptspeise, Preis) VALUES ('" + txtID.Text + "', '" + txtSpeise.Text + "');";
                    //MessageBox.Show(sql);
                    MessageBox.Show("Die Hauptspeise wurde gespeichert!");
                    Form1.f1.einlesenHauptspeise();
                }

                else if (Form1.f1.nachspeise == true)
                {
                    sql = "INSERT INTO Nachspeise (NID, Nachspeise, Preis) VALUES ('" + txtID.Text + "', '" + txtSpeise.Text + "');";
                    //MessageBox.Show(sql);
                    MessageBox.Show("Die Nachspeise wurde gespeichert!");
                    Form1.f1.einlesenNachspeise();
                }
            }
        }
    }
}
            

