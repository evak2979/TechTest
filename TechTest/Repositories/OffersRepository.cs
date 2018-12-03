using System.Linq;
using System.Threading.Tasks;
using LiteDB;
using TechTest.Data;
using TechTest.Dto;

namespace TechTest.Repositories
{
    public class OffersRepository<T> : IOfferRepository<T> where T : OfferDtoBase
    {
        public async Task Insert(T offerMessage)
        {
            using (var db = new LiteDatabase(Database.Name))
            {
                var offers = db.GetCollection<T>(Database.OffersTableName);
                await Task.Run(() => offers.Insert(offerMessage));
            }
        }

        public async Task Update(T offerMessage)
        {
            using (var db = new LiteDatabase(Database.Name))
            {
                var offers = db.GetCollection<T>(Database.OffersTableName);
                await Task.Run(() => offers.Update(offerMessage));
            }
        }

        public async Task<T> GetById(int id)
        {
            using (var db = new LiteDatabase(Database.Name))
            {
                var offers = db.GetCollection<T>(Database.OffersTableName);
                return await Task.Run(() => offers.Find(x => x.Id == id).FirstOrDefault());
            }
        }
    }
}