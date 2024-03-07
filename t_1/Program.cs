// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] array = {
    {'H', 'e', 'l', 'l', 'o'},
    {'W', 'o', 'r', 'l', 'd'}
};

string result = "";

for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
        result = result + array[i, j];
    }
}

Console.WriteLine(result);
