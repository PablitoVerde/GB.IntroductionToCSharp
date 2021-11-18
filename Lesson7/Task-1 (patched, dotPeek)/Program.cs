// Decompiled with JetBrains decompiler
// Type: Task_1.Program
// Assembly: Task-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 30F6812A-2D1C-4B29-A7D5-E556ECE94BBD
// Assembly location: D:\Geekbrains Study C#\Lesson7\Task-1\Task-1\bin\Release\Task-1.exe

using System;

namespace Task_1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.Write("Введи число: ");
      if (Convert.ToInt32(Console.ReadLine()) % 3 == 0)
        Console.WriteLine("Делится");
      else
        Console.WriteLine("Не делится");
      Console.ReadKey();
    }
  }
}
