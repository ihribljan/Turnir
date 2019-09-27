using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnir
{
    public partial class Pocetna : Form
    {
        Raspored r = new Raspored();

        public Pocetna()
        {
            InitializeComponent();
            r.Azuriraj();
        }

        private void Pocetna_Load_1(object sender, EventArgs e)
        {
            PrikaziRaspored();
        }

        public void PrikaziRaspored()
        {
            using (var db = new TurnirEntities2())
            {
                var upitPrikaziRaspored = (from item in db.Rasporedi
                                           join c in db.Ekipe on item.EkipeIdDomacin equals c.Id
                                           join b in db.Ekipe on item.EkipeIdGost equals b.Id
                                           join a in db.Grupe on c.GrupeId equals a.Id
                                           select new
                                           {
                                               Vrijeme = item.Vrijeme,
                                               Grupa = item.Grupe.Naziv,
                                               Domacin = c.Naziv,
                                               Gost = b.Naziv,
                                               Rezultat = item.GoloviDomacin + ":" + item.GoloviGost,
                                               Odigrano = item.Odigrano
                                           }
                                           );

                if (upitPrikaziRaspored != null)
                {
                    Console.WriteLine("Upit");

                    dgvRaspored.DataSource = upitPrikaziRaspored.ToList();
                    dgvRaspored.RowHeadersVisible = false;

                    DataGridViewColumn vrijeme = dgvRaspored.Columns["Vrijeme"];
                    vrijeme.Width = 55;
                    DataGridViewColumn grupa = dgvRaspored.Columns["Grupa"];
                    grupa.Width = 45;
                    DataGridViewColumn domacin = dgvRaspored.Columns["Domacin"];
                    domacin.Width = 130;
                    DataGridViewColumn gost = dgvRaspored.Columns["Gost"];
                    gost.Width = 130;
                    DataGridViewColumn rezultat = dgvRaspored.Columns["Rezultat"];
                    rezultat.Width = 60;
                    DataGridViewColumn odigrano = dgvRaspored.Columns["Odigrano"];
                    odigrano.Width = 60;
                }
                else
                {
                    Console.WriteLine("Upit prazan!");
                }
            }
        }

        private void btnRaspored_Click(object sender, EventArgs e)
        {
            Raspored forma = new Raspored();
            forma.ShowDialog();
        }

        private void btnTablica_Click(object sender, EventArgs e)
        {
            Tablica t = new Tablica();
            t.ShowDialog();
        }

        private void btnEkipe_Click_1(object sender, EventArgs e)
        {
            FormaEkipe f = new FormaEkipe();
            f.ShowDialog();
        }
    }
}
