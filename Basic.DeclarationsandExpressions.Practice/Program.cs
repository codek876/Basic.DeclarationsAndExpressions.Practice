/*
 * 48 Qestions
 * Basic Declarations and Expressions
 * w3resource
 */

//Q#1
//program to print Hello and your name in a separate line
/*
Console.WriteLine("Hello");
Console.WriteLine("Kevaughn Batchelor");
*/

//Q#2
//program to print the sum of two numbers.
/*
Console.WriteLine(20 +30);
*/

//Q#3
//program to print the result of dividing two numbers
/*
Console.WriteLine(20 / 4);
*/

//program to print the result of the specified operations
/*
int a, b, c, d;

a = -1 + 4 * 6;
b = (35 + 5) % 7;
c = 14 + -4 * 6 / 11;
d = 2 + 15 / 6 * 1 - 7 % 2;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
*/

//Q#5
//program to swap two numbers
/*
int first_num, second_num;

Console.WriteLine("-------------------------");
Console.Write("Input the first number: ");
first_num = int.Parse(Console.ReadLine());

Console.Write("Input the second number: ");
second_num = int.Parse(Console.ReadLine());
Console.WriteLine("-------------------------");
Console.WriteLine("First Number: {0}", second_num);
Console.WriteLine("Second Number: {0}", first_num);
*/

//Q#6
//Program to print the output of multiplication of three numbers which will be entered
//by the user
/*
int product1, product2, product3;
int result;

Console.WriteLine("--------------------------------------");
Console.Write("Input the first number to multiply: ");
product1 = int.Parse(Console.ReadLine());

Console.Write("Input the second number to multiply: ");
product2 = int.Parse(Console.ReadLine());

Console.Write("Input the third number to multiply: ");
product3 = int.Parse(Console.ReadLine());
Console.WriteLine("--------------------------------------");

result = product1 * product2 * product3;
Console.WriteLine("{0} x {1} x {2} = {3}", product1, product2, product3, result);
*/

//Q#7
//program to print on screen the output of adding, subtracting, multiplying and dividing
//of two numbers which will be entered by the user.
/*
int first_num, second_num;
int result;

Console.WriteLine("--------------------------------------");
Console.Write("Input the first number: ");
first_num = int.Parse(Console.ReadLine());

Console.Write("Input the second number: ");
second_num = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");

Console.WriteLine("{0} + {1} = {2}", first_num, second_num, result = first_num + second_num);
Console.WriteLine("{0} - {1} = {2}", first_num, second_num, result = first_num - second_num);
Console.WriteLine("{0} * {1} = {2}", first_num, second_num, result = first_num * second_num);
Console.WriteLine("{0} / {1} = {2}", first_num, second_num, result = first_num / second_num);
Console.WriteLine("{0} mod {1} = {2}", first_num, second_num, result = first_num % second_num);
*/

//Q#8
//program that takes a number as input and print its multiplication table
/*
int num, result;

Console.WriteLine("--------------------------------------");
Console.Write("Enter the number: ");
num = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");

result = num * 0;
Console.WriteLine("{0} X {1} = {2}", num, 0, result);

result = num * 1;
Console.WriteLine("{0} X {1} = {2}", num, 1, result);

result = num * 2;
Console.WriteLine("{0} X {1} = {2}", num, 2, result);

result = num * 3;
Console.WriteLine("{0} X {1} = {2}", num, 3, result);

result = num * 4;
Console.WriteLine("{0} X {1} = {2}", num, 4, result);

result = num * 5;
Console.WriteLine("{0} X {1} = {2}", num, 5, result);

result = num * 6;
Console.WriteLine("{0} X {1} = {2}", num, 6, result);

result = num * 7;
Console.WriteLine("{0} X {1} = {2}", num, 7, result);

result = num * 8;
Console.WriteLine("{0} X {1} = {2}", num, 8, result);

result = num * 9;
Console.WriteLine("{0} X {1} = {2}", num, 9, result);

result = num * 10;
Console.WriteLine("{0} X {1} = {2}", num, 10, result);
*/

