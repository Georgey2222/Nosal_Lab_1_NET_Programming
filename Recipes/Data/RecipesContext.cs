using Microsoft.EntityFrameworkCore;
using Recipes.Models;

namespace Recipes.Data;

public class RecipesContext : DbContext
{
    public RecipesContext(DbContextOptions<RecipesContext> options)
        : base(options) { }

    public DbSet<Recipe> Recipes => Set<Recipe>();

    protected override void OnModelCreating(ModelBuilder b)
    {
    }
}