using Bogus;
using Microsoft.EntityFrameworkCore;

namespace AuthApp.Data
{
    public static class ModelBuilderExtensions
    {
        private static readonly int _seed = 1234;
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(GetBooks());
        }

        private static ICollection<Book> GetBooks(int count = 70)
        {
            Faker.GlobalUniqueIndex = 0;

            return new Faker<Book>()
                .CustomInstantiator(f => new Book(f.Random.Word(), f.Name.FirstName() + " " + f.Name.LastName(), f.Random.AlphaNumeric(10)))
                .UseSeed(_seed)
                .RuleFor(e => e.Id, f => f.IndexGlobal)
                .RuleFor(e => e.Year, f => f.Random.Number(1900, 2022))
                .Generate(count)
                .ToList();
        }
    }
}
