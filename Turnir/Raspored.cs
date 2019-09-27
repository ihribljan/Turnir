using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Turnir
{
    public partial class Raspored : Form
    {
        public Raspored()
        {
            InitializeComponent();
        }

        private void FormaRaspored_Load(object sender, EventArgs e)
        {
            PrikaziRaspored();
            //PopuniStrijelce();
        }

        public void PrikaziRaspored()
        {
            using (var db = new TurnirEntities2())
            {
                var upitRaspored = (from item in db.Rasporedi
                                    join c in db.Ekipe on item.EkipeIdDomacin equals c.Id
                                    join b in db.Ekipe on item.EkipeIdGost equals b.Id
                                    join a in db.Grupe on c.GrupeId equals a.Id
                                    select new 
                                    {
                                        Id = item.Id,
                                        Vrijeme = item.Vrijeme,
                                        Grupa = item.Grupe.Naziv,
                                        Domacin = c.Naziv,
                                        Gost = b.Naziv,
                                        Rezultat = item.GoloviDomacin + ":" + item.GoloviGost,
                                        Odigrano = item.Odigrano
                                     }
                                     );

                dgvFormaRaspored.DataSource = upitRaspored.ToList();
                DataGridViewColumn id = dgvFormaRaspored.Columns["Id"];
                id.Width = 60;
                DataGridViewColumn vrijeme = dgvFormaRaspored.Columns["Vrijeme"];
                vrijeme.Width = 70;
                DataGridViewColumn grupa = dgvFormaRaspored.Columns["Grupa"];
                grupa.Width = 70;
                DataGridViewColumn domacin = dgvFormaRaspored.Columns["Domacin"];
                domacin.Width = 130;
                DataGridViewColumn gost = dgvFormaRaspored.Columns["Gost"];
                gost.Width = 130;
            }
        }

        public void PopuniStrijelce()
        {
            using (var db = new TurnirEntities2())
            {
                var upitStrijelci = (from it in db.Igraci
                                     orderby it.Prezime ascending
                                     select it);

                if (upitStrijelci != null)
                {
                    cmbStrijelci.DataSource = upitStrijelci.ToList<Igraci>();
                    cmbStrijelci.ValueMember = "Id";
                    cmbStrijelci.DisplayMember = "PrezimeIme";
                }
            }
        }

        public void BrisiUtakmicu(int brojUtakmice)
        {
            if (dgvFormaRaspored.CurrentRow != null)
            {
                brojUtakmice = Convert.ToInt32(txtUtakmicaBroj.Text);
                if (MessageBox.Show("Jeste li sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                { 
                    using (var db = new TurnirEntities2())
                    {
                        var upit = (from item in db.Rasporedi
                                    where item.Id == brojUtakmice
                                    select item).FirstOrDefault();

                        db.Rasporedi.Remove(upit);
                        db.SaveChanges();
                    }
                }
            }
        }

        public void UpdateStrijelca()
        {
            using (var db = new TurnirEntities2())
            {
                var upit = (from item in db.Igraci
                           where item.Id == ((Igraci)cmbStrijelci.SelectedItem).Id
                           select item);


                /*Igraci i = new Igraci();
                i = cmbStrijelci.SelectedItem as Igraci;

                Console.WriteLine("RR " + i.PrezimeIme);*/

                /*Igraci i = upit.First();

                if(txtGrupa.Text == "A" || txtGrupa.Text == "B" || txtGrupa.Text == "C" || txtGrupa.Text == "D")
                {
                    i.BrojGolovaGrupa += 1;
                }
                else
                {
                    i.BrojGolovaKnockout += 1;
                }
                db.SaveChanges();*/
            }
        }

        public void PromjenaRezultata()
        {
            int idUtakmice = Convert.ToInt32(txtUtakmicaBroj.Text);

            using (var db = new TurnirEntities2())
            {
                var upit = (from item in db.Rasporedi
                            where idUtakmice == item.Id
                            select item).ToList<Rasporedi>();

                Rasporedi r = upit.FirstOrDefault();
                r.GoloviDomacin = Convert.ToInt32(txtGoloviDomacin.Text);
                r.GoloviGost = Convert.ToInt32(txtGoloviGost.Text);
                db.SaveChanges();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            PromjenaRezultata();
            UpdateStrijelca();
            MessageBox.Show("Izmjena uspješno obavljena!");
            PrikaziRaspored();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajUtakmicu f = new DodajUtakmicu();
            f.ShowDialog();
        }

        private void dgvFormaRaspored_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFormaRaspored.Rows[e.RowIndex];
                {
                    txtUtakmicaBroj.ReadOnly = true;
                    txtUtakmicaBroj.Text = row.Cells["Id"].Value.ToString();
                    txtVrijeme.Text = row.Cells["Vrijeme"].Value.ToString();
                    txtGrupa.Text = row.Cells["Grupa"].Value.ToString();
                    txtDomacin.Text = row.Cells["Domacin"].Value.ToString();
                    txtGost.Text = row.Cells["Gost"].Value.ToString();
                    string rezultat = row.Cells["Rezultat"].Value.ToString();
                    string[] substring = rezultat.Split(':');
                    txtGoloviDomacin.Text = substring.First();
                    txtGoloviGost.Text = substring.Last();
                }

                int IdUtakmice = Convert.ToInt32(txtUtakmicaBroj.Text);
                Console.WriteLine("UTAKMICA BR; " + IdUtakmice);
                
                using (var db = new TurnirEntities2())
                {
                    var utakmice = from item in db.Rasporedi
                                   where item.Id == IdUtakmice
                                   select item;

                    Rasporedi rasporedi = utakmice.First();

                    var domaciIgraci = (from it in db.Igraci
                                        where it.EkipeId == rasporedi.EkipeIdDomacin
                                        select it).ToList<Igraci>();

                    var gostIgraci = (from i in db.Igraci
                                      where i.EkipeId == rasporedi.EkipeIdGost
                                      select i).ToList<Igraci>();

                    List<string> listaIgraca = new List<string>();

                    foreach (var item in domaciIgraci)
                    {
                        listaIgraca.Add(item.PrezimeIme);
                    }

                    foreach (var it in gostIgraci)
                    {
                        listaIgraca.Add(it.PrezimeIme);
                    }

                    listaIgraca.Sort();
                    cmbStrijelci.DataSource = listaIgraca;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrisiUtakmicu(Convert.ToInt32(txtUtakmicaBroj.Text));
            MessageBox.Show("Utakmica uspješno obrisana!");
            PrikaziRaspored();
        }

        public void PocetakUtakmice()
        {
            int idUtakmice = Convert.ToInt32(txtUtakmicaBroj.Text);

            using (var ctx = new TurnirEntities2())
            {
                var upit = (from item in ctx.Rasporedi
                            where item.Id == idUtakmice
                            select item).ToList<Rasporedi>();

                Rasporedi r = upit.FirstOrDefault();
                r.Odigrano = "LIVE";
                ctx.SaveChanges();
            }
        }

        public void KrajUtakmice()
        {
            int idUtakmice = Convert.ToInt32(txtUtakmicaBroj.Text);

            using (var ctx = new TurnirEntities2())
            {
                var upit = (from item in ctx.Rasporedi
                            where item.Id == idUtakmice
                            select item).ToList<Rasporedi>();

                Rasporedi r = upit.FirstOrDefault();
                r.Odigrano = "DA";
                ctx.SaveChanges();
            }
        }

        private void btnPocetakUtakmice_Click(object sender, EventArgs e)
        {
            PocetakUtakmice();
            PrikaziRaspored();
        }

        private void btnKrajUtakmice_Click(object sender, EventArgs e)
        {
            KrajUtakmice();
            PrikaziRaspored();
            AzurirajTablicu(txtDomacin.Text, txtGost.Text);
            MessageBox.Show("Utakmica završena! Tablica ažurirana!");
        }

        private void dgvFormaRaspored_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFormaRaspored.Rows[e.RowIndex];
                foreach (DataGridViewRow item in dgvFormaRaspored.Rows)
                {
                    string odigrano = row.Cells["Odigrano"].Value.ToString();
                    if (odigrano == "LIVE")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else if (odigrano == "DA")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        public void AzurirajTablicu(string domacin, string gost)
        {
            int utakmica = Convert.ToInt32(txtUtakmicaBroj.Text);
            int azurirano = 0;

            using (var db = new TurnirEntities2())
            {
                var upit = (from it in db.Rasporedi
                            where utakmica == it.Id
                            select it);

                Rasporedi rasporedi = upit.First();
                Console.WriteLine(upit);
                rasporedi.Id = utakmica;
                Console.WriteLine(rasporedi.Id);
                azurirano = (int)rasporedi.ažurirano;
                Console.WriteLine(rasporedi.ažurirano);
                Console.WriteLine("TEST");

                if (azurirano == 1)
                {
                    MessageBox.Show("Utakmica je već ažurirana!");
                }
                else
                {
                    var upitDomacin = (from item in db.Ekipe
                                        where item.Naziv == domacin
                                        select item);

                    var upitGost = (from item in db.Ekipe
                                    where item.Naziv == gost
                                    select item);

                    Ekipe doma = upitDomacin.First();
                    Ekipe gos = upitGost.First();

                    doma.OdigraneUtakmice += 1;
                    gos.OdigraneUtakmice += 1;

                    doma.PostignutiGolovi += Convert.ToInt32(txtGoloviDomacin.Text);
                    doma.PrimljeniGolovi += Convert.ToInt32(txtGoloviGost.Text);

                    gos.PostignutiGolovi += Convert.ToInt32(txtGoloviGost.Text);
                    gos.PrimljeniGolovi += Convert.ToInt32(txtGoloviDomacin.Text);

                    doma.GolRazlika = doma.PostignutiGolovi - doma.PrimljeniGolovi;
                    gos.GolRazlika = gos.PostignutiGolovi - gos.PrimljeniGolovi;

                    if (doma.PostignutiGolovi > gos.PostignutiGolovi)
                    {
                        doma.Pobjede += 1;
                        doma.Bodovi += 3;
                        gos.Porazi += 1;
                    }
                    else if (doma.PostignutiGolovi < gos.PostignutiGolovi)
                    {
                        gos.Pobjede += 1;
                        gos.Bodovi += 3;
                        doma.Porazi += 1;
                    }
                    else if (doma.PostignutiGolovi == gos.PostignutiGolovi)
                    {
                        doma.Neriješeno += 1;
                        gos.Neriješeno += 1;
                        doma.Bodovi += 1;
                        gos.Bodovi += 1;
                    }

                    rasporedi.ažurirano = 1;
                    MessageBox.Show("Tablica ažurirana!");

                    db.SaveChanges();
                }
            }
        }

        public void Azuriraj()
        {
            string html = String.Empty;

            html += "<html>" +
                    "<head>" +
                    "<title> Raspored </title>" +
                    "</head>" +
                    "<body>" +
                    "<div style = float:center; width:30%" +
                    "<table style = border: 2px solid #ccc; border-collapse: collapse;>" +
                    "<tr>" +
                    "<td> &nbsp VRIJEME </td>" +
                    "<td> &nbsp &nbsp GRUPA </td>" +
                    "<td> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp DOMACIN </td>" +
                    "<td> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp GOST </td>" +
                    "<td> &nbsp &nbsp &nbsp &nbsp &nbsp REZULTAT </td>" +
                    "</tr>" +
                    "<tr>" +
                    "<br>" +
                    "-------------------------------------------------------------------------------" +
                    "</br>" +
                    "</tr>";
                                 
            using (var db = new TurnirEntities2())
            {
                var upit = from item in db.Rasporedi
                           select item;

                foreach (var red in upit)
                {
                    int domacinId = (int)red.EkipeIdDomacin;
                    int gostId = (int)red.EkipeIdGost;

                    Console.WriteLine("\n!!" + domacinId + " " + gostId);

                    var domacin = (from i in db.Ekipe
                                   where domacinId == i.Id
                                   select i).ToList<Ekipe>();

                    var gost = (from i in db.Ekipe
                                where gostId == i.Id
                                select i).ToList<Ekipe>();

                    Ekipe ekipeDomacin = domacin.FirstOrDefault();
                    Ekipe ekipeGost = gost.FirstOrDefault();

                    html += "<tr>" +
                            "<td>" + "&nbsp &nbsp &nbsp &nbsp" + red.Vrijeme + "&nbsp &nbsp &nbsp &nbsp" + "</td>" +
                            "<td>" + "&nbsp &nbsp &nbsp" + red.Grupe.Naziv + "&nbsp" + "</td>" +
                            "<td>" + "&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp" + ekipeDomacin.Naziv + "&nbsp" + "</td>" +
                            "<td>" + "&nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp" + ekipeGost.Naziv + "&nbsp" + "</td>" +
                            "<td>" + "&nbsp &nbsp &nbsp &nbsp" + red.GoloviDomacin + ":" + red.GoloviGost + "&nbsp" + "</td>" +
                            "</tr>" +
                            "<br>" +
                            "</br>";
                    
                    System.IO.File.WriteAllText(@"F:\NK Croatia '78\turnir\dat.html", html);
                }

                html += "</table>" + "</div>" + "</body>" + "</html>";

                System.IO.File.WriteAllText(@"F:\NK Croatia '78\turnir\dat.html", html);

                Console.WriteLine(html);
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Azuriraj();
            MessageBox.Show("Utakmica ažurirana!");
        }
    }
}
