using LG4.Data.Enums;
using LG4.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Repository.Map {
    public class UsuarioMap : IEntityTypeConfiguration<Usuario> {
        public void Configure(EntityTypeBuilder<Usuario> builder) {

            builder.ToTable("inf_usuario");

            builder.HasKey(x => x.id);

            builder.Property(x => x.nome).HasMaxLength(50);

            builder.Property(x => x.situacao).HasDefaultValue(UsuarioSituacao.Suspenso);

            builder.HasIndex(x => x.usuario).IsUnique();
            builder.Property(x => x.usuario).HasMaxLength(25);

            builder.Property(x => x.senha).HasMaxLength(32);

        }
    }
}
