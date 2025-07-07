string message = "Hello , this is (Parenthesis)";
int length = message.Length;
string sub = message.Substring(17, length - 17);
Console.WriteLine("Substring: " + sub);