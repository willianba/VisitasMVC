using ApresentacaoVisitas.DB.Data;
using ApresentacaoVisitas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApresentacaoVisitas.BLL
{
    public class VisitasDAOImpl: IVisitasDAO
    {
        private VisitasContext context = new VisitasContext();

        public void add(Visitante visitante)
        {
            context.Visitantes.Add(visitante);
            context.SaveChanges();
        }

        public List<Visitante> buscarVisitantes()
        {    
            return context.Visitantes.ToList();
        }
    }
}
