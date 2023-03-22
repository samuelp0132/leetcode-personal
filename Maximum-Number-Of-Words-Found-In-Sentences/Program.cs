int MostWordsFound(string[] sentences) {
    int countWords = 0;
    int largest = 0;
    List<int> countWordsInSentences = new List<int>();
    foreach (var values in sentences)
    {
        foreach (var words in values)
        {
            if (words.Equals(' '))
                countWords += 1;
        }
        countWordsInSentences.Add(countWords);
        countWords = 0;
    }

    foreach (var t in countWordsInSentences)
    {
        if(t > largest)
            largest = t;
    } 
    return largest + 1;
}

int MostWordsFoundOne(string[] sentences) {
    int largest = 0;
    foreach (var values in sentences)
    {
        var l = values.Split(' ');
        if (l.Length > largest)
            largest = l.Length;
    }

    return largest;
}

MostWordsFound(new []{"alice and bob love leetcode", "i think so too", "this is great thanks very much"});