//Q#9
//program that takes four numbers as input to calculate and print the average
/*
int first_num, second_num, third_num, fourth_num;
int average;

Console.WriteLine("--------------------------------------");
Console.Write("Enter the first number: ");
first_num = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
second_num = int.Parse(Console.ReadLine());

Console.Write("Enter the third number: ");
third_num = int.Parse(Console.ReadLine());

Console.Write("Enter the fourth number: ");
fourth_num = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");

average = (first_num + second_num + third_num + fourth_num) / 4;
Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}",
    first_num, second_num, third_num, fourth_num, average);
*/

//Q#10
//program to that takes three numbers(x,y,z) as input and
//print the output of (x+y).z and x.y + y.z
/*
int x, y, z;
int result1, result2;

Console.WriteLine("--------------------------------------");
Console.Write("Enter the first number - ");
x = int.Parse(Console.ReadLine());

Console.Write("Enter the second number - ");
y = int.Parse(Console.ReadLine());

Console.Write("Enter the third number - ");
z = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");

result1 = (x + y) * z;
result2 = (x * y) + (y * z);
Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3}" +
    " and x.y + y.z is {4}", x, y, z, result1, result2);
*/

//Q#11
//program that takes an age (for example 20) as input and
//prints something as "You look older than 20"
/*
int age;

Console.WriteLine("--------------------------------------");
Console.Write("What is your age - ");
age = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");
Console.WriteLine("You look older than {0}", age);
*/

//Q#12
//program to that takes a number as input and display it four times in a row
//(separated by blank spaces), and then four times in the next row, with no separation.
//You should do it two times
/*
int num;

Console.WriteLine("--------------------------------------");
Console.Write("Enter a number - ");
num = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");


Console.WriteLine("{0} {0} {0} {0}", num);
Console.WriteLine("{0}{0}{0}{0}", num);
Console.WriteLine("{0} {0} {0} {0}", num);
Console.WriteLine("{0}{0}{0}{0}", num);
*/

//Q#13
//program that takes a number as input and then displays a rectangle
//of 3 columns wide and 5 rows tall using that digit
/*
int num;

Console.WriteLine("--------------------------------------");
Console.Write("Enter a number: ");
num = int.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");
Console.WriteLine("{0}{0}{0}", num);
Console.WriteLine("{0} {0}", num);
Console.WriteLine("{0} {0}", num);
Console.WriteLine("{0} {0}", num);
Console.WriteLine("{0}{0}{0}", num);
*/

//Q#14
//program to convert from celsius degrees to Kelvin and Fahrenheit
/*
float num, result;
float kelvin = 273.15f, fahrenheit = 32.0f;
float fraction;

Console.WriteLine("--------------------------------------");
Console.Write("Enter a number: ");
num = float.Parse(Console.ReadLine());

Console.WriteLine("--------------------------------------");

//Convert fahrenheit fraction to decimal
fraction = 9.0f / 5.0f;

Console.WriteLine("Kelvin = {0}", result = num + (int)kelvin);
Console.WriteLine("Fahrenheit = {0}", result = (num * fraction) + fahrenheit);
*/

//Q15
//remove specified a character from a non-empty string using index of a character
/*
string str = "w3resource";

Console.WriteLine("--------------------------------------");

Console.WriteLine(str.Remove(1, 1));
Console.WriteLine(str.Remove(0, 2));
Console.WriteLine(str.Remove(3, 6));

Console.WriteLine("--------------------------------------");
*/

//Q#16
//create a new string from a given string where the first and last
//characters will change their positions
/*
public class FirstLastCharacter
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine(first_last("w3resource"));
        Console.WriteLine(first_last("Python"));
        Console.WriteLine(first_last("x"));
        Console.WriteLine("--------------------------------------");
    }
    public static string first_last(string ustr)
    {
        return ustr.Length > 1
            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2)
            + ustr.Substring(0, 1) : ustr;
    }
}
*/

