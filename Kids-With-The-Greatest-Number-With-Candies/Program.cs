IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    int largest = 0;
    List<bool> result = new List<bool>();
    foreach (var t in candies)
    {
        if(t > largest)
            largest = t;
        result.Add((largest + extraCandies) > t);
    } 

    return result;
}

IList<bool> KidsWithCandiesOne(int[] candies, int extraCandies) {
    int largest = 0;
    List<bool> result = new List<bool>();
    foreach (var c in candies)
    {
        if(c > largest)
            largest = c;
    }
    foreach (var t in candies)
    {
        if((largest + extraCandies) > t)
            result.Add(true);
    } 

    return result;
}

KidsWithCandies(new []{2,3,6,1,3},10);