using Marten.Schema;

namespace CatelogAPI.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync())
            return;

        //Marten UPSERT will cater for existing record

        session.Store<Product>(GetPreconfigureProducts());
        await session.SaveChangesAsync();
    }

    private static IEnumerable<Product> GetPreconfigureProducts() => new List<Product>
    {
        new Product()
        {
            Id = new Guid("5334c996-8457-4cf0-815-ed2b77c4ff61"),
            Name ="IPhone",
            Description = "Heyyy MIMI",
            ImageFile = "Product-1.png",
            Price = 950.00M,
            Category = new List<string> {"Smart phone"}
        }
    };
}