//create a new string from a given string (length 1 or more ) with
//the first character added at the front and back.
/*
string str = "The quick brown fox jumps over the lazy dog.";
int position = 0;
char ch = 'T';

Console.WriteLine("-------------------------------------------------");

string placement = ch + str.Substring(position) + ch + str.Substring(str.Length);

Console.WriteLine(placement);
Console.WriteLine("-------------------------------------------------");
*/

//Q#18
//program to check two given integers and return true if one is negative and one is positive
/*
int num1, num2;

Console.WriteLine("-------------------------------------------------");
Console.Write("Enter a negative integer: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Enter a postive number: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("-------------------------------------------------");
Console.WriteLine((num1 < 0 && num2 > 0) || num2 < 0 && num1 > 0);
*/

//Q#19
//program to compute the sum of two given integers,
//if two values are equal then return the triple of their sum
/*
int a, b;
int sum;

Console.WriteLine("-------------------------------------------------");

a = 4;
b = 4;

sum = a == b ? (a + b) * 3 : a + b;

Console.WriteLine(sum);
*/

//Q#20
//program to get the absolute value of the difference between two given numbers.
//Return double the absolute value of the difference if the first number is greater
//than second number
/*
int a, b;
int result;

a = 10;
b = 5;

result = a > b ? Math.Abs(a*2) : Math.Abs(a - b);

Console.WriteLine(result);
*/

//Q#21
//Program to check the sum of the two given integers and return true
//if one of the integer is 20 or if their sum is 20
/*
int a, b;
int sum;

a = 5;
b = 10;

//sum = a == 20 || b == 20 || a + b == 20;

Console.WriteLine(a == 20 || b == 20 || a + b == 20);
*/

//Q#22
//Program to check if an given integer is within 20 of 100 or 200
/*
int a;

Console.WriteLine("Enter an integer: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Abs(a - 100) <= 20 || Math.Abs(a - 200) <= 20);
*/

//Q#23
//program to convert a given string into lowercase
/*
string str = "I AM A PROGRAMMER";

Console.WriteLine(str.ToLower());
*/

//Q#24
//program to find the longest word in a string
/*
string str = "Write a C# Sharp Program to display the following pattern using the alphabet.";

string[] strArray = str.Split(' ');

var largest = "";
foreach (var item in strArray)
{
    if(item.Length > largest.Length)
    {
        largest = item;
    }
}
Console.WriteLine(largest);
*/

//Q#25
//Program to print the odd numbers from 1 to 99. Prints one number per line.
/*

for (int i = 1; i <= 99; i++)
{
    if ((i % 2) == 1)
        Console.WriteLine(i);
}
*/

//Q#26
//Program to compute the sum digits of an integer
/*
int sum = 0;
int x;

Console.WriteLine("----------------------------");
Console.Write("Input a number: ");
x = int.Parse(Console.ReadLine());

Console.WriteLine("----------------------------");

while(x != 0)
{
    sum += x % 10;
    x = x / 10;
}
Console.WriteLine(sum);
*/

//Q#27
//program to find the size of a specified file in bytes
/*

string fileName = @"C:\Users\kevau\source\repos\Basic.DeclarationsandExpressions.Practice\Basic.DeclarationsandExpressions.Practice\fileSize.txt";

FileInfo fi = new FileInfo(fileName);

int length = fileName.Length;
long fileSize = fi.Length;
Console.WriteLine($"File size for 'fileSize' in bytes:  {fileSize}" );
*/

//Q#28
//program to convert a hexadecimal number to decimal number.
/*
string hexa_val;

Console.Write("Enter a Hexadecimal number: ");
hexa_val = Console.ReadLine();
Console.WriteLine("_______________________________");

int dec_val = Convert.ToInt32(hexa_val, 16);

Console.WriteLine($"The Hexadecimal {hexa_val}, decimal value is: {dec_val}");
*/

