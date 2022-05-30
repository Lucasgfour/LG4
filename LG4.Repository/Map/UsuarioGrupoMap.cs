using LG4.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Repository.Map {
    public class UsuarioGrupoMap : IEntityTypeConfiguration<UsuarioGrupo> {
        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder) {

            builder.ToTable("inf_usuario_grupo");

            builder.HasKey(x => x.id);

            builder.Property(x => x.name).HasMaxLength(20);

            
        }
    }

}
