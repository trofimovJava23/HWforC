//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
class HelloWorld {
  static void Main() {
    var anInstanceofMyClass = new HelloWorld();
    int[,] mass = new int[5,3];
    for (int i = 0; i < mass.GetLength(0); i++) {
        for (int j = 0; j < mass.GetLength(1); j++){
            mass[i,j] = anInstanceofMyClass.randNumber();
            }
        }
      anInstanceofMyClass.printSomeArr(mass); 
      anInstanceofMyClass.StringReplacement(ref mass);
      anInstanceofMyClass.printSomeArr(mass);
    
    
  }
  
  int randNumber(){
      Random rnd = new Random();
      return rnd.Next(1,20);
  }

  void printSomeArr(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write("{0} ",arr[i,j]);//для проверки
        }
         Console.WriteLine(); 
      }
    Console.WriteLine();
  }
  
  void StringReplacement(ref int[,] arr){
      int[] tempArr = new int[arr.GetLength(1)];
      for (int k = 0; k < arr.GetLength(1); k++){
        tempArr[k] = arr[0, k];
        arr[0, k] = arr[arr.GetLength(0)-1,k];
        arr[arr.GetLength(0)-1,k] = tempArr[k];
      }

      
  }
 
  }
