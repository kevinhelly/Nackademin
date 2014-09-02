using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurangGuide.Domain.Model;

namespace RestaurangGuide.Domain.Services
{
    public interface IRestaurantService
    {
        IReadOnlyList<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurant(int id);
    } 
}
