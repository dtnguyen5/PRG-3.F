namespace MyNamespace;

public class Converter
{
    // Převod binárního čísla (string) na desetinné (int)
    public int BinToDec(string Number)
    {
        return Convert.ToInt32(Number, 2);
    }

    // Převod desetinného čísla (int) na hexadecimální řetězec (string)
    public string DecToHex(int num)
    {
        return num.ToString("X");
    }

    // Převod hexadecimálního čísla (string) na binární řetězec (string)
    public string HexToBin(string Number)
    {
        int decimalValue = Convert.ToInt32(Number, 16);
        return Convert.ToString(decimalValue, 2);
    }
}