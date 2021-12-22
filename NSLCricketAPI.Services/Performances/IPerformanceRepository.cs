using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSLCricketAPI.Models;

namespace NSLCricketAPI.Services.Performances
{
    public interface IPerformanceRepository
    {
        public List<Performance> GetAllPerformances();

        public Performance GetPerformance(int id);
    }
}
