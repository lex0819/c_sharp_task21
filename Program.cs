/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int GetNumber(string message){
  bool isCorrect = false;
  int result = 0;

  while (!isCorrect)
  {
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine() , out result))
    {
      isCorrect = true;
    }
    else
    {
      Console.WriteLine("You've entered incorrect number");
    }
  }
  return result;
}

double DistanceBeetvenTowPoints(int x1, int y1, int z1, int x2, int y2, int z2){
  return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

int[] getPoint3D(string message){
  int[] resArray = {0, 0, 0};
  Console.WriteLine(message);
  
  resArray[0] = GetNumber("Enter X coordinate");
  resArray[1] = GetNumber("Enter Y coordinate");
  resArray[2] = GetNumber("Enter Z coordinate");

  return resArray;
}

int[] firstPoint = getPoint3D("Enter 3D coordinates for first point");
int[] secondPoint = getPoint3D("Enter 3D coordinates for second point");
double distance = DistanceBeetvenTowPoints(firstPoint[0], firstPoint[1], firstPoint[2], secondPoint[0], secondPoint[1], secondPoint[2]);

Console.WriteLine($"A ({firstPoint[0]},{firstPoint[1]},{firstPoint[2]}); B ({secondPoint[0]},{secondPoint[1]},{secondPoint[2]}), -> {Math.Round(distance, 2)}");