using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLodgeBook.DTO
{
    public class Chambre
    {
        public int? Id { get; set; }
        public string Numero { get; set; }
        public string Nom { get; set; }
        public int NombreLitsSimples { get; set; }
        public int NombreLitsDoubles { get; set; }
        public bool Fumeur { get; set; }
        public bool Animaux { get; set; }
    }
}
