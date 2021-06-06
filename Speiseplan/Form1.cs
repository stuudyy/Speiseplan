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


        internal void einlesenVorspeise()
        {
            lvVorspeise.Items.Clear();
            sql = "Select * from Vorspeise";
            dr = db.Einlesen(sql);
            while (dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                lvItem.SubItems.Add(dr[2].ToString());

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
                lvItem.SubItems.Add(dr[2].ToString());

                lvNachspeise.Items.Add(lvItem);
            }
            lvNachspeise.FullRowSelect = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
            einlesenVorspeise();
            einlesenHauptspeise();
            einlesenNachspeise();
        }

        private void anlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
