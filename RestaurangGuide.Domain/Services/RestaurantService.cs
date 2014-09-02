using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurangGuide.DB.Repositories;
using RestaurangGuide.Domain.Infrastructure;


namespace RestaurangGuide.Domain.Services
{
    public class RestaurantService : IRestaurantService
    {
        private IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            if (restaurantRepository == null)
            {
                throw new NullReferenceException("RestaurantRepository");
            }

            _restaurantRepository = restaurantRepository;
        }

        public IReadOnlyList<Model.Restaurant> GetAllRestaurants()
        {
            throw new NotImplementedException();
        }

        public Model.Restaurant GetRestaurant(int id)
        {
            throw new NotImplementedException();
        }
    }
}
