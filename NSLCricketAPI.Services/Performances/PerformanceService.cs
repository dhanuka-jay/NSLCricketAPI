using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSLCricketAPI.DataAccess;
using NSLCricketAPI.Models;

namespace NSLCricketAPI.Services.Performances
{
    public class PerformanceService : IPerformanceRepository
    {
        private protected NSLDbContext _context = new NSLDbContext();

        public List<Performance> GetAllPerformances()
        {
            var performances =  _context.Performances.ToList();
            return performances;
        }

        public Performance GetPerformance(int id)
        {
            var performance = _context.Performances.Find(id);
            return performance;
        }
    }
}
