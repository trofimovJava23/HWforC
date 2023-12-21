//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
class HelloWorld {
  static void Main() {
    var anInstanceofMyClass = new HelloWorld();
    int[,] mass = new int[5,5];
    for (int i = 0; i < mass.GetLength(0); i++){
        for (int j = 0; j < mass.GetLength(1); j++){
            mass[i,j] = anInstanceofMyClass.randNumber();
            Console.Write("{0} ",mass[i,j]);//для проверки
        }
         Console.WriteLine(); 
          
      }
      anInstanceofMyClass.foundElement(mass);
    

  }
  
  int randNumber(){
      Random rnd = new Random();
      return rnd.Next(1,20);
  }
  
  void foundElement(int[,] arr){
      Console.WriteLine("Введите координаты искомого элемента:");
      Console.Write("Введите X:");
      int X = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите Y:");
      int Y = Convert.ToInt32(Console.ReadLine());
      if ((X >= arr.GetLength(0)) || (Y >= arr.GetLength(1)) || (X < 0) || (Y < 0)) {
        Console.WriteLine("Такого элемента нет");
      }
      else
      {
        Console.WriteLine("Искомый элемент массива равен: {0}", arr[X,Y]);
      }
       
  }
 
  }
