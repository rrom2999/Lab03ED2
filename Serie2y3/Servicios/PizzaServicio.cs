using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Serie2y3.CLASES;

namespace Serie2y3.Servicios
{
    public class PizzaServicio
    {
        private readonly IMongoCollection<Pizza> _pizzas;

        public PizzaServicio(IPizzaDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _pizzas = database.GetCollection<Pizza>(settings.PizzasCollectionName);
        }

        public List<Pizza> Get() =>
            _pizzas.Find(pizza => true).ToList();

        public Pizza Get(string id) =>
            _pizzas.Find<Pizza>(pizza => pizza.Id == id).FirstOrDefault();

        public Pizza Create(Pizza pizza)
        {
            _pizzas.InsertOne(pizza);
            return pizza;
        }

        public void Update(string id, Pizza pizzaIn) =>
            _pizzas.ReplaceOne(pizza => pizza.Id == id, pizzaIn);

        public void Remove(Pizza pizzaIn) =>
            _pizzas.DeleteOne(pizza => pizza.Id == pizzaIn.Id);

        public void Remove(string id) =>
            _pizzas.DeleteOne(pizza => pizza.Id == id);
    }
}

