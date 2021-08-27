using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrWork.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(K => K.Id);
            builder.Property(p => p.Username).IsRequired();
            builder.Property(p => p.Password).IsRequired();
            builder.Property(r => r.Role).IsRequired();
            builder.HasData(new Account {Id=1, Username = "ele@ina.it", Password = "qwerty", Role = Role.Administrator },
                            new Account {Id=2, Username = "anto@wonderfull.always", Password="ytrewq", Role=Role.User}
                );
        }
    }
}
