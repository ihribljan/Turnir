using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnir
{
    public partial class Igraci
    {
        public string PrezimeIme
        {
            get
            {
                return string.Join(" ", Prezime, Ime);
            }
            set { }
        }

    }
}
