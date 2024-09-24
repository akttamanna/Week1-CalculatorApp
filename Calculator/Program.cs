
//int firstNumber = 5;

//int secondNumber = 20;

//int result = firstNumber + secondNumber;

//Console.WriteLine("The addition of the 2 numbers is {0}" , result);
//Console.ReadKey();

CalculatorApp();

void CalculatorApp() {


    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;

    //First Number taken from user

    Console.WriteLine("Type in the first number followed by the Enter key");
 firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number followed by the Enter key");
 secondNumber = Convert.ToInt32(Console.ReadLine());

//Calculation result
 result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);

 

}