using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

public partial class ApplicationDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasAnnotation("ProductVersion", "5.0.0");

        modelBuilder.Entity("Empresa", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            b.Property<string>("Nome")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<string>("Cnpj")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Empresas");
        });

        modelBuilder.Entity("Feedback", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            b.Property<int>("EmpresaId")
                .HasColumnType("int");

            b.Property<string>("Comentario")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<int>("Avaliacao")
                .HasColumnType("int");

            b.HasKey("Id");

            b.ToTable("Feedbacks");
        });

        modelBuilder.Entity("Servico", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            b.Property<string>("Nome")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.Property<string>("Descricao")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Servicos");
        });

        modelBuilder.Entity("Suporte", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

            b.Property<int>("ServicoId")
                .HasColumnType("int");

            b.Property<string>("Mensagem")
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            b.HasKey("Id");

            b.ToTable("Suportes");
        });
    }
}
