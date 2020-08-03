# Linh Nguyen
## Homework C# 05

1. What is a compound assignment operator? How does it work?
	
	Combine the assignment operator and the arithmetic operator. Sum += update is equal to sum = sum + update;

2. List all the compound assignment operators.
	
	*= : multiply
	/= : Division
	%= : Modulo
	+= : add
	-= : subtract

3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by
50.
	
	console.writeline(value + 5)  or value += 5
	console.writeline(value - 5) or value -= 5 

4. How long does a while loop run?
	
	Run until the Boolean expression evaluates to false.

5. What is an iteration variable? (Not in book)
	
	variable that is changed each iteration of the loop. Use common letters j, k , i to control the
iterations in these loops. Contain the Test value.

6. What happens if you don’t change the loop variable in the body of the while loop block?
	 
	 You will have an infinite Loop.

7. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of
them? What happens if you omit all of them?
	
	3 parts: initialization, end condition and ieration update, you can omit any of the 3. 
	If you omit the Boolean expression, it defaults to true, so the following for statement runs forever.
	

8. How do you guarantee that a loop runs at least once?
	
	Use "do" statement :  its Boolean expression is evaluated after each iteration, so the
body always executes at least once.

9. What does the break statement do?
	
	To jump out of the body of an iteration statement. When you break
out of a loop, the loop exits immediately, and execution continues at the first statement that
 follows the loop.

10. What does the continue statement do?
	
	causes the program to perform the next iteration of the loop
 immediately (after reevaluating the Boolean expression)

11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An
“infinite loop” is a loop without an update variable that in effect runs forever. As you will see, these
kinds of loops are written intentionally to perform various kinds of tasks.

	For a web server, listen for incoming HTTP request and then handle the request and then repeat/keep on checking.
