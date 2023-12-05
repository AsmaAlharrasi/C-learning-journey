namespace day_14
{
    enum Months
    {
        jan=1,
        feb,
        mar,
        apr,
        may,
        jun,
        jul,
        aug,
        sep,
        oct,
        nov,
        dec

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum practis

            //string mnth = "nov";
            //Console.WriteLine((int)(Enum.Parse(typeof(Months), mnth)));

            ////Enum Parsing ==> print the month
            //if (Enum.TryParse(mnth, out Months m))
            //{
            //    Console.WriteLine(m);
            //}

            ////Enaum IsDefined ==> print the month
            //if (Enum.IsDefined(typeof(Months), mnth))
            //{
            //    Console.WriteLine(Enum.Parse(typeof(Months), mnth));
            //}

            ////Enum Foreach ==> print the whole 12 months
            //foreach (Months m2 in Enum.GetValues(typeof(Months)))
            //{
            //    Console.WriteLine(m2 + ":" + (int)(m2));
            //} 

            #endregion
        }
    }
}
