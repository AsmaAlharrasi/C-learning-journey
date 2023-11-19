C# Learning Journy

DAY 3:-

In the third day of our journy to learn C# we discuss several topics:-
1-Casting.
2-Increment and Decrement
3-Shortcuts

#Casting 

In C# casting refers to converting a value from one data type to another and there is tow type of casting:-

*implicit casting ==> casting from lower size data to a higher size data ,example:
int number_of_days = 90;
long ssn = number_of_days; 
Console.WriteLine(ssn);
==> here an example of implicit casting where we convert int(lower sive) to long (higher size).

*explicit casting==> casting from higher size data to a lower size data ,example:
 double payment = 150.500;
 int real_payment = (int)payment; 
 Console.WriteLine(real_payment);
==> here an example of explicit casting where we convert double (higher sive) to int(lower size).

==>More examples:-
float salary = 34.98f; // use ( f) to casting from double to float.
decimal bayment = 120.99m; // use (m) to casting from double to decimal.

#Increment and Decrement

Increment and Decrement is one of most important Topics in Programming it means that 
you want to increase or decrease the value of a variable by a specified amount and 
it divided into two  category:-

*Postfix==> the operator follow its operands that is mean the postfix increment or decrement
operator (++ or --) is used to increment or decrement the first value 
after it is assigned second value,example:
int z = 1;
Console.WriteLine(z++); //print 1
Console.WriteLine(z); //print 2

*prefix==> the operator precedes its operands that is mean the prefix increment or decrement
operator (++ or --) is used to increment or decrement the first value 
before it is assigned second value,example:
int a = 1;
Console.WriteLine(++a); //print 2
Console.WriteLine(a); //print 2

#Shortcuts

there is such of shortcats that make writing a code very easy, saving time and effort, including:

// ==> One line comment
/*  */ ==> Multiline comment
\t ==> Tap ( 8 spaces)
\n ==> New line (Enter)
Ctrl+K+C ==> Comment
Ctrl+K+U ==>Uncomment
CW+Tap ==> Console.WriteLine
#Regoin  #EndRegoin ==> Close a specific code
Alt+Arrows ==> Move specific code
$ ==> ($"s1 value :  {s1}"); we put $ in the begining to write value inside the string text 
but we should write the value inside curly prases {} 




















  


