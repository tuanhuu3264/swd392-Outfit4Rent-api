﻿using SWD392.OutfitBox.Core.Models.Requests.Package;
using SWD392.OutfitBox.Core.Models.Responses.Package;
using SWD392.OutfitBox.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD392.OutfitBox.Core.Services.PackageService
{
    public interface IPackageService
    {
        public Task<List<PackageDTO>> GetAllEnabledPackages();
        public Task<List<PackageDTO>> GetAllPackages();
        public Task<CreatePackageResponseDTO> CreatePackage(CreatePackageRequestDTO package);
        public Task<UpdatePackageResponseDTO> UpdatePackage(UpdatePackageRequestDTO package);
        public Task<PackageDTO> ActiveOrDeactivePackageById(int id);

    }
}
