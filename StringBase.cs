using System.Text;
public class StringBase
{
    protected char[] characters;
    protected byte lengthInBytes;

    public StringBase()
    {
        characters = new char[0];
        lengthInBytes = 0;
    }

    public StringBase(string str)
    {
        characters = str.ToCharArray();
        lengthInBytes = (byte)Encoding.Unicode.GetByteCount(str);
    }

    public StringBase(char ch)
    {
        characters = new char[] { ch };
        lengthInBytes = (byte)Encoding.Unicode.GetByteCount(new char[] { ch });
    }

    public byte GetLength()
    {
        return lengthInBytes;
    }

    public void Clear()
    {
        characters = new char[0];
        lengthInBytes = 0;
    }

    public override string ToString()
    {
        return new string(characters);
    }
}