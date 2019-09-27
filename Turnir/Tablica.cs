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
    public partial class Tablica : Form
    {
        public Tablica()
        {
            InitializeComponent();
        }

        private void Tablica_Load(object sender, EventArgs e)
        {
            ListaStrijelaca();
            AGrupa();
            BGrupa();
            CGrupa();
            DGrupa();
        }

        public void ListaStrijelaca()
        {
            using (var db = new TurnirEntities2())
            {
                var upitStrijelci = (from item in db.Igraci
                                     orderby item.BrojGolovaKnockout descending
                                     where item.BrojGolovaKnockout > 0 || item.BrojGolovaGrupa > 0
                                     orderby item.BrojGolovaKnockout descending
                                     orderby item.BrojGolovaGrupa descending
                                     select new
                                     {
                                         Ime = item.Ime,
                                         Prezime = item.Prezime,
                                         Ekipa = item.Ekipe.Naziv,
                                         //Golovi_Grupa = item.BrojGolovaGrupa,
                                         Golovi_Knockout = item.BrojGolovaKnockout
                                     }
                                     );

                dgvStrijelci.RowHeadersVisible = false;
                dgvStrijelci.DataSource = upitStrijelci.ToList();
                DataGridViewColumn ime = dgvStrijelci.Columns["Ime"];
                ime.Width = 100;
                DataGridViewColumn prezime = dgvStrijelci.Columns["Prezime"];
                prezime.Width = 100;
                DataGridViewColumn ekipa = dgvStrijelci.Columns["Ekipa"];
                ekipa.Width = 150;
                //DataGridViewColumn goloviGrupa = dgvStrijelci.Columns["Golovi_Grupa"];
                //goloviGrupa.Width = 100;
                DataGridViewColumn goloviKnockout = dgvStrijelci.Columns["Golovi_Knockout"];
                goloviKnockout.Width = 100;
            }
        }

        public void AGrupa()
        {
            using (var db = new TurnirEntities2())
            {
                var upitA = (from it in db.Ekipe
                             where it.GrupeId == 1
                             orderby it.Bodovi descending
                             orderby it.GolRazlika descending
                             select new
                                   {
                                       Naziv = it.Naziv,
                                       OU = it.OdigraneUtakmice,
                                       P = it.Pobjede,
                                       N = it.Neriješeno,
                                       I = it.Porazi,
                                       GR = it.GolRazlika,
                                       B = it.Bodovi
                                   }
                                   );

                dgvAGrupa.RowHeadersVisible = false;
                dgvAGrupa.DataSource = upitA.ToList();
                DataGridViewColumn naziv = dgvAGrupa.Columns["Naziv"];
                naziv.Width = 140;
                DataGridViewColumn odigraneUtakmice = dgvAGrupa.Columns["OU"];
                odigraneUtakmice.Width = 40;
                DataGridViewColumn pobjede = dgvAGrupa.Columns["P"];
                pobjede.Width = 40;
                DataGridViewColumn neriješeno = dgvAGrupa.Columns["N"];
                neriješeno.Width = 40;
                DataGridViewColumn porazi = dgvAGrupa.Columns["I"];
                porazi.Width = 40;
                DataGridViewColumn golRazlika = dgvAGrupa.Columns["GR"];
                golRazlika.Width = 40;
                DataGridViewColumn bodovi = dgvAGrupa.Columns["B"];
                bodovi.Width = 40;
            }
        }

        public void BGrupa()
        {
            using (var db = new TurnirEntities2())
            {

                var upitB = (from it in db.Ekipe
                             where it.GrupeId == 2
                             orderby it.Bodovi descending
                             orderby it.GolRazlika descending
                             select new
                                   {
                                       Naziv = it.Naziv,
                                       OU = it.OdigraneUtakmice,
                                       P = it.Pobjede,
                                       N = it.Neriješeno,
                                       I = it.Porazi,
                                       GR = it.GolRazlika,
                                       B = it.Bodovi
                                   }
                                   );

                dgvBGrupa.RowHeadersVisible = false;
                dgvBGrupa.DataSource = upitB.ToList();
                DataGridViewColumn naziv = dgvBGrupa.Columns["Naziv"];
                naziv.Width = 140;
                DataGridViewColumn odigraneUtakmice = dgvBGrupa.Columns["OU"];
                odigraneUtakmice.Width = 40;
                DataGridViewColumn pobjede = dgvBGrupa.Columns["P"];
                pobjede.Width = 40;
                DataGridViewColumn neriješeno = dgvBGrupa.Columns["N"];
                neriješeno.Width = 40;
                DataGridViewColumn porazi = dgvBGrupa.Columns["I"];
                porazi.Width = 40;
                DataGridViewColumn golRazlika = dgvBGrupa.Columns["GR"];
                golRazlika.Width = 40;
                DataGridViewColumn bodovi = dgvBGrupa.Columns["B"];
                bodovi.Width = 40;
            }
        }

        public void CGrupa()
        {
            using (var db = new TurnirEntities2())
            {

                var upitC = (from it in db.Ekipe
                             where it.GrupeId == 3
                             orderby it.Bodovi descending
                             orderby it.GolRazlika descending
                             select new
                             {
                                 Naziv = it.Naziv,
                                 OU = it.OdigraneUtakmice,
                                 P = it.Pobjede,
                                 N = it.Neriješeno,
                                 I = it.Porazi,
                                 GR = it.GolRazlika,
                                 B = it.Bodovi
                             }
                                   );

                dgvCGrupa.RowHeadersVisible = false;
                dgvCGrupa.DataSource = upitC.ToList();
                DataGridViewColumn naziv = dgvCGrupa.Columns["Naziv"];
                naziv.Width = 140;
                DataGridViewColumn odigraneUtakmice = dgvCGrupa.Columns["OU"];
                odigraneUtakmice.Width = 40;
                DataGridViewColumn pobjede = dgvCGrupa.Columns["P"];
                pobjede.Width = 40;
                DataGridViewColumn neriješeno = dgvCGrupa.Columns["N"];
                neriješeno.Width = 40;
                DataGridViewColumn porazi = dgvCGrupa.Columns["I"];
                porazi.Width = 40;
                DataGridViewColumn golRazlika = dgvCGrupa.Columns["GR"];
                golRazlika.Width = 40;
                DataGridViewColumn bodovi = dgvCGrupa.Columns["B"];
                bodovi.Width = 40;
            }
        }

        public void DGrupa()
        {
            using (var db = new TurnirEntities2())
            {

                var upitD = (from it in db.Ekipe
                             where it.GrupeId == 4
                             orderby it.Bodovi descending
                             //orderby it.GolRazlika descending
                             select new
                             {
                                 Naziv = it.Naziv,
                                 OU = it.OdigraneUtakmice,
                                 P = it.Pobjede,
                                 N = it.Neriješeno,
                                 I = it.Porazi,
                                 GR = it.GolRazlika,
                                 B = it.Bodovi
                             }
                                   );

                dgvDGrupa.RowHeadersVisible = false;
                dgvDGrupa.DataSource = upitD.ToList();
                DataGridViewColumn naziv = dgvDGrupa.Columns["Naziv"];
                naziv.Width = 140;
                DataGridViewColumn odigraneUtakmice = dgvDGrupa.Columns["OU"];
                odigraneUtakmice.Width = 40;
                DataGridViewColumn pobjede = dgvDGrupa.Columns["P"];
                pobjede.Width = 40;
                DataGridViewColumn neriješeno = dgvDGrupa.Columns["N"];
                neriješeno.Width = 40;
                DataGridViewColumn porazi = dgvDGrupa.Columns["I"];
                porazi.Width = 40;
                DataGridViewColumn golRazlika = dgvDGrupa.Columns["GR"];
                golRazlika.Width = 40;
                DataGridViewColumn bodovi = dgvDGrupa.Columns["B"];
                bodovi.Width = 40;
            }
        }
    }
}
