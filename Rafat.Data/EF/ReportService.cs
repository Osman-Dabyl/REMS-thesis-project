using Rafat.Data.ReportsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Rafat.Core.Enums.Oreder_Type;
using static Rafat.Core.Enums.Order_Status;
using System.Formats.Asn1;
using Rafat.Core;
using static Rafat.Core.Enums.Listing_Type;
using static Rafat.Core.Enums.Property_Type;

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

        public async Task<List<AgentPerformanceReport>> GetAgentPerformanceReportAsync(int id)
        {
            return await _context.Agents.Where(a=> a.AgentId == id)
                .Select(agent => new AgentPerformanceReport
                {
                    AgentName = agent.FullName,
                    TotalSales = agent.Properties.Count(p => p.Orders.Any(o => o.Ordertype == OrderType.Purchase)),
                    TotalProperties = agent.Properties.Count,
                    TotalRentals = agent.Properties.Count(p => p.Orders.Any(o => o.Ordertype == OrderType.Rent))
                }).ToListAsync();
        }

        public async Task<List<SalesReport>> GetSalesReportsAsync(DateTime fromdate, DateTime todate) => await _context.Orders.Where(x => x.OrderDate >= fromdate
        && x.OrderDate <= todate
        && x.Status == OrderStatus.Accepted)
            .Select(order => new SalesReport
            {

                PropId = order.PropertyId,
                SalePrice = (double)order.SalePrice,
                BuyerInfo = order.Customer.FullName,
                SallerInfo = _context.Users.Where(x => x.UserId == order.UserId).Select(x => x.UserName).FirstOrDefault(),
                SaleDate = order.OrderDate

            }).ToListAsync();



        public async Task<List<PropertyReport>> GetPropertyReport(ListingType type) => await _context.Properties
            .Where(p => p.Status == Core.Enums.Property_Stutus.PropertyStatus.Available && p.Listing == type)
            .Select(prop => new PropertyReport
            {
                Propid = prop.PropertyId,
                Price = prop.Price,
                addedDate = prop.AddedDate,
                AgentInfo = prop.Agent.FullName,
                Linsting = prop.Listing,
                Ptype = prop.PType.ToString(),
                UserName = _context.Users.Where(x => x.UserId == prop.UserId).Select(x => x.UserName).FirstOrDefault(),

            }).ToListAsync();


    }

}
