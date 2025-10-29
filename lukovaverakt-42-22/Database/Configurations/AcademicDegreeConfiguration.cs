﻿using lukovaverakt_42_22.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lukovaverakt_42_22.Database.Configurations
{
    public class AcademicDegreeConfiguration : IEntityTypeConfiguration<AcademicDegree>
    {
        public void Configure(EntityTypeBuilder<AcademicDegree> builder)
        {
            builder.ToTable("AcademicDegrees");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Title).HasMaxLength(100).IsRequired();
        }

    }
}
