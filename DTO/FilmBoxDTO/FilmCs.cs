using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FilmBoxDTO
{
    public class FilmCs
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public int Views { get; set; }
        public int Vote { get; set; }
        public decimal FilmDuration { get; set; }
        public DateTime DateOfConstruction { get; set; }
        public string Language { get; set; }
        public decimal FilmEndorsement { get; set; }
        public bool Status { get; set; }
        public string images { get; set; }

    }
}
