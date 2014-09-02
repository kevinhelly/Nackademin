using System.Linq;
using RestaurangGuide.DB.Models;

namespace RestaurangGuide.Domain.Infrastructure
{
    public interface IRestaurantRepository
    {
        IQueryable<Restaurant> GetAllRestaurants();

        Restaurant GetRestaurant(int id);

        void AddRestaurant(Restaurant restaurant);

        void DeleteRestaurant(int id);
    }
}
