using System;
using System.Collections.Generic;

namespace Game
{
  public class PingPong {

    public List<int> genNumber(int userEnteredNumber) 
    {
      List<int> generatedNumber = new List<int>(0);
      // print all the numbers upto the entered value
      for (int i = 1; i<= userEnteredNumber; i++) {
        generatedNumber.Add(i);
      }
      foreach(int element in generatedNumber) {
        Console.WriteLine(element);
      }     
      return generatedNumber;
    }

    public List<string> DoEverything(int userEnteredNumber) {
      List<int> generatedNumber = new List<int>(0);
      List<string> finalOutcome = new List<string>(0);
      // print all the numbers upto the entered value
      for (int i = 1; i<= userEnteredNumber; i++) {
        generatedNumber.Add(i);
      }
      foreach(int element in generatedNumber) {
        Console.WriteLine(element);
        if ((element%3 ==0) && (element%5 == 0)) {         
          finalOutcome.Add("ping-pong");
        }
        else if (element%5 == 0) {
          finalOutcome.Add("pong");
        }
        else if (element%3 ==0) {
          finalOutcome.Add("ping");
        }
        else {
          finalOutcome.Add(element.ToString());
        }
      }

 foreach(string element2 in finalOutcome) {
       Console.WriteLine(element2);
      }

      return  finalOutcome;

     

    }


  }
}