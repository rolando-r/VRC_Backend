using System.Linq.Expressions;
using Dominio;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly VRC_BackendContext _context;

    public PaisRepository(VRC_BackendContext context) : base (context)
    {
        this._context = context;
    }
    
}