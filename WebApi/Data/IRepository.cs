using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Data
{
    public interface IRepository
    {
        Catalogo GetCatalogoID(int id);
        List<Catalogo> GetAllCatalogos();        
        List<Catalogo> GetAllCatalgoByBusca(string busca, string sort);
    }
}