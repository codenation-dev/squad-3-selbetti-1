using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
