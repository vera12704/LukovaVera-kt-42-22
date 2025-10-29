﻿using lukovaverakt_42_22.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace lukovaverakt_42_22.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable("Disciplines");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).HasMaxLength(100).IsRequired();
        }

    }
}