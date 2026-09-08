using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using ReciclagemQuePaga.Models;

public class DataBaseConnection:DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Material> Materiais { get; set; }
    public DbSet<Transacao> Transacoes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conexao = "Data Source=VPR0681557W11-1\\SQLEXPRESS;Initial Catalog=reciclagemQuePaga;Persist Security Info=True;User ID=sa;Password=123456;Trust Server Certificate=True";
        optionsBuilder.UseSqlServer(conexao);
    }
}
