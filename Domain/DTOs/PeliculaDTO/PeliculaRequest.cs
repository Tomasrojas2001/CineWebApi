﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.PeliculaDTO
{
    public class PeliculaRequest
    {
        public string Titulo { get; set; }
        public string Poster { get; set; }
        public string Trailer { get; set; }
        public string Sinopsis { get; set; }
        
    }
}
