using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serilog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog.DataAccess.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var faker = new Faker("az");
            for (int i = 1; i < 100; i++)
            {
                builder.HasData(new Product
                {
                    Name = faker.Commerce.ProductName(),
                    Category = faker.Commerce.Categories(1).FirstOrDefault()?.ToString(),
                    Description = faker.Commerce.ProductDescription(),
                    Id = i,
                    Image=faker.Image.PicsumUrl()
                });
            }
        }
    }
}
