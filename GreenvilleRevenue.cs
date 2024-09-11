using System;

class Program {
  public static void Main (string[] args) {
    int menuInput;
    int ticketPrice = 25;
    do{
      Console.WriteLine ("************************************");
      Console.WriteLine("*  The stars shine in Greenville.  *");
      Console.WriteLine ("************************************\n");
      Console.WriteLine("Please Enter the following number below from the following menu:\n");
      Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year\n2. Exit");
      menuInput = Convert.ToInt32(Console.ReadLine());
      switch(menuInput){
      case 1:
        Console.Write("Enter the number of contestants of the previous year: ");
        int lastYearCont =Convert.ToInt32(Console.ReadLine());
        for (int i=0; i<1; i++){
          if (lastYearCont > 30 || lastYearCont <0){
            Console.WriteLine("The maximum number of contestants is 30, please enter a valid number");
            lastYearCont = Convert.ToInt32(Console.ReadLine());
            i--;
          }
        }
        Console.Write("Enter the number of contestants of the current year: ");
        int thisYearCont =Convert.ToInt32(Console.ReadLine());
        for (int i=0; i<1; i++){
          if (thisYearCont > 30 || thisYearCont <0){
            Console.WriteLine("The maximum number of contestants is 30, please enter a valid number");
            thisYearCont = Convert.ToInt32(Console.ReadLine());
            i--;
          }
        }
        int revenueExpectation = ticketPrice*thisYearCont;
        Console.WriteLine("\nLast year's competition had {0} contestants, and this year's has {1} contestants.", lastYearCont, thisYearCont);
        Console.WriteLine("\nRevenue expected this year is ${0}.\n", revenueExpectation);
        if (lastYearCont*2 < thisYearCont){
          Console.WriteLine("The competition is more than twice as big this year!\n");
        }
        else if (lastYearCont< thisYearCont){
          Console.WriteLine("The competition is bigger than ever!\n");
        }
        else if (lastYearCont> thisYearCont){
          Console.WriteLine("A tighter race this year! Come out and cast your vote!\n");
        }
        else if(lastYearCont ==thisYearCont){
          Console.WriteLine("The competition is that same size as last year!\n");
        }
        
      break;
      case 2:
        Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
      break;        
      }
    }
    while (menuInput != 2);
     
    }

  }