//Q#29
//program to multiply corresponding elements of two arrays of integers.
/*
int[] arr1 = {1, 3, -5, 4};
int[] arr2 = {1, 4, -5, -2};

Console.WriteLine("Array 1: {0}", string.Join(", ", arr1));
Console.WriteLine("Array 2: {0}", string.Join(", ", arr2));
Console.WriteLine("_______________________________");

Console.WriteLine("Multiply corresponding elements of two arrays:");
for(int i = 0; i < arr1.Length; i++)
{
    Console.Write($"{arr1[i] * arr2[i]} ");
    //Console.WriteLine();
}
Console.WriteLine();
*/

//Q#30
//program to create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one.
/*
string input;

Console.WriteLine("Input a string: ");
input = Console.ReadLine();
Console.WriteLine("____________________________________________________");

int string_length = input.Length;

if(string_length < 4)
{
    Console.WriteLine(input);
}
else
{
    string result;
    result = input.Substring(string_length - 4);

    Console.WriteLine(result + result + result + result);
}
*/

//Q#30
//program to check if a given positive number is a multiple of 3 or a multiple of 7
/*
int number;

Console.Write("Enter a positive number: ");
number = int.Parse(Console.ReadLine());
Console.WriteLine("________________________________");

if(number < 0){
    Console.WriteLine("The number {0} you entered is not positive.", number);
}
else if((number % 7 == 0) && (number % 3 == 0) ){
    Console.WriteLine("The number {0} you entered is a multiple of 3 and 7.", number);
}
else if((number % 7 == 0)){
    Console.WriteLine("The number {0} you entered is a multiple of 7.", number);
}
else if((number % 3 == 0)){
    Console.WriteLine("The number {0} you entered is a multiple of 3.", number);
}
*/

//Q#31
//program to check if a string starts with a specified word
/*
string input;

Console.Write("Input a string: ");
input = Console.ReadLine();
Console.WriteLine("_______________________________");

Console.WriteLine(input.StartsWith("Hello"));
*/

//Q#32
//program to check two given numbers where one is less than 100 and
//other is greater than 200
/*
int num1, num2;

Console.Write("Input a number less than 100: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("-------------------------------");
Console.Write("Input a number less than 200: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("_______________________________");

Console.WriteLine("Input a first number(<100): {0}", num1);
Console.WriteLine("Input a second number(>200): {0}", num2);
Console.WriteLine((num1 < 100) && (num2 > 200));
*/

//Q#33
//program to check if an integer (from the two given integers) is in the range -10 to 10
/*
int x, y;

Console.Write("Input the first number: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("-------------------------------");
Console.Write("Input the second number: ");
y = int.Parse(Console.ReadLine());
Console.WriteLine("_______________________________");

Console.WriteLine("Your input are {0} and {1}", x, y);
Console.WriteLine((x >= -10 && y <= 10));
*/

//Q#34
//program to check if "HP" appears at second position in a string and returns the string without "HP"
/*
string str;

Console.Write("Input a string: ");
str = Console.ReadLine();

Console.WriteLine("_______________________________");

Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
*/

//Q#35
//program to get a new string of two characters from a given string. The first and
//second character of the given string must be "P" and "H", so PHP will be "PH"
/*
string str;

Console.Write("Input a string: ");
str = Console.ReadLine();

Console.WriteLine("_______________________________");

Console.WriteLine(str.Substring(0, 2).Equals("PH") ? str.Remove(2) : str);
*/

//Q#36
//program to find the largest and lowest values from three integer values
/*
int inta, intb, intc;
int largest = 0;
int lowest = 0;

Console.Write("Input first integer: ");
inta = int.Parse(Console.ReadLine());
Console.Write("Input second integer: ");
intb = int.Parse(Console.ReadLine());
Console.Write("Input third integer: ");
intc = int.Parse(Console.ReadLine());

Console.WriteLine("_________________________________________________");

if (inta > intb && inta > intc)
{
    largest = inta;
}
else if (intb > inta && intb > intc)
{
    largest = intb;
}
else{
    largest = intc;
}

if (inta < intb && inta < intc)
{
    lowest = inta;
}
else if (intb < inta && intb < intc)
{
    lowest = intb;
}
else{
    lowest = intc;
}

Console.WriteLine("The largest and lowest of three numbers are:");
Console.WriteLine($"{largest} and {lowest}");

//OR

Console.WriteLine(Math.Max(inta, Math.Max(intb, intc)));
Console.WriteLine(Math.Min(inta, Math.Max(intb, intc)));
*/

