﻿using Music.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Domain.Dto
{
    public class PlaylistResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
    }
}
