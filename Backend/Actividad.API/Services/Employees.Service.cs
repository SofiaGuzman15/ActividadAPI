using Actividad.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Actividad.API.Services
{
    public class EmployeesService
    {
        private readonly AppDbContext _context;

        public EmployeesService(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Employees> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void RegistrarEmployee(Employees employees)
        {
            _context.Employees.Add(employees);
            _context.SaveChanges();
        }
    }
}
