using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Maps
{
    public class RegistroMap : IEntityTypeConfiguration<RegistroManutencao>
    {
        public void Configure(EntityTypeBuilder<RegistroManutencao> builder)
        {
            builder.ToTable("RegistroManutencao");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.Quilometragem).HasColumnName("Quilometragem").IsRequired();
            builder.Property(x => x.IdCarro).HasColumnName("IdCarro").IsRequired();
            builder.Property(x => x.IdManutencao).HasColumnName("IdManutencao").IsRequired();
            builder.Property(x => x.Data).HasColumnName("Data").HasColumnType("date").IsRequired();

            builder.HasOne(x => x.Manutencao).WithMany().HasForeignKey(x => x.IdManutencao).IsRequired();
            builder.HasOne(x => x.Carro).WithMany().HasForeignKey(x => x.IdCarro).IsRequired();



        }
    }
}
