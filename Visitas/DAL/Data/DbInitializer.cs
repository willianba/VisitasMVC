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
                new Visitante{Nome="Jorge", Sobrenome="Casagrande", Email="jorgecasagrande@ymail.com"},
                new Visitante{Nome="Nego", Sobrenome="Nei", Email="negonei@bol.com"}
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
