# Linh Nguyen
## Homework C# 06

1.What is an exception?

	A problem that arises during the execution of a program.

2.What happens in a try block if the program executes without errors?

	All statements run one after another til completion.

3.How does the catch mechanism work for unhandled exceptions?

	The method immediately exits and execution returns to the calling method, where the process is repeated.
	And throw to the next higher block.

4.What happens in a program if an exception block fails to handle an particular error?

	If  the runtime is unable to find a matching catch handler, the program will terminate with an unhandled exception

5.What is the parent class for all exceptions? How does this work?

	Exception, if you catch Exception, the handler traps every possible exception that can occur.

6.How do you determine the type of an error?

	Exception.Message Property gets a message that describes the current exception.

7.What is the purpose of integer checking?

	To check the integer overflow if the interger is outside the range and signed number change place.

8.What is the range of values that a signed Int32 type can contain? State the lowest value and the
highest value.

	Lowest: -2,147,483,648 to Highest: 2,147,483,647

9.What is the range of values than an unsigned Int32 type can contain? State the lowest value and the
highest value. What is the difference between a signed integer and an unsigned integer? Can signed
integers and unsigned integers represent the same amount of numbers?

	Lowest: 0 to Highest: 4,294,967,295. Unsigned Int cannot be negative and have a higher range of positive values,
	while signed Int can be negative but has a lower positive range. No.

10.What does the finally block do?

	Statements that are always executed, regardless of unexpected events or exceptions that may occur during an application's execution. 
	
11.(Thought question) When would you not use a finally block in a try/catch construction?

	When you want to check if the exception is handled or not. 
