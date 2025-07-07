//float n1 = 2.345f;
//float n2 = 0.0f;
//int num1 = 234;
//int num2 = 0;

//try
//{

//    Console.WriteLine(n1 / n2);
//    Console.WriteLine(num1 / num2);
//}
//catch(Exception e)
//{
//    Console.WriteLine("You cannot divide any number by 0");

//}

//Console.WriteLine("Program continues");


//try
//{
//    Process1();
//}
//catch
//{
//    Console.WriteLine("An exception has occurred");
//}

//Console.WriteLine("Exit program");

//static void Process1()
//{
//    try
//    {
//        WriteMessage();
//    }
//    catch(Exception e)
//    {
//        Console.WriteLine("The exception has been occured in process 1"); 
//    }
//}

//static void WriteMessage()
//{
//    double float1 = 3000.0;
//    double float2 = 0.0;
//    int number1 = 3000;
//    int number2 = 0;

//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}


//string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

//foreach (string inputValue in inputValues)
//{
//    int numValue = 0;
//    try
//    {
//        numValue = int.Parse(inputValue);
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Invalid readResult. Please enter a valid number.");
//    }
//    catch (OverflowException)
//    {
//        Console.WriteLine("The number you entered is too large or too small.");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}


//Custom exception throwing example
ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
throw invalidArgumentException;