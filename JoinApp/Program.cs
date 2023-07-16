
var categories = new List<Category>
{
    new Category{CategoryName="Electronics", CategoryId=1},
    new Category{CategoryName="Utensils", CategoryId=2},
    new Category{CategoryName="Clothes", CategoryId=3},
};

var products = new List<Product>
{
    new Product{ProductName="Desktop PC", CategoryId = 1, Price=650.99m},
    new Product{ProductName="Spoons set", CategoryId = 2, Price=25.99m},
    new Product{ProductName="Forks set", CategoryId = 2, Price=25.99m},
    new Product{ProductName="Oven", CategoryId = 1, Price=250m},
    new Product{ProductName="Refrigrator 6 foot", CategoryId = 1, Price=500.99m},
    new Product{ProductName="Denim Jeans", CategoryId = 3, Price=45.99m},
};

var results = categories.Join(products, category => category.CategoryId, product => product.CategoryId, (category,product) => new {
    ProductCategory=category.CategoryId,product=product.ProductName
});
foreach (var result in results)
{
    Console.WriteLine($"Category:{result.ProductCategory}");
    Console.WriteLine($"Product:{result.product}");

}
class Category
{
    public string CategoryName { get; set; }
    public int CategoryId { get; set; }
}

class Product { 
    public string ProductName { get; set; } 
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
}
