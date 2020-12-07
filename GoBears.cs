class MainClass {
  public static void Main (string[] args) {
    for(int i = 1; i <= 100; i++){
      if( i % 5 == 0 && i % 3 == 0){
        Console.WriteLine("MSUBears");
      }
      if(i % 5 == 0){
        Console.WriteLine("MSU");
      }
      if(i % 3 == 0){
        Console.WriteLine("Bears");
      }
      else {
        Console.WriteLine(i);
      }
    }
  }
}
