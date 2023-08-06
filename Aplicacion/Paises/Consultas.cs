using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Paises
{
    public class Consultas 
    {
        public class ListaPais : IRequest<List<Pais>>{}

        public class Manejador : IRequestHandler<ListaPais, List<Pais>>
        {
            private readonly VRC_BackendContext contex;

            public Manejador(VRC_BackendContext _contex){
                contex = _contex;
            }

            public async Task<List<Pais>> Handle(ListaPais request, CancellationToken cancellationToken)
            {
                var paises = await contex.Paises.ToListAsync();
                return paises;
            }
        }

    }
}