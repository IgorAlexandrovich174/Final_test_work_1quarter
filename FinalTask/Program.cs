﻿//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//
//Примеры:
//
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []



System.Console.Write("Введите слова строго через запятую и без пробелов: ");

string? inputString = System.Console.ReadLine();
string[] parseArray = inputString.Split(",");

//Метод принимает в себя массив, выбирает из него элементы которые содержат не более 3 символов, 
//добавляет их в новый массив и возвращает его.
string[] CreateArrayNoMoreThenThreeChar(string[] inputArray){
    
}