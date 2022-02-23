﻿using bookShopSolution.Data.Entities;
using bookShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookShopSolution.Data.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(x => x.TransactionId);
            builder.Property(x => x.TransactionId).UseIdentityColumn();
            builder.Property(x => x.TransactionDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Fee).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Message).HasMaxLength(200);
            builder.Property(x => x.Provider).HasMaxLength(200);
        }
    }
}
