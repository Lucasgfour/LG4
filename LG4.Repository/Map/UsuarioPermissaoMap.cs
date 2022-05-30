using LG4.Data.Enums;
using LG4.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LG4.Repository.Map {
    public class UsuarioPermissaoMap : IEntityTypeConfiguration<UsuarioPermissao> {

        public void Configure(EntityTypeBuilder<UsuarioPermissao> builder) {

            builder.ToTable("inf_usuario_permissao");

            builder.Property(x => x.grupo);

            //builder.HasCons

            builder.Property(x => x.read).HasDefaultValue(YesNo.Nao);
            builder.Property(x => x.write).HasDefaultValue(YesNo.Nao);
            builder.Property(x => x.update).HasDefaultValue(YesNo.Nao);
            builder.Property(x => x.delete).HasDefaultValue(YesNo.Nao);


        }

    }
}
