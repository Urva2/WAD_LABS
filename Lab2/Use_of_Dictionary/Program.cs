Console.WriteLine("Enter a sentence:");
string sentence = Console.ReadLine();
string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Dictionary<string, int> wordCounts = new Dictionary<string, int>();

foreach (string word in words)
{
    
    string lowerWord = word.ToLower();

    if (wordCounts.ContainsKey(lowerWord))
    {
        wordCounts[lowerWord]++;
    }
    else
    {
        wordCounts[lowerWord] = 1;
    }
}
Console.WriteLine("Unique Word Counts:");
foreach (KeyValuePair<string, int> pair in wordCounts)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}