using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3_MascotaDB.Models;

namespace T3_MascotaDB.ViewModel
{
    public class MascotaViewModel
    {
        public Mascota FormMascota { get; set; }
        public IEnumerable<Mascota> ListMascota { get; set; }
    }
}
