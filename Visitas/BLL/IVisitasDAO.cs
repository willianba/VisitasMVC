using ApresentacaoVisitas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApresentacaoVisitas.BLL
{
    interface IVisitasDAO
    {
        void add(Visitante visitante);
        List<Visitante> buscarVisitantes();
    }
}
