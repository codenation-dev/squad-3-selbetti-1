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
            builder.HasMany(x => x.Environments).WithOne(x => x.Application);
            builder.HasOne(x => x.User).WithOne(x => x.Application);
        }
    }
}

