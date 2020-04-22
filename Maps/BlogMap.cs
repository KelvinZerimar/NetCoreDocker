using mydockerapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class BlogMap{
    public BlogMap(EntityTypeBuilder<Blog> entityBuilder)
    {
        entityBuilder.HasKey(x=>x.Id);
        entityBuilder.ToTable("blog");

        entityBuilder.Property(X=>X.Id).HasColumnName("id");
        entityBuilder.Property(X=>X.Title).HasColumnName("title");
        entityBuilder.Property(X=>X.Description).HasColumnName("description");
    }
}