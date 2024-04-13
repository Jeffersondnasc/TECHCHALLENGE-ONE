﻿using Fiap.TechChallenge.One.Domain.Contatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.TechChallenge.One.Infrastructure.Data.Configurations;

internal sealed class ContatoConfiguration : IEntityTypeConfiguration<Contato>
{
    public void Configure(EntityTypeBuilder<Contato> builder)
    {
        builder.ToTable("Contatos");

        builder.HasKey(c => c.Id);

        builder.ComplexProperty(
            c => c.Email,
            b => b.Property(e => e.Value).HasColumnName("Email"));

        builder.ComplexProperty(
            c => c.Nome,
            b => b.Property(e => e.Value).HasColumnName("Nome"));

        builder.ComplexProperty(
            c => c.Telefone,
            b => b.Property(e => e.Value).HasColumnName("Telefone"));
    }
}
