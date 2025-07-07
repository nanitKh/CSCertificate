string pangram = "The quick brown fox jumps over the lazy dog";

string []reversed = pangram.Split(' ');
foreach(string word in reversed)
{
    char[] chars=word.ToCharArray();
    Array.Reverse(chars);
    Console.Write(new string(chars)+" ");
}