C# Learning Journy:

DAY 1:-

In the first day of our journy to learn C# we discuss several topics:-
1-Front and Back End in general and their programming langueges.
2-Visual studio code.
3-Solution and project.
4-Project Code structure.

#Front and Back End

I learn that In web development the front end refers to the user interface and what the user interact with,
but the back end involves the server side development and database.Also, each one use different programming langueges
for example we can use HTML, CSS and JavaScript and all these langueges used in Front-End Framework. 
However, we can use C#, PHP and visual basic and we use it in Back-End Framework.and in our journy we will focus in C#.

C# is one of the programming language developed by Microsoft. it is desigend for bulding variety of 
application in .NET framework including desktop, web and mopile applocation in addetion 
C# is a cross-platform which can run in multiple platform including Windows, IOS and Linux.

#Visual Studio Code

In this section we learned how to install the packeges of C# and create a new project and choose the 
platforms and project type.

#Solution and project

Solution is the one thing that i learn in the first day and I found it interesting and I will explain why.
So solution is like a container or wrapper for big projects, it is include web app, desktop app and mopile app 
so we can create many project inside one solution. thts mean we can build one code can run for many projects.

#Project  Code Structure

Project in C# always contain four importent things:-
* NameSpace: name of the project.
* Class Program.
* Main():each project should has one Main() only.
* Console:line commend interface used to interact with the user in other word it is a text
interface where user can enter data.

At the end of the lecture we practiced writing the project code structure.


DAY 2:-

In the second day of our journy to learn C# we discuss several topics:-
1-Commen Type System
2-Expression and Comparison Operators 
3-Logical Operators 
4-Ternary operator

#Commen Type System

I learn that Commen Type System (CTS) divided into two data type , Value Type and Reference Type.
I will explain the different between them.

*Value Type: data of known size like numbers such as age or phone number also true and false value
and these data stored in Stack which hase a limitid size of memory. 
(bool - byte - int - float - long - double)

*Reference Type: data of unknown size like discreption and names and these data stored in a stack 
inside the Heap which the name identifier save in stack and the value sve in heap and the 
variable indicate to the value location.
(String - Class - Object - Interface)

=> Every data type balong to Object
=>(CLS)==> Commen Language System==> its a commen factor between programming languages in .NET
 so that we can use all this languages of this framework in one project.

#Expression and Comparison Operators

In this section we learn about Comparison operators types in C# but before I will tell you about 
String Concatenation which we can use it when we need to connect variables togather 
and there is two ways to write it .

*Regular Concatenation( plus sign ):-
String FirstName = "Asma";
String LastName = "Alharrasi";
String FullName = ( " My full name is : " + FirstName  +" " + LastName );  

*String interpolation:-
String FullName = ($”My full name is : {FirstName} {LastName} ");

Now I will Explain what I understand about Expression so basicly 
Expression is combination of things like numbers, variables and operators that when you put them
togather will give us a single result for example x - b are combination of variables and operator and the 
result is the sub of the value you stored in the variableas.

However the Comparison Operators in C# are used to compare batween values and return a boolean result
(False or True) also used in conditional statments and expresion. Commen Comparison Operators include:-
* == (Equel to)
* != (NotEquel to)
* > (Greater than)
* < (Less than)
* >= (Grater than or Equel to)
* <= (Less than or Equel to)
==> I write an examples in the code file.

#Logical Operators 

Within this segment I learn the types of Logical Operators and the diffirent between each type 
also where we can use them.Therefore, the Logical Operators are used to perform logical operations on
boolean expresion (True or False) and these operators are also used for complex condition.
commen Logical Operators include:-
* AND (&&) if one operand is false return false.
0 x 0 = 0 
0 x 1 = 0      0==> False
1 x 1 = 1      1==> True
1 x 0 = 0

*OR ( || ) if one operand in true return true.
0 + 0 = 0 
0 + 1 = 1      0==> False
1 + 1 = 1      1==> True
1 + 0 = 1

*NOT ( ! ) negative value of its operand.
!false==> true
!true==>false

*XOR ( ^ ) if two operand are the same return false.
0 xor 0 = 0 
0 xor 1 = 1      0==> False
1 xor 1 = 0      1==> True
1 xor 0 = 1

==> Short circle logical operator (& - | ):-
&& - || compiler does not copmlete the full expretion it stop when get one true or false then break the line.
& - | compiler complete all lines to satisfy the expresion.
==>I write an examples of logical operators in the code file.

#Ternary Operator

we used ternary operator to evaluate a boolean expression and return one of two values (True or False)
and it called ternary becuase it include three operands the condition  and two expression one to return
true value and the other one to return the fulse value.
==> syntax : variable = (condition) ? expression1 : expression2 ;


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

there in such of shortcats that make writing a code very easy, saving time and effort, including:
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




















  


