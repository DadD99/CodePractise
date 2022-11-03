namespace FunctionLibrary
{
    
    public static class YearOldCalculate
    {
        /// <summary>
        /// User type in year of birth, this method will give his/her age as ouput
        /// </summary>
        /// <returns></returns>
        public static int TinhTuoi(string a)
        {
            int tuoi = 0;
            bool c = int.TryParse(a, out var t);
            if(!c)
            {
                throw new ArgumentException("Invalid Value");
            }
            else
            {
                int thisYear = DateTime.Now.Year;
                tuoi = thisYear - t;
                return tuoi;
            }
            return tuoi;
        }

    }
}