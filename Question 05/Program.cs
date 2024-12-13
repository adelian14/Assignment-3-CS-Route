namespace Question_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.Write("Enter a character: ");
            c = (char)Console.Read();
            string vowels = "aeiouAEIOU";
            bool isVowel = false;
            for(int i = 0; i < vowels.Length; i++){
                if (c == vowels[i]){
                    isVowel = true;
                    break;
                }
            }
            if (isVowel){
                Console.WriteLine($"'{c}' is a vowel");
            }
            else{
                Console.WriteLine($"'{c}' is a consonant");
            }
        }
    }
}
