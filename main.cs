using System;

class MainClass {
  public static void Main (string[] args) {
    double height;
    double weight;
    double BMI;
    for (int count = 0; count <10; count++){
      Console.WriteLine("Enter your height in inches");
      height = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter your weight in pounds");
      weight = Convert.ToDouble(Console.ReadLine());
      BMI = CalculateBMI(weight,height);
      BMIResults(BMI);
    }
  }
  public static double CalculateBMI(double weight , double height){
     double BMI = Math.Round((703 * weight) / (height * height), 2);
     return BMI;
  }
  public static void BMIResults(double BMI){
    if (BMI < 18.5){
       Console.WriteLine("Underweight");

     }
     else if ((BMI >= 18.5) && (BMI <= 24.9)){
        Console.WriteLine("Normal");
     }
      else if ((BMI >= 25) && (BMI <= 29.9)){
        Console.WriteLine("Overweight");
     }
     else {
        Console.WriteLine("Obese");
     }
  }
}