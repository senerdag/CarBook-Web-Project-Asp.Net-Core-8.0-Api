using CarBook.Application.Interfaces.RentACarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepositories : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepositories(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<RentACar>> GetByFilerAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values=await _context.RentACars.Where(filter).Include(y=>y.Car).ThenInclude(x=>x.Brand).ToListAsync();
            return values;
        }
    }
}
