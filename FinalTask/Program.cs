//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//
//Примеры:
//
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []





//Вывод элементов массива на экран через запятую
void PrintArray(string[] arr) {
	System.Console.WriteLine("[" + string.Join(",", arr) + "]");
}


string[] CreateArrayNoMoreThenThreeChar(string[] inputArray){

    int lengthResultArray = 0;
    int index = 0;
    
    //Проходим по массиву переданному в параметры и инкрементируем переменную длины для результирующего массива
    for (int i = 0; i < inputArray.Length; i++) {
        if(inputArray[i].Length <= 3) {
            lengthResultArray++;
        }
    }

    //Создаём результирующий массив и заполняем его
    string[] resultArray = new string[lengthResultArray];
    for (int i = 0; i < inputArray.Length; i++) {
        if(inputArray[i].Length <= 3) {
            resultArray[index++] = inputArray[i];
            
        }
    }
    return resultArray;
}

System.Console.Write("Введите слова строго через запятую и без пробелов: ");

//Сохраняем строку из консоли и создаём из неё массив.
string? inputString = System.Console.ReadLine();
string[] parseArray = inputString.Split(",");

string[] result = CreateArrayNoMoreThenThreeChar(parseArray);
PrintArray(result);