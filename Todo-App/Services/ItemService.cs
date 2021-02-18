using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo_App.Models;

namespace Todo_App.Services
{
    public class ItemService
    {
        private readonly IMongoCollection<Item> _items;

        public ItemService(ITodoDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _items = database.GetCollection<Item>(settings.ItemCollectionName);
        }

        public List<Item> Get() => _items.Find(item => true).ToList();
     
    }
}
