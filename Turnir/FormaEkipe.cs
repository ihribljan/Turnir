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
    public partial class FormaEkipe : Form
    {
        public FormaEkipe()
        {
            InitializeComponent();
        }

        private void FormaEkipe_Load(object sender, EventArgs e)
        {
            PrikaziEkipe();
            PopuniCombo();
            cmbGrupe.Visible = false;
            panel4.Visible = false;
        }

        public void PopuniCombo()
        {
            using (var db = new TurnirEntities2())
            {
               var upitGrupe = (from it in db.Grupe
                                 select it);

                cmbGrupe.DataSource = upitGrupe.ToList();
                cmbGrupe.ValueMember = "Id";
                cmbGrupe.DisplayMember = "Naziv";
            }
        }

        public void PrikaziEkipe()
        {
            using (var db = new TurnirEntities2())
            {
                var upitPrikaziEkipe = (from it in db.Ekipe
                                        orderby it.Naziv ascending
                                        select it);

                dgvEkipe.DataSource = upitPrikaziEkipe.ToList();
                dgvEkipe.Columns[0].Visible = false;
                dgvEkipe.Columns[2].Visible = false;
                dgvEkipe.Columns[3].Visible = false;
                dgvEkipe.Columns[4].Visible = false;
                dgvEkipe.Columns[5].Visible = false;
                dgvEkipe.Columns[6].Visible = false;
                dgvEkipe.Columns[7].Visible = false;
                dgvEkipe.Columns[8].Visible = false;
                dgvEkipe.Columns[9].Visible = false;
                dgvEkipe.Columns[10].Visible = false;
                dgvEkipe.Columns[11].Visible = false;
                dgvEkipe.Columns[12].Visible = false;
                dgvEkipe.Columns[13].Visible = false;
                dgvEkipe.Columns[14].Visible = false;
                dgvEkipe.Columns[15].Visible = false;

                dgvEkipe.Columns[1].Width = 160;
            }
        }
        
        public void UnosEkipe()
        {
            using (var db = new TurnirEntities2())
            {
                Ekipe ekipe = new Ekipe
                {
                    Naziv = txtUnosEkipe.Text,
                };

                db.Ekipe.Add(ekipe);
                db.SaveChanges();
            }
        }

        private void btnUnosEkipe_Click(object sender, EventArgs e)
        {
            UnosEkipe();
            MessageBox.Show("Ekipa uspješno dodana!");
            PrikaziEkipe();
            txtUnosEkipe.Text = "Naziv ekipe";
        }

        public void BrisiEkipu()
        {
            if (dgvEkipe.CurrentRow != null)
            {
                Ekipe ekipa = dgvEkipe.CurrentRow.DataBoundItem as Ekipe;
                if (ekipa != null)
                {
                    if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new TurnirEntities2())
                        {
                            db.Ekipe.Attach(ekipa);
                            db.Ekipe.Remove(ekipa);
                            db.SaveChanges();
                        }
                    }
                    PrikaziEkipe();
                }
            }
        }

        private void btnBrisiEkipu_Click(object sender, EventArgs e)
        {
            BrisiEkipu();
            MessageBox.Show("Ekipa uspješno obrisana!");
        }

        public void DodajIgraca()
        {
            Ekipe ekipe = dgvEkipe.CurrentRow.DataBoundItem as Ekipe;

            using (var db = new TurnirEntities2())
            {
                Igraci igrac = new Igraci
                {
                    Ime = txtImeIgraca.Text,
                    Prezime = txtPrezimeIgraca.Text,
                    EkipeId = ekipe.Id
                };
                db.Igraci.Add(igrac);
                db.SaveChanges();
            }
        }

        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            DodajIgraca();
            MessageBox.Show("Igrač uspješno dodan!");
            PrikaziEkipe();
            txtImeIgraca.Text = "Ime";
            txtPrezimeIgraca.Text = "Prezime";
        }

        public void BrisiIgraca()
        {
            Igraci igraci = dgvIgraci.CurrentRow.DataBoundItem as Igraci;
            if (igraci != null)
            {
                using (var db = new TurnirEntities2())
                {
                    db.Igraci.Attach(igraci);
                    db.Igraci.Remove(igraci);
                    db.SaveChanges();
                }
            }
        }

        private void btnBrisiIgraca_Click(object sender, EventArgs e)
        {
            BrisiIgraca();
            MessageBox.Show("Igrač uspješno obrisan!");
            PrikaziEkipe();
        }

        private void dgvEkipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ekipe ekipe = dgvEkipe.CurrentRow.DataBoundItem as Ekipe;
            using (var db = new TurnirEntities2())
            {
                var upitigraci = (from it in db.Igraci
                                  where it.EkipeId == ekipe.Id
                                  orderby it.Prezime ascending
                                  select it);

                dgvIgraci.DataSource = upitigraci.ToList();

                dgvIgraci.Columns[0].Visible = false;
                dgvIgraci.Columns[3].Visible = false;
                dgvIgraci.Columns[4].Visible = false;
                dgvIgraci.Columns[5].Visible = false;
                dgvIgraci.Columns[6].Visible = false;
                dgvIgraci.Columns[7].Visible = false;
                dgvIgraci.Columns[8].Visible = false;
                dgvIgraci.Columns["PrezimeIme"].Visible = false;
            }
        }

        private void txtUnosEkipe_MouseClick(object sender, MouseEventArgs e)
        {
            txtUnosEkipe.Text = "";
        }

        private void dgvEkipe_SelectionChanged(object sender, EventArgs e)
        {
            Ekipe ekipe = dgvEkipe.CurrentRow.DataBoundItem as Ekipe;

            txtUnosEkipe.Text = ekipe.Naziv;
        }

        private void dgvIgraci_SelectionChanged(object sender, EventArgs e)
        {
            //Igraci igraci = dgvIgraci.CurrentRow.DataBoundItem as Igraci;

            //txtImeIgraca.Text = igraci.Ime;
            //txtPrezimeIgraca.Text = igraci.Prezime;
        }

        private void txtImeIgraca_MouseClick(object sender, MouseEventArgs e)
        {
            txtImeIgraca.Text = "";
        }

        private void txtPrezimeIgraca_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrezimeIgraca.Text = "";
        }

        private void txtImeIgraca_MouseLeave(object sender, EventArgs e)
        {
            if(txtImeIgraca.Text == "")
            {
                txtImeIgraca.Text = "Ime";
            }
        }

        private void txtPrezimeIgraca_MouseLeave(object sender, EventArgs e)
        {
            if(txtPrezimeIgraca.Text == "")
            {
                txtPrezimeIgraca.Text = "Prezime";
            }
        }
    }
}
