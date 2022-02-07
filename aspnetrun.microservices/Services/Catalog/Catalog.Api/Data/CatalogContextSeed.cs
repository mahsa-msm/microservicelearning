using Catalog.Api.Entities;
using MongoDB.Driver;

namespace Catalog.Api.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(c => true).Any();
            if(!existProduct)
            {
                //productCollection.InsertMany();
            }
        }
    }
}
