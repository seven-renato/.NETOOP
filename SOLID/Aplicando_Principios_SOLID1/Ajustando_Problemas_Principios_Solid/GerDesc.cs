namespace Aplicando_Principios_SOLID1
{
    public static class Constantes
    {
        public const int DESCONTO_MAXIMO_POR_FIDELIDADE = 5;
        public const decimal DESCONTO_CLIENTE_COMUM = 0.1m;
        public const decimal DESCONTO_CLIENTE_ESPECIAL = 0.7m;
        public const decimal DESCONTO_CLIENTE_VIP = 0.5m;
    }
    public enum StatusContaCliente
    {
        NaoRegistrado = 1,
        ClienteComum = 2,
        ClienteEspecial = 3,
        ClienteVIP = 4
    }
    public class GerenciadoDeDescontos
    {
        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposdesconto = 0;
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ? (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDeContaEmAnos / 100;
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposdesconto = precoProduto;
                    break;
                case StatusContaCliente.ClienteComum:
                    precoAposdesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto)) - descontoPorFidelidade * (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto));
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoAposdesconto = (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto) - descontoPorFidelidade * (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoAposdesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto)) - descontoPorFidelidade * (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto));
                    break;
                default:
                    throw new NotImplementedException();
            }
            
            return precoAposdesconto;
        }
    }
}


