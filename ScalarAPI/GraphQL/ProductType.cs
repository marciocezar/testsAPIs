using HotChocolate.Types;
using ScalarAPI;

public class ProductType : ObjectType<Product>
{
    protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
    {
        descriptor.Description("Represents a product in the catalog");

        descriptor.Field(p => p.Id)
            .Description("The unique identifier for the product");

        descriptor.Field(p => p.Name)
            .Description("The name of the product");

        descriptor.Field(p => p.Price)
            .Description("The price of the product in USD");

        descriptor.Field(p => p.Category)
            .Description("The category that the product belongs to");
    }
}