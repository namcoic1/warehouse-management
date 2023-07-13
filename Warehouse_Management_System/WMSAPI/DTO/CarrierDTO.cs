﻿using System.ComponentModel.DataAnnotations;

namespace WMSAPI.DTO
{
    public class CarrierDTO
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        public string? Address { get; set; }
        [StringLength(12, MinimumLength = 10)]
        public string? ContactNumber { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
