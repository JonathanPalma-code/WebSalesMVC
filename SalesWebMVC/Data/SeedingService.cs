using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || 
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department department1 = new Department(1, "Gaming");
            Department department2 = new Department(2, "PCs");
            Department department3 = new Department(3, "MacBooks");
            Department department4 = new Department(4, "Accessories");

            Seller seller1 = new Seller(1, "Jonathan", "jonathan@example.com", new DateTime(1989, 10, 10), 1500, department2);
            Seller seller2 = new Seller(2, "Williams", "williams@example.com", new DateTime(1989, 01, 06), 1400, department4);
            Seller seller3 = new Seller(3, "Maria", "maria@example.com", new DateTime(1985, 04, 23), 1690, department3);
            Seller seller4 = new Seller(4, "Joana", "joana@example.com", new DateTime(1992, 01, 10), 1200, department2);

            SalesRecord salesRecord1 = new SalesRecord(1, new DateTime(2020, 02, 01), 299.99, SaleStatus.Billed, seller4);
            SalesRecord salesRecord2 = new SalesRecord(2, new DateTime(2020, 02, 01), 120.99, SaleStatus.Billed, seller4);
            SalesRecord salesRecord3 = new SalesRecord(3, new DateTime(2020, 02, 03), 699.99, SaleStatus.Billed, seller2);
            SalesRecord salesRecord4 = new SalesRecord(4, new DateTime(2020, 02, 04), 1099.99, SaleStatus.Billed, seller3);
            SalesRecord salesRecord5 = new SalesRecord(5, new DateTime(2020, 02, 01), 299.99, SaleStatus.Billed, seller4);
            SalesRecord salesRecord6 = new SalesRecord(6, new DateTime(2020, 02, 01), 1120.99, SaleStatus.Billed, seller4);
            SalesRecord salesRecord7 = new SalesRecord(7, new DateTime(2020, 02, 03), 699.99, SaleStatus.Billed, seller2);
            SalesRecord salesRecord8 = new SalesRecord(8, new DateTime(2020, 02, 04), 1599.99, SaleStatus.Billed, seller1);
            SalesRecord salesRecord9 = new SalesRecord(9, new DateTime(2020, 02, 01), 299.99, SaleStatus.Billed, seller1);
            SalesRecord salesRecord10 = new SalesRecord(10, new DateTime(2020, 02, 01), 2120.99, SaleStatus.Billed, seller4);
            SalesRecord salesRecord11 = new SalesRecord(11, new DateTime(2020, 02, 03), 3699.99, SaleStatus.Billed, seller3);
            SalesRecord salesRecord12 = new SalesRecord(12, new DateTime(2020, 02, 04), 1099.99, SaleStatus.Billed, seller2);

            _context.Department.AddRange(department1, department2, department3, department4);
            _context.Seller.AddRange(seller1, seller2, seller3, seller4);
            _context.SalesRecord.AddRange(
                salesRecord1, salesRecord2, salesRecord3, salesRecord4,
                salesRecord5, salesRecord6, salesRecord7, salesRecord8, 
                salesRecord9, salesRecord10, salesRecord11, salesRecord12
                );

            _context.SaveChanges();
        }
    }
}
