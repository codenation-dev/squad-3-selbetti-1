using Microsoft.EntityFrameworkCore;

namespace AppLog.Domain.Models.Configuration
{
    public class ApplicationCategoryEfConfig : IEntityTypeConfiguration<ApplicationCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ApplicationCategory> builder)
        {
            builder.ToTable("ApplicationsCategories");
            builder.HasKey(s => new { s.ApplicationId, s.CategoryId});
        }
    }
}
