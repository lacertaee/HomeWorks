namespace Homwork10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First
            var textFile = new File() { MaxSize = 64, Extension = "png" };

            textFile.Write();
            textFile.Read();
            textFile.Edit();
            textFile.Read();
            #endregion

            #region Second
            var loan = new Bank();

            var checkUser = loan.CheckUserHistory();

            if (checkUser) Console.WriteLine($"You have to pay {loan.CalculateLoanPercent(3, 5000)}$");

            var microLoan = new MicroFinance();

            if (microLoan.CheckUserHistory()) Console.WriteLine($"You have to pay {microLoan.CalculateLoanPercent(3, 5000)}$");
            #endregion
        }
    }
}
