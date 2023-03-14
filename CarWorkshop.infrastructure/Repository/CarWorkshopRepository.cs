using CarWorkshop.Domain.Interfaces;
using CarWorkshop.infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.infrastructure.Repository 
    {
    internal class CarWorkshopRepository : ICarWorkshopRepository {
        private readonly CarWorkshopeDBContext _dbContext;

        public CarWorkshopRepository(CarWorkshopeDBContext dbContext) {
            _dbContext = dbContext;
        }


        public async Task Create(Domain.Entities.CarWorkshop carWorkshop) 
        {
            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync();
        }
    }
}
