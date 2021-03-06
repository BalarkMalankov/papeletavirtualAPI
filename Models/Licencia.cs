﻿using System;
using System.Collections.Generic;

namespace papeletavirtualapp.Models
{
    public partial class Licencia
    {
        public int Id { get; set; }
        public string NumLicencia { get; set; }
        public string Class { get; set; }
        public string Category { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Restriction { get; set; }
        public int? IdInfractor { get; set; }

        public virtual Infractor IdInfractorNavigation { get; set; }
    }
}
