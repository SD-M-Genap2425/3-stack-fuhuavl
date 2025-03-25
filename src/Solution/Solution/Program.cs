using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager history = new HistoryManager();
        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("example.com");
        history.KunjungiHalaman("stackoverflow.com");
        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");
        Console.WriteLine("Kembali ke halaman sebelumnya...");
        string kembali = history.Kembali();
        Console.WriteLine($"Halaman saat ini: {kembali}");


        // Bracket validator

        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";
        BracketValidator validator = new BracketValidator();
        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {validator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {validator.ValidasiEkspresi(ekspresiInvalid)}");


        //Palindrome Checker

        string[] testCases = {
            "Kasur ini rusak",
            "Ibu Ratna antar ubi",
            "Hello World"
        };

        foreach (var test in testCases)
        {
            Console.WriteLine($"Input: \"{test}\" => Palindrom? {PalindromeChecker.CekPalindrom(test)}");
        }


    }
}
