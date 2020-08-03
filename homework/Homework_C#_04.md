# Linh Nguyen
## Homework C# 04

1. What are all possible values of Boolean expression?  

	True or False 

2. List the equality operators. List the relational operators. List the logical operators. How are they the same? How are they different?  

	== : equal to, != : not equal to, <, <=, >, >=.  Both are to see if the values are true or false. Logical operator AND, OR, NOT. 
	Equality operator determine whether one value is the same as another value of the same type 
	Relational Operators find out whether a value is less than or greater than another value of the same type 

3. What is the general concept of short circuiting? This question has a short and simple answer and you do not need to have a detailed response. 

	&& and || operators bypass the evaluation of the right operand. Look at the left hand operand if it an AND operator and Left side is FALSE it does not evaluate the equation. 

4. What are the difference in how short circuiting works for && and ||?  

	&& equal to false, || equal to true 

5. Look at the list of operators. What operator has the highest precedence? Which has the lowest?  

	HIGHEST : ()  : Precedence Override, ++ : Post-increment, --: Post-decrement 

	LOWEST : = : assignment  

6. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?  

	Group the statements inside a block (method) 

7. In a switch statement, what happens if you omit break? 

	If we do not use break statement at the end of each case, program will execute all consecutive case statements until it finds next break statement or till the end of switch case block 

8. The four keywords in a switch statement are switch, case, break, and default. Explain what each keyword does.  

	Switch : It specify a pattern to match. 
	Case: The case statement defines a pattern to match the match expression. 
	Break: Used to break the flow of the code within cases. Exit the switch function. 
	Default: Specifies some code to run if there is no case match 

9. Look at the source listing below. It contains two methods: recurr1() and recurr2(). There is a significant difference between the two methods. What is it?  

	recur = recurr2 (1 , initial );  Have 2 parameters.  Every step of the way it calculate the return value of the product. 

10. (Not in book) What is a recursive method? Using a language you know (such as English), write a recursive method that adds up the integers in a list of integers. The input to the method is a list of integers and the output is a scalar value representing a sum.  

	A method or algorithm that invokes itself one or more times with different arguments. 


11. (Not in book) Read a short summary of De Morgan’s laws. (a) Explain how this statement, ”It’s not snowing or raining,” is the same as this statement, ”It’s not snowing and it’s not raining.” (b) Explain how this statement, ”I’m not running and walking,” is the same as this statement, ”I’m not running or I’m not walking.” 

	relation between sets and their complements 
	Not (A or B) is the same as Not A and Not B. 
	Not (A and B) is the same as Not A or Not B. 