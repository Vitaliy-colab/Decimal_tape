using System.Text;
public class DecimalString : StringBase
{
    public DecimalString() : base() { }

    public DecimalString(string str) : base()
    {
        if (IsValidDecimalString(str))
        {
            characters = str.ToCharArray();
            lengthInBytes = (byte)Encoding.Unicode.GetByteCount(str);
        }
        else
        {
            characters = new char[] { '0' };
            lengthInBytes = 1;
        }
    }

    public DecimalString(int number) : base(number.ToString()) { }

    private bool IsValidDecimalString(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        int startIndex = 0;
        if (str[0] == '+' || str[0] == '-')
            startIndex = 1;

        if (startIndex >= str.Length)
            return false;

        for (int i = startIndex; i < str.Length; i++)
        {
            if (!char.IsDigit(str[i]))
                return false;
        }

        return true;
    }

    public static DecimalString operator -(DecimalString a, DecimalString b)
    {
        if (!a.IsValid() || !b.IsValid())
            return new DecimalString("0");

        int numA = int.Parse(a.ToString());
        int numB = int.Parse(b.ToString());
        return new DecimalString(numA - numB);
    }

    public static bool operator >(DecimalString a, DecimalString b)
    {
        if (!a.IsValid() || !b.IsValid())
            return false;

        int numA = int.Parse(a.ToString());
        int numB = int.Parse(b.ToString());
        return numA > numB;
    }

    public static bool operator <(DecimalString a, DecimalString b)
    {
        if (!a.IsValid() || !b.IsValid())
            return false;

        int numA = int.Parse(a.ToString());
        int numB = int.Parse(b.ToString());
        return numA < numB;
    }

    private bool IsValid()
    {
        return IsValidDecimalString(this.ToString());
    }
}