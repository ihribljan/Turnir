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
    public partial class DodajUtakmicu : Form
    {
        public DodajUtakmicu()
        {
            InitializeComponent();
        }

        private void DodajUtakmicu_Load(object sender, EventArgs e)
        {
            PopuniCombo();
        }

        public void PopuniCombo()
        {
            using (var db = new TurnirEntities2())
            {
                var upitCombo = (from it in db.Ekipe
                                 select it.Naziv);

                cmbDomacin.DataSource = upitCombo.ToList();
                cmbGost.DataSource = upitCombo.ToList();

                var upitGrupe = (from it in db.Grupe
                                 select it);

                cmbGrupa.DataSource = upitGrupe.ToList();
                cmbGrupa.ValueMember = "Id";
                cmbGrupa.DisplayMember = "Naziv";
            }
        }

        public void DodajUtakmicuURaspored()
        {
            using (var db = new TurnirEntities2())
            {
                var upitDomacin = from it in db.Ekipe
                                  where it.Naziv == cmbDomacin.Text
                                  select it;

                var upitGost = from item in db.Ekipe
                               where item.Naziv == cmbGost.Text
                               select item;

                var upit = from it in db.Grupe
                           where it.Naziv == cmbGrupa.Text
                           select it;

                Ekipe ekipeDomacin = upitDomacin.First();
                Ekipe ekipeGost = upitGost.First();
                Grupe grupe = upit.First();

                Rasporedi rasporedi = new Rasporedi
                {
                    GrupeId = grupe.Id,
                    Vrijeme = txtVrijeme.Text,
                    EkipeIdDomacin = ekipeDomacin.Id,
                    EkipeIdGost = ekipeGost.Id,
                    GoloviDomacin = 0,
                    GoloviGost = 0,
                    Odigrano = "NE"
                };
                
                db.Rasporedi.Add(rasporedi);
                db.SaveChanges();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajUtakmicuURaspored();
            MessageBox.Show("Utakmica uspješno dodana!");
            this.Close();
            Raspored raspored = new Raspored();
            raspored.PrikaziRaspored();
        }
    }
}
