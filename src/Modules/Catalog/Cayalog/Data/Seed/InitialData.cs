namespace Catalog.Data.Seed;

public static class InitialData
{
    public static IEnumerable<Product> Products =>
        new List<Product>
        {
            Product.Create(new Guid("b14f9c37-2d6a-4a93-9d89-7e3b75b3f3d1"), "IPhone X", ["category1"], "long description", "imagefile", 500),
            Product.Create(new Guid("e8f69f12-89b1-4e91-b9a2-629bd6c3d567"), "Samsung 10", ["category1"], "long description", "imagefile", 400),
            Product.Create(new Guid("f4c5b9b5-27b9-4512-bc6e-86c6e7f3c0f4"), "Huawei Plus", ["category2"], "long description", "imagefile", 650),
            Product.Create(new Guid("3d429c8e-987a-4e83-b582-5e41259c77b8"), "Xiaomi Mi", ["category2"], "long description", "imagefile", 450)
        };
}
