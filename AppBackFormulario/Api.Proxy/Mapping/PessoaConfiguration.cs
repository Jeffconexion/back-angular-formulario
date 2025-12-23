using Api.Service.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Proxy.Mapping
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("tb_pessoa");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .HasColumnName("id")
                   .ValueGeneratedNever();

            builder.Property(p => p.Nome)
                   .HasColumnName("nome")
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(p => p.Email)
                   .HasColumnName("email")
                   .HasMaxLength(250)
                   .IsRequired();

            builder.Property(p => p.Cpf)
                   .HasColumnName("cpf")
                   .HasMaxLength(11)
                   .IsRequired();

            builder.Property(p => p.DataDeNascimento)
                   .HasColumnName("data_nascimento")
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(p => p.Uf)
                   .HasColumnName("uf")
                   .HasMaxLength(2)
                   .IsRequired();

            builder.Property(p => p.Municipio)
                   .HasColumnName("municipio")
                   .HasMaxLength(100)
                   .IsRequired();
        }
    }
}
