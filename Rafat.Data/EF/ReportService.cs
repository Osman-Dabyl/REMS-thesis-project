using Rafat.Data.ReportsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Rafat.Core.Enums.Oreder_Type;

namespace Rafat.Data.EF
{
    public class ReportService
    {
        private readonly DBContext _context;

        public ReportService(DBContext context)
        {
            _context = context;
        }

        public async Task<List<AgentPerformanceReport>> GetAgentPerformanceReportAsync()
        {
            return await _context.Agents
                .Select(agent => new AgentPerformanceReport
                {
                    AgentName = agent.FullName,
                    TotalSales = agent.Properties.Count(p => p.Orders.Any(o => o.Ordertype == OrderType.Purchase)),
                    TotalProperties = agent.Properties.Count,
                    TotalRentals = agent.Properties.Count(p => p.Orders.Any(o => o.Ordertype == OrderType.Rent))
                }).ToListAsync();
        }


    }

}
