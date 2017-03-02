// Uses DisplayWebAddress method three times
using static System.Console;
class DebugSeven1
{
   static void Main()
   {
      DisplayWebAddress();
      DisplayWebAddress();
      DisplayWebAddress();
   }
   private static void DisplayWebAddress()
   {
      WriteLine("------------------------------");
      WriteLine("Visit us on the web at:");
      WriteLine("www.shoppersworldbargains.com");
      WriteLine("******************************");
   }
}
