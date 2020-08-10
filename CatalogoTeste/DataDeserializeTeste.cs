using System;
using System.Collections.Generic;
using WebApi.Data;
using WebApi.Models;
using Xunit;

namespace TesteCatalogo
{
    public class DataDeserializeTeste
    {
        [Fact]
        public void CalculaFrete_20PorcentodoPrice()
        {
            Catalogo catalogo = new Catalogo();
            catalogo.id = 1;
            catalogo.name = "Julies";
            catalogo.price = 10;
            catalogo.frete = 2;

            double freteEsperado = catalogo.frete;
            double freteAtual = new DataDeserialize().CalculaFrete(catalogo.price);
            //Teste
            Assert.Equal(freteEsperado, freteAtual);
        }
    }
}
