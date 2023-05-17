using DPA.SHOPPING.DOMAIN.Core.Entities;

namespace DPA.SHOPPING.DOMAIN.Core.Interfaces
{
    public interface IFavoriteRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Favorite>> GetAll();
        Task<Favorite> GetById(int id);
        Task<bool> Insert(Favorite favorite);
        Task<bool> Update(Favorite favorite);
    }
}