//Q#37
//program to check if a given string contains ‘w’ character between 1 and 3 times
/*
string str;

Console.WriteLine("_________________________________________________");
Console.WriteLine("Check if a given string contains 'w'");
Console.WriteLine("character between 1 and 3 times");

Console.WriteLine();

Console.Write("Input a string: ");
str = Console.ReadLine();

Console.WriteLine("_________________________________________________");

var amt = str.Count(p => p == 'w');

Console.WriteLine( amt <= 3 && amt >= 1);
*/

//Q#38
//program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case.
/*
string str = "IamAStringOfCharacters";
//str = "w3r";

Console.WriteLine(str.Length > 4 ? str.Substring(0,4).ToLower() + str.Substring(4, str.Length -4) : str.ToUpper());
*/

//Q#39
//program to check if a given string starts with "w" and immediately followed by two "ww"
/*
string str = "wwwkuhriuh44fifuehn";

Console.WriteLine(str.StartsWith("w") && str.Substring(1, 2).Equals("ww"));
*/

//Q#40
//program to compute the sum of all the elements of an array of integers
/*
int[] array =  {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
int sum = 0;

foreach(var arr in array){
    sum = sum + arr;
}
Console.WriteLine($"The sum of the array [{string.Join(',', array)}] is {sum}");
*/

//Q#41
//program to check if the first element and the last element 
//are equal of an array of integers and the length is 1 or more
/*
int[] array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
int[] array2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};

Console.WriteLine(array1[0].Equals(array2[0]) || array1[array1.Length - 1].Equals(array2[array2.Length - 1]) || (array1.Length >= 1 && array2.Length >= 1));
*/

//Q#42
//program to count a specified number in a given array of integers
/*
int[] array = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
int num;

Console.Write("[");
Console.Write(string.Join(',', array));
Console.WriteLine("]");

Console.Write("Input an integer from The list of number above: ");
num = int.Parse(Console.ReadLine());

Console.WriteLine($"The integer you entered '{num}' and its counted: {array.Count(x => x == num)} times");
*/

//Q#43
//program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more
/*
int[] array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
int num;

Console.Write("Input integer to check if ts at the ned or last of the array: ");
num = int.Parse(Console.ReadLine());

Console.WriteLine(array1[0].Equals(num) || array1[array1.Length - 1] == num);
*/

//Q#44
//program to rotate an array (length 3) of integers in left direction
/*
int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18};
int length = arr.Length;
int temp = arr[0];

for(int i = 0; i < length - 1; i++)
{
    arr[i] = arr[i + 1];
}
arr[length - 1] = temp;

Console.WriteLine(string.Join(',', arr));
*/

//Q#45
//program to get the larger value between first and last element of an array (length 3) of integers
/*
int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 2};
int len = arr.Length;

var hval = arr[0];

for (var i = 0; i < len; i++)
{

    if(arr[i] > hval)
    {
        hval = arr[i];
    }
}
Console.WriteLine(hval);
*/

//Q#46
//program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
/*
int[] arr1 = {1, 2, 5};
int[] arr2 = {2, 4, 6};
int[] arr3 = {4, 8, 16};

Console.WriteLine($"[{arr1[1]}, {arr2[1]}, {arr3[1]}]");
*/

//Q#47
//program to check if an array contains an odd number.
/*
int[] arr = {2, 4, 7, 8, 6};

for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 1)
        Console.WriteLine(true);
}
*/

//Q#48
//program to check if a given string is a palindrome or not
/*
string str = "aaaaa";
string reverseString = "";
foreach (var letter in str)
{
    reverseString = letter + reverseString;
}

if(str == reverseString)
{
    Console.WriteLine(true);
}
else{
    Console.WriteLine(false);
}
*/