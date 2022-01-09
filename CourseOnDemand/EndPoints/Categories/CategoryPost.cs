﻿using CourseOnDemand.Infra.Data;

namespace CourseOnDemand.EndPoints.Categories;

public static class CategoryPost
{
    public static string Template => "/categories";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
    public static Delegate Handle => Action;

    public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext applicationDbContext)
    {
        return Results.Ok("Ok");
    }
}
