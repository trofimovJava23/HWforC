//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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
      anInstanceofMyClass.findTheSmallest(mass);
    
    
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
  
  void findTheSmallest(int[,] arr){
      int[] tempArr = new int[arr.GetLength(0)];
      int smallestString = 0;
      for (int i = 0; i < tempArr.GetLength(0); i++){
          tempArr[i] = 0;
          for (int j = 0; j < arr.GetLength(1); j++){
              tempArr[i] = tempArr[i] + arr[i,j];
          }
          if (tempArr[i]<tempArr[smallestString]){
              smallestString = i;
          }
          
      }
      Console.WriteLine("Row with the smallest sum of values is() : {0}", (smallestString+1));
      
  }
  
 
  }
