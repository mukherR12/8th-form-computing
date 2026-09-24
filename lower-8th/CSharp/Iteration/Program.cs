/* 1. 

Translate the following Python loops into C#:

for i in range(num):          print(i)
for i in range(1, num + 1):   print(i)
for i in range(num, 0, -1):   print(i)
for i in range(0, num, 2):    print(i)

*/
const int NUM = 5;
for (int i = 0; i < NUM; i++)
{
    Console.WriteLine(i);
}

for (int i = 1; i <= NUM; i++)
{
    Console.WriteLine(i);
}

for (int i = NUM; i > 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < NUM; i+=2)
{
    Console.WriteLine(i);
}

// 2. 
// Predict the output 

for (int i = 0; i < 5; i++)  Console.WriteLine(i); // 0 1 2 3 4
for (int i = 0; i <= 5; i++) Console.WriteLine(i); // 0 1 2 3 4 5
for (int i = 5; i < 5; i++)  Console.WriteLine(i); // 
for (int i = 0; i < 10; i++) { Console.WriteLine(i); i = i + 2; } // 0 3 6 9

int n = 3;
for (int i = 0; i < n; i++) { n--; Console.WriteLine(i); } // 0 1

int k = 0;
while (k < 0) { Console.WriteLine("while"); k++; } // 
do { Console.WriteLine("do"); k++; } while (k < 0);

/* 3. 
Using foreach, count how many vowels are in sentence. Work out the expected answer by hand first.

Try writing your condition as c == "a" and read the error message. Why does c == 'a' work but "a" doesn't?
Now make it count capitals too, without listing ten characters. (Look at char.ToLower.)
*/
string sentence = "The quick brown fox jumps over the lazy dog";
int count = 0;

char[] vowels = "aeiou".ToCharArray();
foreach (char c in sentence)
{
    if (vowels.Contains(c))
    {
        count++;
    }
}
Console.WriteLine(count);
/* 4. 
Using a for loop, add up the integers from 1 to s (hard-code s = 4) into an int called total, then calculate the mean.

a. Print total / n. Is it what you expected? Explain what C# has done.
b. Fix it so the mean is 2.5. There are at least two ways: changing a type, or a cast (double)total / n. Does (double)(total / n) also work? Why not?
c. Repeat with a double running total that adds 0.1 ten times. Print it. Is it exactly 1.0?
*/

/* 5. 
How big is a number? (blue)

Using a for loop and an int accumulator, print 1!, 2!, … up to 25! (each on a line as "n! = ...").

a. Look down the list. Where does it stop being right? How can you tell?
b. Change the accumulator to a long and run it again. Where does it go wrong now?
c. Look up the largest values an int and a long can hold and check they agree with what you saw.
Extension: wrap the multiplication in checked(...) and see what happens instead. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/checked-and-unchecked
*/

/* 6. 
Using do … while, keep asking the user for a whole number between 1 and 10 until they give you one. 
This is allowed to use Console.ReadLine(). Use int.TryParse(input, out int value) so that typing 
banana doesn't crash it. Why is do … while the natural loop here rather than while?
*/

/* 7. 
For a hard-coded s = 4, print:

A
AB
ABC
ABCD

Build each line up in a string with += inside a nested loop, and print it once per row. 
To get the letters, use (char)('A' + i). Try it without the (char) and explain what you see.

Now print the triangle the other way up.
Extension: do the same with new string('*', i) and no inner loop. Which of the star questions 
on the main sheet does that make easier?
*/



