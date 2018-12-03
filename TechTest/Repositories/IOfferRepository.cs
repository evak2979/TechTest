using System.Threading.Tasks;
using TechTest.Dto;

namespace TechTest.Repositories
{
    public interface IOfferRepository<T> where T : OfferDtoBase
    {
        Task Insert(T aggregate);

        Task Update(T aggregate);

        Task<T> GetById(int id);
    }
}