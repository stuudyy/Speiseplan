using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speiseplan
{
    public partial class SpeiseplanZufällig : Form
    {
        internal static SpeiseplanZufällig f3;

        public SpeiseplanZufällig()
        {
            f3 = this;
            InitializeComponent();
        }

        Datenbank db;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void SpeiseplanRandom()
        {
            string[] vorspeise = { "Hühnersuppe", "Fritattensuppe", "Spargelcremesuppe", "Spargel-Lachs-Tatar", "Mozarellaspieß", "Sushi & Maki", "Belegte Brötchen", "Pizzaschnecken", "Salatteller", "Leberknödelsuppe" };
            string[] hauptspeise = { "Schnitzel mit Pommes", "Rindfleisch mit Semmelkren", "Spaghetti Bolognese", "Steak mit Bratkartoffeln", "Pizza", "Kartoffelgulasch", "Kaiserschmarren", "Palatschinken", "Kotelett mit Pommes und Gemüse", "Lasagne", "Rehragout mit Kartoffeln", "Cordon Bleu", "Putenstreifensalat", "Gemüsenudeln", "Penne al Capone" };
            string[] nachspeise = { "Tiramisu", "Heiße Liebe", "Mohr im Hemd", "Eispalatschinken", "Bananensplit", "Cookie", "Apfelstrudel", "Mohnkuchen", "Apfelkuchen", "Bananenschnitte" };

            Random rand = new Random();
            for (int i = 0; i < vorspeise.Length; i++)
            {
                int Mo = rand.Next(vorspeise.Length);
                int Di = rand.Next(vorspeise.Length);
                int Mi = rand.Next(vorspeise.Length);
                int Do = rand.Next(vorspeise.Length);
                int Fr = rand.Next(vorspeise.Length);

                txtVorspeiseMo.Text = (vorspeise[Mo]);
                txtVorpeiseDi.Text = (vorspeise[Di]);
                txtVorpeiseMi.Text = (vorspeise[Mi]);
                txtVorspeiseDo.Text = (vorspeise[Do]);
                txtVorspeiseFr.Text = (vorspeise[Fr]);
            }

            for (int i = 0; i < hauptspeise.Length; i++)
            {
                int Mo = rand.Next(hauptspeise.Length);
                int Di = rand.Next(hauptspeise.Length);
                int Mi = rand.Next(hauptspeise.Length);
                int Do = rand.Next(hauptspeise.Length);
                int Fr = rand.Next(hauptspeise.Length);

                txtHauptspeiseMo.Text = (hauptspeise[Mo]);
                txtHauptspeiseDi.Text = (hauptspeise[Di]);
                txtHauptspeiseMi.Text = (hauptspeise[Mi]);
                txtHauptspeiseDo.Text = (hauptspeise[Do]);
                txtHauptspeiseFr.Text = (hauptspeise[Fr]);
            }

            for (int i = 0; i < nachspeise.Length; i++)
            {
                int Mo = rand.Next(nachspeise.Length);
                int Di = rand.Next(nachspeise.Length);
                int Mi = rand.Next(nachspeise.Length);
                int Do = rand.Next(nachspeise.Length);
                int Fr = rand.Next(nachspeise.Length);

                txtNachspeiseMo.Text = (nachspeise[Mo]);
                txtNachspeiseDi.Text = (nachspeise[Di]);
                txtNachspeiseMi.Text = (nachspeise[Mi]);
                txtNachspeiseDo.Text = (nachspeise[Do]);
                txtNachspeiseFr.Text = (nachspeise[Fr]);
            }



        }

        private void SpeiseplanZufällig_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
            SpeiseplanRandom();
        }

        private void btnDrucken_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = new Microsoft.Office.Interop.Word.Application();
            if (wordapp == null)
            {
                MessageBox.Show("Es konnte keine Verbindung zu Word hergestellt werden!");
                return;
            }

            wordapp.Visible = true;
            wordapp.Documents.Open(Application.StartupPath + "\\../../../../Speiseplan.docx");
            wordapp.ActiveDocument.FormFields["VMontag"].Result = txtVorspeiseMo.Text;
            wordapp.ActiveDocument.FormFields["VDienstag"].Result = txtVorpeiseDi.Text;
            wordapp.ActiveDocument.FormFields["VMittwoch"].Result = txtVorpeiseMi.Text;
            wordapp.ActiveDocument.FormFields["VDonnerstag"].Result = txtVorspeiseDo.Text;
            wordapp.ActiveDocument.FormFields["VFreitag"].Result = txtVorspeiseFr.Text;

            wordapp.ActiveDocument.FormFields["HMontag"].Result = txtHauptspeiseMo.Text;
            wordapp.ActiveDocument.FormFields["HDienstag"].Result = txtHauptspeiseDi.Text;
            wordapp.ActiveDocument.FormFields["HMittwoch"].Result = txtHauptspeiseMi.Text;
            wordapp.ActiveDocument.FormFields["HDonnerstag"].Result = txtHauptspeiseDo.Text;
            wordapp.ActiveDocument.FormFields["HFreitag"].Result = txtHauptspeiseFr.Text;

            wordapp.ActiveDocument.FormFields["NMontag"].Result = txtNachspeiseMo.Text;
            wordapp.ActiveDocument.FormFields["NDienstag"].Result = txtNachspeiseDi.Text;
            wordapp.ActiveDocument.FormFields["NMittwoch"].Result = txtNachspeiseMi.Text;
            wordapp.ActiveDocument.FormFields["NDonnerstag"].Result = txtNachspeiseDo.Text;
            wordapp.ActiveDocument.FormFields["NFreitag"].Result = txtNachspeiseFr.Text;

            wordapp.ActiveDocument.SaveAs2(Application.StartupPath + "\\../../../" + txtVorspeiseMo.Text + ".docx");
            wordapp.ActiveDocument.ExportAsFixedFormat(Application.StartupPath + "\\../../../" + txtVorspeiseMo.Text + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF, true);
        }
    }
}
