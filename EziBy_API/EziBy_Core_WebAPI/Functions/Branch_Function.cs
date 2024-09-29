using EziBy_Core_ClassLibrary.Models;
using EziBy_Core_WebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EziBy_Core_WebAPI.Functions
{
    public class Branch_Function(EziByDbContext dbContext)
    {
        public Branch GetBranch(int Id)
        {
            Branch branch = new Branch();

            try
            {
                branch = dbContext.Branches
                .Where(e => e.BranchId == Id)
                .Where(e => e.Active)
                .First();
            }
            catch (Exception)
            {

            }

            return branch;
        }

        public List<Branch> GetBranches(bool isActive)
        {
            List<Branch> branches = new List<Branch>();

            try
            {
                branches = dbContext.Branches
                .Where(e => e.Active == isActive)
                .ToList();
            }
            catch (Exception)
            {

            }

            return branches;
        }
    }
}
