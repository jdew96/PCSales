﻿using System;
using System.Collections.Generic;
using System.Linq;
using PcSales.Models.Interfaces;

namespace PcSales.Models.Repositories
{
    public class PartSpecRepository : IPartSpecRespository
    {
        private readonly AppDbContext _context;

        public PartSpecRepository(AppDbContext context)
        {
            _context = context;
        }

        public int AddCaseSpec(CaseSpec spec)
        {
            _context.CaseSpec.Add(spec);
            return _context.SaveChanges();
        }


        public IEnumerable<CaseSpec> GetAllCaseSpecs()
        {
            List<CaseSpec> specs = _context.CaseSpec.ToList();
            return specs;
        }

        public CaseSpec GetCaseSpec(int partNum)
        {
            return _context.CaseSpec.FirstOrDefault(s => s.PartNum == partNum);
        }

          //CpuSpec
          public int AddCpuSpec(CpuSpec spec)
          {
               _context.CpuSpec.Add(spec);
               return _context.SaveChanges();
          }


          public IEnumerable<CpuSpec> GetAllCpuSpecs()
          {
               List<CpuSpec> specs = _context.CpuSpec.ToList();
               return specs;
          }

          public CpuSpec GetCpuSpec(int partNum)
          {
               return _context.CpuSpec.FirstOrDefault(s => s.PartNum == partNum);
          }

          //GpuSpec
          public int AddGpuSpec(GpuSpec spec)
          {
               _context.GpuSpec.Add(spec);
               return _context.SaveChanges();
          }


          public IEnumerable<GpuSpec> GetAllGpuSpecs()
          {
               List<GpuSpec> specs = _context.GpuSpec.ToList();
               return specs;
          }

          public GpuSpec GetGpuSpec(int partNum)
          {
               return _context.GpuSpec.FirstOrDefault(s => s.PartNum == partNum);
          }

          //MoboSpec
          public int AddMoboSpec(MoboSpec spec)
          {
               _context.MoboSpec.Add(spec);
               return _context.SaveChanges();
          }


          public IEnumerable<MoboSpec> GetAllMoboSpecs()
          {
               List<MoboSpec> specs = _context.MoboSpec.ToList();
               return specs;
          }

          public MoboSpec GetMoboSpec(int partNum)
          {
               return _context.MoboSpec.FirstOrDefault(s => s.PartNum == partNum);
          }

          //PsuSpec
          public int AddPsuSpec(PsuSpec spec)
          {
               _context.PsuSpec.Add(spec);
               return _context.SaveChanges();
          }


          public IEnumerable<PsuSpec> GetAllPsuSpecs()
          {
               List<PsuSpec> specs = _context.PsuSpec.ToList();
               return specs;
          }

          public PsuSpec GetPsuSpec(int partNum)
          {
               return _context.PsuSpec.FirstOrDefault(s => s.PartNum == partNum);
          }

          //RamSpec
          public int AddRamSpec(RamSpec spec)
          {
               _context.RamSpec.Add(spec);
               return _context.SaveChanges();
          }


          public IEnumerable<RamSpec> GetAllRamSpecs()
          {
               List<RamSpec> specs = _context.RamSpec.ToList();
               return specs;
          }

          public RamSpec GetRamSpec(int partNum)
          {
               return _context.RamSpec.FirstOrDefault(s => s.PartNum == partNum);
          }

          //StorageSpec
          public int AddStorageSpec(StorageSpec spec)
          {
               _context.StorageSpec.Add(spec);
               return _context.SaveChanges();
          }


          public IEnumerable<StorageSpec> GetAllStorageSpecs()
          {
               List<StorageSpec> specs = _context.StorageSpec.ToList();
               return specs;
          }

          public StorageSpec GetStorageSpec(int partNum)
          {
               return _context.StorageSpec.FirstOrDefault(s => s.PartNum == partNum);
          }
     }
}