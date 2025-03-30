﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCRUDMusic.Models.Entities
{
    public class Track
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public TimeSpan Duration { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
