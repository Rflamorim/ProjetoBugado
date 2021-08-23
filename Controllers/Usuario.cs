
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apresentacao.Models;
using apresentacao.Servicos;
using Microsoft.Data.SqlClient;

namespace apresentacao_aec.Models
{
    public record usuario 
  {
    public int Id { get;set; }
    public string Nome { get;set; }
    public string Cpf { get;set; }
    public DateTime Nascimento { get;set; }

    public string Email { get;set; }
    public string PossuiVeiculo { get;set; }
    public int endereco_id { get; set; }
 
  }



  class Pessoa : IEquatable<Pessoa>
    {
        public string Nome { get; }
        public string Email { get; }
        public string Endereco { get; }
        public DateTime Nascimento { get; }

        public Pessoa(string Nome, string Email, string Endereco, DateTime Nascimento)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Endereco = Endereco;
            this.Nascimento = Nascimento;
        }

        public bool Equals(Pessoa other)
        {
            return Equals(Nome, other.Nome) && Equals(Email, other.Email) && Equals(Endereco, other.Endereco) && Equals(Nascimento, other.Nascimento);
        }

        public override bool Equals(object other)
        {
            return (other as Pessoa)?.Equals(this) == true;
        }

        public override int GetHashCode()
        {
            return (Nome.GetHashCode() * 17 + Email.GetHashCode() + Endereco.GetHashCode() + Nascimento.GetHashCode());
        }

        public void Deconstruct(out string Nome, out string Email, out string Endereco, out DateTime Nascimento)
        {
            Nome = this.Nome;
            Email = this.Email;
            Endereco = this.Endereco;
            Nascimento = this.Nascimento;
          
        }

        public Pessoa With(string Nome = this.Nome, string Email = this.Email, string Endereco = this.Endereco, DateTime Nascimento = this.Nascimento) => new Person(Nome, Email, Endereco, Nascimento);
    }
 
}*/