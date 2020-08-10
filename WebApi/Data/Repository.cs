using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WebApi.Models;

namespace WebApi.Data
{
    public class Repository : IRepository
    {
        public Catalogo GetCatalogoID(int id)
        {
            var dado = new DataDeserialize().DeserializeJson();

            var result = dado.Where(a => a.id == id).SingleOrDefault();

           
            result.frete = new DataDeserialize().CalculaFrete(result.price);    

            return result;
        }

        public List<Catalogo> GetAllCatalogos()
        {
            var result = new DataDeserialize().DeserializeJson();
             
            return result;
        }

        public List<Catalogo> GetAllCatalgoByBusca(string buscar, string sort)
        {
            var lista = new DataDeserialize().DeserializeJson();

            var result = lista.Where(a => a.specifications.Author.Contains(buscar) ||
                                          a.name.Contains(buscar)).ToList();

            switch (sort)
            {
                case "des":
                    result = result.OrderByDescending(c => c.price).ToList();
                    break;
                case "asc":
                    result = result.OrderBy(c => c.price).ToList();
                    break;
            }

            return result;
        }
    }
}