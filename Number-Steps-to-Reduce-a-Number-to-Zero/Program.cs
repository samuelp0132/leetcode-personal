int NumberOfSteps(int num) {
    var stepsCount = 0;
    for (var i = 0; i < num; i++)
    {
        if (checkIfDivisor(num))
        {
            num /= 2;
            stepsCount++;
        }
        else
        {
            num -= 1;
            stepsCount++;
        }
        
    }

    return stepsCount;
}

bool checkIfDivisor(int val){
    return val % 2 == 0 ? true : false;
}