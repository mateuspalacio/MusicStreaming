using Music.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Domain.Dto
{
    public class SongResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<Playlist> PlaylistsPartOf { get; set; }
    }
}
