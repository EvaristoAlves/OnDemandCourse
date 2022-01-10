using Flunt.Validations;

namespace CourseOnDemand.Domain.Products;

public class Category : Entity
{
    public string Name { get; set; }
    public bool Active { get; set; } 

    public Category(string name)
    {
        var contract = new Contract<Category>()
            .IsNotNull(Name, "Name");
        Name = name;
        Active = true;
    }
  
}
