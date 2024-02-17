namespace MetodoExtensao.Utils;
internal static class MethodosExtensao
{
    public static string CaixaAltaPrimeiraLetra(this string valor)
    {
        if (valor.Length > 0)
        {
            char[] array = valor.ToCharArray();
            array[0] = char.ToUpper(array[0]);
            return new string(array);
        }
        return valor;
    }
}
