using ApresentacaoVisitas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApresentacaoVisitas.BLL
{
    public class VisitasFacade
    {
        private VisitasDAOImpl dao = new VisitasDAOImpl();

        private static class SingletonHolder
        {
            public static readonly VisitasFacade INSTANCE = new VisitasFacade();
        }

        public static VisitasFacade getInstance() => SingletonHolder.INSTANCE;

        public bool cadastrar(Visitante visitante)
        {
            dao.add(visitante);
            return true;
        }

        public List<Visitante> buscarVisitantes()
        {
            return dao.buscarTodosVisitantes();
        }
    }
}
