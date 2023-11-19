C# Learning Journy

DAY 4:-

In the fourth day of our journy to learn C# we discuss several topics:-
1-Array.
2-Condition.

#Array

within this portion we learn about Array and it types and hoe we write a code for each type so the Array 
is a collection of elemnts of the same data type stored in the memory location.Howevere
Array is a Reference Type so the values stored in Heap as a block together and we can acsses to
the elements by index.

==> we put a variable inside the array to make it flexibale for the user to enter any number of value

==> Declaration Rule for Array:

<DataType>[ ]<varname> = new <DataType [size]>;
string[ ] name = new string[2];
name[0]= "Asma";//initialization
name[1]="Sara"; //initialization

Declaration and initialization in one line:
int[ ] number = new int[3] {3,5,8} ;

Array Type:
-One Dimensional Array
-Multi Dimensional Array
-Jagged Array

1-One Dimensional Array:

string[] names = new string[3];
names[0] = "Asma";
names[1] = "Sara";
names[2] = "Ahmed";
Console.WriteLine("your name is : " + names[2]);

2-Multi Dimensional Array: it is an Array with multi rows and columns dimension.

int[ , ] Grades = new int[2,2]; // 2 raws , 2 columns 
Grades[0, 0] = 1;
Grades[0, 1] = 2;
Grades[1, 0] = 1;
Grades[1, 1] = 3;

3-Jagged Array: a jagged array is an array inside an array or a main array that has a 
collection of arrays inside it  and each array has a different size or number of elements.

string[ ][ ] colors = new string[3][ ];
colors[0] = new string[1] { "red" };
colors[1] = new string[4] { "blue", "white", "orange", "black" };
colors[2] = new string[3] { "gray", " orange", "green" };
Console.WriteLine("color: " + colors[1][2]); //acsses data
acsses data :
[1] ==> index of main array 
[2]==> indext of array collection 
acsess the second elemnt in the secend array

==>Slicing Array:-
used to destructing your Array into smaller section by using Rang Operator [from..to]
[1,2,3,4]==>Array
slice[1..3]==>{2,3}==>skipping the first element
slice[..3]==>{1,2,3}==>start from first element
slice[2..]==>{3,4}==>to the last element

==>Array should has size

#Condition

we leran in this section that we have three types of condition:
-If 
-If else
-Switch
-Ternary
but in Day 4 we just learn about if  and if else only so i will explain it now.

==> if condition
in C# the if condition is a conditional ststment that allow you to execute a block of  code
based on a specific condition the basic syntax of an if statment is :
if (condition)
{
         // code to execute if the condition is true
}

==> if else condition
In C# the if else condition allow you to create a branching structure based on a condition.
if the conditionspecified in the if statment is true the code block inside the if will executed 
otherwise the code block inside the else will executed.
if (condition)
{    
        //code execute if te condition is true
}

else

{
       //code execute if the condition in false
}  

==>if else condition Example:

Console.WriteLine("hello please enter student grade:");
int value = Convert.ToInt32(Console.ReadLine());
if (value >= 80)
{
    Console.WriteLine("Sucssed");
}

else

{
    Console.WriteLine("failed");
}












