using System;

namespace Game {

public class Program {

  public static void Main()
  {
    PingPong pingPong = new PingPong();
    Console.WriteLine("Please enter a +ve Integer number: ");
      string enteredNumber = Console.ReadLine();
      int enteredIntNum = int.Parse(enteredNumber);
      pingPong.DoEverything(enteredIntNum);
  }
}

}
