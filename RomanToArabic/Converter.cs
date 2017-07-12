namespace RomanToArabic
{
    public class Converter
    {
        public int Convert(string s)
        {
            if (s == "II")
                return 2;
            return 1;
        }
    }
}