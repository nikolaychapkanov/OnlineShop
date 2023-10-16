using OnlineShop.Models;
using System.Collections.Immutable;

namespace OnlineShop.Services
{
    public static class ProductProviderService
    {
        public static readonly ImmutableList<Product> Products = ImmutableList.CreateRange(new List<Product>()
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Blazor First Steps",
                Description = "A tutorial book for Blazor.",
                Price = 70,
                Stock = 0
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Tekerik UI for Brazor - Completed Edition",
                Description = "Learn to use Telerik UI from scratch.",
                Price = 70,
                Stock = 1
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "50 Amazing facts about Bulgaria",
                Description = "First book of Slavi from The Clashers.",
                Price = 100,
                Stock = 4
            }

        });

    }
}
