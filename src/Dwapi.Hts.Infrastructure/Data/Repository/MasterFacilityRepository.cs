﻿using System.Collections.Generic;
using System.Linq;
using Dwapi.Hts.Core.Domain;
using Dwapi.Hts.Core.Interfaces.Repository;
using Dwapi.Hts.SharedKernel.Infrastructure.Data;

namespace Dwapi.Hts.Infrastructure.Data.Repository
{
    public class MasterFacilityRepository:BaseRepository<MasterFacility,int>, IMasterFacilityRepository
    {
        public MasterFacilityRepository(HtsContext context) : base(context)
        {
        }

        public MasterFacility GetBySiteCode(int siteCode)
        {
            return DbSet.Find(siteCode);
        }

        public List<MasterFacility> GetLastSnapshots(int siteCode)
        {
            return DbSet.Where(x =>  x.SnapshotSiteCode == siteCode)
                .ToList();
        }
    }
}
