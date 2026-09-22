using Microsoft.Identity.Client;
using System;
using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Key]
    public int usuario_id { get; set; }
    public string nome_usuario { get; set; } = String.Empty;
    public string email_usuario { get; set; } = String.Empty;
    public string senha_usuario { get; set; } = String.Empty;
    public string cpf_usuario { get; set; } = String.Empty;
    public decimal saldo_usuario { get; set; } 

    public Usuario()
    {

    }
    public Usuario(string nome, string email, string senha, string cpf)
    {
        nome_usuario = nome;
        email_usuario = email;
        senha_usuario = senha;
        cpf_usuario = cpf;
      
    }
}
