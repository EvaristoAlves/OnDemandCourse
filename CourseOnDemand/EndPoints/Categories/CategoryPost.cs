using CourseOnDemand.Domain.Products;
using CourseOnDemand.Infra.Data;

namespace CourseOnDemand.EndPoints.Categories;

public static class CategoryPost
{
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context)
    {
        if (string.IsNullOrEmpty(categoryRequest.Name))
            return Results.BadRequest("Name is required");


        var category = new Category
        {
            Name = categoryRequest.Name,
            CreatedBy = "test",
            CreatedOn = DateTime.Now,
            EditedBy = "test",
            EditedOn = DateTime.Now,
        };
        
        context.Categories.Add(category);
        context.SaveChanges();

        return Results.Created($"/categories/{category.Id}",category.Id);
    }
    
}
