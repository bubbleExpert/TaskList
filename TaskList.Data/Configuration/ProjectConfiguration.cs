﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TaskList.Core.Models;

namespace TaskList.Data.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasKey(p => p.ProjectId);

            builder
                .Property(p => p.ProjectId)
                .UseIdentityColumn();

            builder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.IsCompleted)
                .IsRequired();

            builder
                .ToTable("Projects");
        }
    }
}
