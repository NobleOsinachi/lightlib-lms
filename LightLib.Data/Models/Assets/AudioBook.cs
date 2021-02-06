﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LightLib.Data.Models.Assets {
    public class AudioBook {
        [Key] public int Id { get; set; }
        [Required] public Guid AssetId { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Author { get; set; }
        [Required] public string ISBN { get; set; }
        public int PublicationYear { get; set; } 
        public int NumberOfDiscs { get; set; }
        public int LengthMinutes { get; set; }
        public string Edition { get; set; }
        public string Publisher { get; set; }
        public string DeweyIndex { get; set; }
        public string Language { get; set; }
        public string Summary { get; set; }
        public List<Tag>  Tags { get; set; }
    }
}