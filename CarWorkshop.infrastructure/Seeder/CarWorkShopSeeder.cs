using CarWorkshop.infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.infrastructure.Seeder
{
    public class CarWorkShopSeeder
    {
        private readonly CarWorkshopeDBContext _dBContext;

        public CarWorkShopSeeder(CarWorkshopeDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task Seed()
        {
            if (await _dBContext.Database.CanConnectAsync())
            {
                if (!_dBContext.carWorkshops.Any())
                {
                    var mazdaAso = new Domain.Entities.CarWorkshop()
                    {
                        Name = "Mazda AASO",
                        Description = "Autoryzowany serwis Maza",
                        ContactDetails = new()
                        {
                            City = "Częstochowa",
                            Street = "Kasztanowa 2",
                            PhoneNumber = "12312323",
                            PostCode = "42-200",
                            Email = "czestochowa@mazda.pl"

                        }
                    };
                    mazdaAso.EncodeName();
                    _dBContext.carWorkshops.Add(mazdaAso);
                    await _dBContext.SaveChangesAsync();
                }
            }
        }
    }
}
