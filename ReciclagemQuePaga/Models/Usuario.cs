using Microsoft.Identity.Client;
using System;

public class Usuario
{
	public int UsuarioId { get; set; }
	public string NomeUsuario { get; set; } = String.Empty;
	public string EmailUsuario { get; set; } = String.Empty;
    public string SenhaUsuario { get; set; } = String.Empty;
    public string CpfUsuario { get; set; } = String.Empty;

}
