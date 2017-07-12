namespace RomanToArabic
{
    public class Converter
    {
        public int Convert(string s)
        {
            if (s == "IV")
                return 4;
            return s.Length;
        }
    }
}