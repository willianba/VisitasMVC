using ApresentacaoVisitas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApresentacaoVisitas.BLL
{
    public class VisitasDAOImpl: IVisitasDAO
    {
        public void add(Visitante visitante)
        {
            // EF add into DB
        }

        public List<Visitante> buscarVisitantes()
        {
            // ef get from DB
            return new List<Visitante>(1);
        }
    }
}
