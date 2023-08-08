using System;
using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DinoShopContext context;
    private PaisRepository _paises;
    public UnitOfWork(DinoShopContext _context)
    {
        context = _context;
    }
    public IPais Paises 
    { 
        get{
            if(_paises == null){
                _paises = new PaisRepository(context);
            }
            return _paises;
        } 
    }
    public void Dispose()
    {
        throw new NotImplementedException();
    }
}