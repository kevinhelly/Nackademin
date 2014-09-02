using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurangGuide.Domain.Model;

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
