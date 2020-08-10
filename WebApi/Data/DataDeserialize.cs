using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class DataDeserialize
    {
        public double CalculaFrete (double price)
        {
            var taxa = 20;
            var frete = (double)price * taxa / 100;
            return frete;
        }

        public List<Catalogo> DeserializeJson()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\books.json");
            var lista = JsonSerializer.Deserialize<List<Catalogo>>(json);

            return lista;
        }
    }
}