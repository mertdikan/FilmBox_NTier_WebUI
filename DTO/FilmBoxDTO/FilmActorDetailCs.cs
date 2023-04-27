using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.FilmBoxDTO
{
    public class FilmActorDetailCs
    {
        public int FilmActorDetailID { get; set; }
        public int FilmId { get; set; }
        public int ActorId { get; set; }
        public string Role { get; set; }
        public int ActorRate { get; set; }

    }
}
