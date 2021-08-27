using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrWork.Configuration
{
    public class PiattoConfiguration : IEntityTypeConfiguration<Piatto>
    {
        public void Configure(EntityTypeBuilder<Piatto> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.Descrizione).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Tipologia).IsRequired();
            builder.Property(p => p.Prezzo).IsRequired();
        }
    }
}
