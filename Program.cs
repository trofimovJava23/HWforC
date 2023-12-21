//Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
//Под удалением понимается создание нового двумерного массива без строки и столбца


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
      int[,] result = anInstanceofMyClass.deleteSomeRows(mass);
      anInstanceofMyClass.printSomeArr(result);
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
  
  int[,] deleteSomeRows(int[,] arr){
      int[,] result = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
      
      
      int[] CoordOfMin = foundCoordOfMin(arr);
      Console.WriteLine("Coordinate of minimum value is : ({0},{1})",CoordOfMin[1],CoordOfMin[0]);
      for (int i = 0; i < result.GetLength(0); i++){
          int a = i >= CoordOfMin[0] ? i + 1 : i;
          for (int j = 0; j < result.GetLength(1); j++){
              int b = j >= CoordOfMin[1] ? j + 1 : j;
              result[i, j] = arr[a, b];
            }
      }
    return result;
  }
  
  int[] foundCoordOfMin(int[,] arr){
      int[] result = new int[2];
      result[0] = 0;
      result[1] = 0;
      int minValue = arr[0,0];
      for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++){
            if (arr[i,j] < minValue) {
                result[0] = i;
                result[1] = j;
                minValue = arr[i,j];
            }
        }
      }
      return result;
  }
 
 
  }