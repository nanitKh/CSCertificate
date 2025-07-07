void SayHello(string name)
{
    Console.WriteLine($"Hello {name}!");
}

//SayHello("Nanit");



//Generating random number with help of Methods

void generatingRandomNumber()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 101);
    Console.WriteLine($"Random number generated: {randomNumber}");
}


//generatingRandomNumber();

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/



if (validateLength() && validateZeroes() && validateRange())
{
    Console.WriteLine("IP Address is valid");
}
else
{
    Console.WriteLine("IP Address is invalid");
}

bool validateLength(decimal ip)
{
    string[] ipParts = ip.ToString().Split('.');
    return ipParts.Length == 4;
}



// Test method scope

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}