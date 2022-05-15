using Desafio_07.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Desafio_07.DB;

public class MySQLDBContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<AlunoCurso> AlunoCursos { get; set; }
    public DbSet<Curso> Cursos { get; set; }

    public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // aluno faz curso
        //      n - n
        modelBuilder.Entity<Aluno>().ToTable("Alunos");
        modelBuilder.Entity<Aluno>().HasKey(aluno => aluno.Id).HasName("Id");
        modelBuilder.Entity<Aluno>().Property(aluno => aluno.Id).HasColumnName("Id").HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
        modelBuilder.Entity<Aluno>().Property(aluno => aluno.Nome).HasColumnName("Nome").HasColumnType("varchar(255)").IsRequired();
        modelBuilder.Entity<Aluno>().Property(aluno => aluno.Idade).HasColumnName("Idade").HasColumnType("int").IsRequired();

        modelBuilder.Entity<Curso>().ToTable("Cursos");
        modelBuilder.Entity<Curso>().HasKey(curso => curso.Id).HasName("Id");
        modelBuilder.Entity<Curso>().Property(curso => curso.Id).HasColumnName("Id").HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
        modelBuilder.Entity<Curso>().Property(curso => curso.Nome).HasColumnName("Nome").HasColumnType("varchar(255").IsRequired();

        modelBuilder.Entity<AlunoCurso>().ToTable("AlunoCursos");
        modelBuilder.Entity<AlunoCurso>().HasKey(alunoCurso => alunoCurso.IdAluno).HasName("IdAluno");
        modelBuilder.Entity<AlunoCurso>().HasKey(alunoCurso => alunoCurso.IdCurso).HasName("IdCurso");
        modelBuilder.Entity<AlunoCurso>().Property(alunoCurso => alunoCurso.Status).HasColumnName("Status").HasColumnType("varchar(255").IsRequired();
        modelBuilder.Entity<AlunoCurso>().Property(alunoCurso => alunoCurso.Nota).HasColumnName("Nota").HasColumnType("int").IsRequired();

        modelBuilder
            .Entity<AlunoCurso>()
            .HasOne<Aluno>()
            .WithMany()
            .HasPrincipalKey(aluno => aluno.Id)
            .HasForeignKey(alunoCurso => alunoCurso.IdAluno)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_Aluno_AlunoCurso");
        
        modelBuilder
            .Entity<AlunoCurso>()
            .HasOne<Curso>()
            .WithMany()
            .HasPrincipalKey(curso => curso.Id)
            .HasForeignKey(alunoCurso => alunoCurso.IdCurso)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_Curso_AlunoCurso");
    }
}