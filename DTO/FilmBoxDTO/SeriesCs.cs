using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FilmBoxDTO
{
    public class SeriesCs
    {
        public int SeriesId { get; set; }
        public string SeriesName { get; set; }
        public int Views { get; set; }
        public int Vote { get; set; }
        public decimal SeriesDuration { get; set; }
        public DateTime DateOfConstruction { get; set; }
        public string Language { get; set; }
        public decimal SeriesEndorsement { get; set; }
        public bool Status { get; set; }

        public string images { get; set; }



    }
}
