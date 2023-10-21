using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();

    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        foreach (var categorys in categoryManager.GetAll())
        {
            Console.WriteLine(categorys.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        var result = productManager.GetProductDetails();

        if (result.Success==true)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + " " + product.CategoryName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
        
        
        
    }
}