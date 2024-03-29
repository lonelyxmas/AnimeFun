﻿using AnimeFun.Core.Models.AnimeFun;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnimeFun.Service.DataFactory.Configurations;

public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseModel
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.Property(p => p.CreateTime).HasDefaultValueSql("GETDATE()");
        builder.Property(p => p.UpdateTime).HasDefaultValueSql("GETDATE()");
    }
}
