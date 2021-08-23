using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace ProjetoAeC_main.Apresentacao
{
  public class HomeView
  {
      public string Mensagem
      {
          get
          {
              return "bemvindo vindo";
          }
      }

      public List<string> Endpoints
      {
          get
          {
              return new List<string>()
              {
                  "/Vagas",
                  "/Candidatos",
                  "/swagger"
              };
          }
      }
  }
}