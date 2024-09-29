using EziBy_Core_ClassLibrary.Models;
using EziBy_Core_WebAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EziBy_Core_WebAPI.Functions
{
    public class Setup_Function(EziByDbContext dbContext)
    {
        public Setup GetSetup(int Id)
        {
            Setup setup = new Setup();

            try
            {
                setup = dbContext.Setups
                .Where(e => e.SetupId == Id)
                .Where(e => e.Active)
                .First();
            }
            catch (Exception)
            {

            }

            return setup;
        }

        public List<Setup> GetSetups(bool isActive, int BranchId)
        {
            List<Setup> setups = new List<Setup>();

            try
            {
                setups = dbContext.Setups
                .Where(e => e.BranchId == BranchId)
                .Where(e => e.Active == isActive)
                .ToList();
            }
            catch (Exception)
            {

            }

            return setups;
        }
    }
}
