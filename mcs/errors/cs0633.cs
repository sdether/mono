// cs0633.cs: The argument to the `System.Runtime.CompilerServices.IndexerNameAttribute' attribute must be a valid identifier
// Line: 5

public class MonthDays {
   [System.Runtime.CompilerServices.IndexerName ("buggypo for you")]
   public int this [int a] {
      get {
         return 0;
      }
   }

   public static void Main ()
   {
	int i = new MonthDays () [1];
   }
}


