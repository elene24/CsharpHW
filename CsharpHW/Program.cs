using System;
using System.Globalization;

class Program
{
    static void Main()
    {
       
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();

            string result = CapitalizeSentences(input);
            Console.WriteLine(result);
        }

        static string CapitalizeSentences(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            char[] sentenceEndings = { '.', '!', '?' };
            string[] sentences = text.Split(sentenceEndings, StringSplitOptions.None);

            string result = "";
            int currentIndex = 0;

            foreach (string sentence in sentences)
            {
                string trimmed = sentence.Trim();
                if (!string.IsNullOrEmpty(trimmed))
                {
                    string capitalized = char.ToUpper(trimmed[0], CultureInfo.InvariantCulture) + trimmed.Substring(1);
                    result += capitalized;

                    if (currentIndex < text.Length)
                    {
                        int index = text.IndexOfAny(sentenceEndings, currentIndex);
                        if (index != -1)
                        {
                            result += text[index]; 
                            currentIndex = index + 1;
                        }
                    }

                    result += " ";
                }
            }

            return result.Trim();
        
    

}
}
