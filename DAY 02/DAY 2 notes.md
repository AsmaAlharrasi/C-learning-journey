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

 == (Equel to)
 != (NotEquel to)
 > (Greater than)
 < (Less than)
 >= (Grater than or Equel to)
 <= (Less than or Equel to)
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