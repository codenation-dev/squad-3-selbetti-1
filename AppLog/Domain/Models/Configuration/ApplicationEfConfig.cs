using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain.Models.Configuration
{
    public class ApplicationEfConfig : IEntityTypeConfiguration<Application>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications");
            builder.HasKey(s => s.Id);
            builder.HasMany(x => x.Envinroments).WithOne(x => x.Application);
        }
    }
}

