using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLog.Domain.Models.Configuration
{
    public class EnvinromentEfConfig : IEntityTypeConfiguration<Envinroment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Envinroment> builder)
        {
            builder.ToTable("Environments");
            builder.HasKey(s => s.Id);
            builder.HasOne(x => x.Application).WithMany(x => x.Envinroments);
        }
    }
}
