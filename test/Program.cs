string[] array = new string[]{
        "run", "black", "green", "gray", "true", "false", "yes",
        "brown", "world", "no", "geek", "brains", "world"};

Console.WriteLine("[" + string.Join(", ", array) + "]");

void SelectThreeSymbol(string[] array, int count) {
    int lenOfarray = array.Length;
    string[] arraySelect = new string[lenOfarray];
    int countOfString = 0;

    for(int i = 0; i < lenOfarray; i++) {
        if(array[i].Length <= count) {
            arraySelect[countOfString] = array[i];
            countOfString++;
        }
    }
    Array.Resize(ref arraySelect, countOfString);
    Console.WriteLine("[" + string.Join(", ", arraySelect) + "]");
}

SelectThreeSymbol(array, 3);
