using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
	public DbSet<Empresa> Empresas { get; set; }
	public DbSet<Feedback> Feedbacks { get; set; }
	public DbSet<Servico> Servicos { get; set; }
	public DbSet<Suporte> Suportes { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options) { }
}
