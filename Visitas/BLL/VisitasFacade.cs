using ApresentacaoVisitas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApresentacaoVisitas.BLL
{
    public class VisitasFacade
    {
        private IVisitasDAO dao = new VisitasDAOImpl();

        private static class SingletonHolder
        {
            public static readonly VisitasFacade INSTANCE = new VisitasFacade();
        }

        public static VisitasFacade getInstance() => SingletonHolder.INSTANCE;

        public bool cadastrar(Visitante visitante)
        {
            try
            {
                dao.add(visitante);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }

        public List<Visitante> buscarVisitantes()
        {
            return dao.buscarVisitantes();
        }
    }
}
