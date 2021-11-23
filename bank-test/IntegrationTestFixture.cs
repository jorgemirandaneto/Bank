using bank.Domain;
using Xunit;
using Microsoft.Extensions.DependencyInjection;

namespace bank_test
{
    public class IntegrationTestFixture : IClassFixture<IntegrationTestFixture>
    {
        private ICaixa _caixa;
        public IntegrationTestFixture(IntegrationTestFixture fixture)
        {
            _caixa = fixture.ServiceProvider.GetRequiredService<ICaixa>();
        }
        public void SaqueContemMenorNumeroDeCedulas()
        {
            int quantidadeDeCedulas = 3;
            int valorDoSaque = 80;

            var resultadoCedulas = _caixa.Saque(valorDoSaque);
        }
    }
}