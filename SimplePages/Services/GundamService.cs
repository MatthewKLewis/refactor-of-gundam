using SimplePages.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace GundamsApi.Services
{
    public class GundamService
    {
        private readonly IMongoCollection<GundamModel> _gundams;

        public GundamService(IGundamDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _gundams = database.GetCollection<GundamModel>(settings.GundamsCollectionName);
        }

        public List<GundamModel> Get() =>
            _gundams.Find(gnd => true).ToList();

        public GundamModel Get(string id) =>
            _gundams.Find<GundamModel>(gnd => gnd.Id == id).FirstOrDefault();

        public GundamModel Create(GundamModel gnd)
        {
            _gundams.InsertOne(gnd);
            return gnd;
        }

        public void Update(string id, GundamModel gnd) =>
            _gundams.ReplaceOne(gundam => gundam.Id == id, gnd);

        public void Remove(GundamModel gnd) =>
            _gundams.DeleteOne(gundam => gundam.Id == gnd.Id);

        public void Remove(string id) =>
            _gundams.DeleteOne(gundam => gundam.Id == id);
    }
}