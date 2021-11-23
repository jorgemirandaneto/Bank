using System.Collections.Generic;

namespace bank.Domain
{
    public interface ICaixa
    {
         ICollection<int> Saque(int valor);
         bool ValidaCedulasDisponiveis(int valor);
    }
}