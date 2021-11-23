using bank.Domain;
using System;
using System.Linq;
using Xunit;

namespace bank_test
{
    public class CaixaTest
    {
        private readonly Caixa caixa = new Caixa();

        [Fact]
        public void Saque_Valido()
        {
            int valorDoSaque = 510;
            bool saqueEhValido = caixa.ValidaCedulasDisponiveis(valorDoSaque);
            Assert.True(saqueEhValido);
        }

        [Fact]
        public void Deve_Gerar_Excecao()
        {
            int valorDoSaque = 5;
            Assert.Throws<Exception>(() => caixa.Saque(valorDoSaque));
        }

        [Theory(DisplayName = "Saque contém número de cedulas solicitado correto")]
        [InlineData(3,80)]
        [InlineData(3,300)]
        [InlineData(5,500)]
        public void Saque_Contem_Numero_De_Cedula_Correto(int quantidadeDeCedulas, int valorDoSaque)
        {
            var resultadoCedulas = caixa.Saque(valorDoSaque);
            Assert.Equal(quantidadeDeCedulas, resultadoCedulas.Count());
        }
    }
}