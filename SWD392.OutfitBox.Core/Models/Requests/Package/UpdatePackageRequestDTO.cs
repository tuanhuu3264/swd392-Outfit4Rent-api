﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392.OutfitBox.Core.Models.Requests.Package
{
    public class UpdatePackageRequestDTO
    {
        public int Id;
        public double Price { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Status { get; set; }

        public CategoryPackageDTO[]? CategoryPackages { get; set; }
    }
}
