using API_Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Shop.SeedDataCongiguration
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
            (
                new Category { Id = 1, Name = "Kitchen Tool", Description = "Test" },
                new Category { Id = 2, Name = "Electronics", Description = "Electronic gadgets and devices" },
                new Category { Id = 3, Name = "Books", Description = "Various genres of books" },
                new Category { Id = 4, Name = "Clothing", Description = "Men and Women clothing" },
                new Category { Id = 5, Name = "Toys", Description = "Toys for children" },
                new Category { Id = 6, Name = "Sports", Description = "Sports equipment and accessories" },
                new Category { Id = 7, Name = "Home Decor", Description = "Decor items for home" },
                new Category { Id = 8, Name = "Beauty", Description = "Beauty and skincare products" },
                new Category { Id = 9, Name = "Automotive", Description = "Car accessories and tools" },
                new Category { Id = 10, Name = "Gardening", Description = "Gardening tools and plants" },
                new Category { Id = 11, Name = "Pet Supplies", Description = "Products for your pets" },
                new Category { Id = 12, Name = "Music", Description = "Musical instruments and gear" },
                new Category { Id = 13, Name = "Office Supplies", Description = "Office equipment and stationery" },
                new Category { Id = 14, Name = "Groceries", Description = "Everyday grocery items" },
                new Category { Id = 15, Name = "Fitness", Description = "Workout gear and supplements" },
                new Category { Id = 16, Name = "Shoes", Description = "All kinds of footwear" },
                new Category { Id = 17, Name = "Watches", Description = "Wrist watches and accessories" },
                new Category { Id = 18, Name = "Bags", Description = "Bags for all purposes" },
                new Category { Id = 19, Name = "Jewelry", Description = "Fashion and fine jewelry" },
                new Category { Id = 20, Name = "Furniture", Description = "Indoor and outdoor furniture" }
            );

            modelBuilder.Entity<Product>().HasData
(
    new Product { Id = 1, CategoryId = 1, Name = "Knife Set", Description = "High-quality stainless steel kitchen knives", IsExists = true, Price = 1200000 },
    new Product { Id = 2, CategoryId = 2, Name = "Smartphone", Description = "Latest model with advanced features", IsExists = true, Price = 25000000 },
    new Product { Id = 3, CategoryId = 3, Name = "Science Fiction Book", Description = "A thrilling sci-fi adventure", IsExists = true, Price = 150000 },
    new Product { Id = 4, CategoryId = 4, Name = "Men's Jacket", Description = "Warm and stylish winter jacket", IsExists = true, Price = 980000 },
    new Product { Id = 5, CategoryId = 5, Name = "Lego Set", Description = "Creative toy set for kids", IsExists = true, Price = 700000 },
    new Product { Id = 6, CategoryId = 6, Name = "Football", Description = "Professional match football", IsExists = true, Price = 320000 },
    new Product { Id = 7, CategoryId = 7, Name = "Wall Clock", Description = "Modern design for living room", IsExists = true, Price = 280000 },
    new Product { Id = 8, CategoryId = 8, Name = "Facial Cleanser", Description = "For daily skincare routine", IsExists = true, Price = 180000 },
    new Product { Id = 9, CategoryId = 9, Name = "Car Vacuum Cleaner", Description = "Portable and powerful", IsExists = true, Price = 650000 },
    new Product { Id = 10, CategoryId = 10, Name = "Watering Can", Description = "Ergonomic design, 2L", IsExists = true, Price = 130000 },
    new Product { Id = 11, CategoryId = 11, Name = "Dog Leash", Description = "Durable and adjustable", IsExists = true, Price = 90000 },
    new Product { Id = 12, CategoryId = 12, Name = "Acoustic Guitar", Description = "Wooden body, great sound", IsExists = true, Price = 2100000 },
    new Product { Id = 13, CategoryId = 13, Name = "Office Chair", Description = "Ergonomic and adjustable", IsExists = true, Price = 1450000 },
    new Product { Id = 14, CategoryId = 14, Name = "Organic Rice", Description = "1kg pack", IsExists = true, Price = 95000 },
    new Product { Id = 15, CategoryId = 15, Name = "Dumbbells Set", Description = "Adjustable weights", IsExists = true, Price = 720000 },
    new Product { Id = 16, CategoryId = 16, Name = "Running Shoes", Description = "Lightweight and durable", IsExists = true, Price = 850000 },
    new Product { Id = 17, CategoryId = 17, Name = "Digital Watch", Description = "Waterproof with timer", IsExists = true, Price = 430000 },
    new Product { Id = 18, CategoryId = 18, Name = "Backpack", Description = "Multi-pocket and waterproof", IsExists = true, Price = 370000 },
    new Product { Id = 19, CategoryId = 19, Name = "Silver Necklace", Description = "Elegant design", IsExists = true, Price = 560000 },
    new Product { Id = 20, CategoryId = 20, Name = "Wooden Table", Description = "For dining room, 6-seater", IsExists = true, Price = 5800000 }
);

        }

    }
}
