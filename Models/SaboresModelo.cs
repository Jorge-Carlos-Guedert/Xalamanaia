using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SaboresModelo
    {
        public int IdSabores { get; set; }
        public string DescricaoSabor { get; set; }
        public decimal ValorBroto { get; set; }

        public decimal ValorMedia { get; set; }

        public decimal ValorGrande { get; set; }

        public decimal ValorGigante { get; set; }
    }
}
