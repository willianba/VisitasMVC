using ApresentacaoVisitas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApresentacaoVisitas.DB.Data
{
    public static class DbInitializer
    {
        public static void Initializer(VisitasContext context)
        {
            context.Database.EnsureCreated();

            if (context.Visitantes.Any())
            {
                return;
            }

            var visitantes = new Visitante[]
            {
                new Visitante{Nome="Willian", Sobrenome="Alves", Email="willian.alves@edu.pucrs.br"},
                new Visitante{Nome="Otávio", Sobrenome="Parraga", Email="otavio.parraga@edu.pucrs.br"},
                new Visitante{Nome="Laura", Sobrenome="Claro", Email="laura.claro@edu.pucrs.br"},
                new Visitante{Nome="Gustavo", Sobrenome="Couto", Email="gustavo.couto@edu.pucrs.br"}
            };
            context.Visitantes.AddRange(visitantes);
            context.SaveChanges();
        }

        internal static void Initialize(VisitasContext context)
        {
            throw new NotImplementedException();
        }
    }
}
