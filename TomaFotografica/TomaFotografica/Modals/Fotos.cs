using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TomaFotografica.Modals
{
    public class Fotos
    {

        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(20)]
        public string nombre { get; set; }

        [MaxLength(250)]
        public string descripcion { get; set; }
    }
}
