# Linh Nguyen
## Homework C# 03

1. What is a method?  

	A method is a named sequence of statements.  

2. (Not in book) What is the difference between a function and a procedure/subprocedure/subroutine? 

	A function is used to calculate result using given inputs. 
	A procedure is used to perform certain task in order. 

3. What does a return statement do?  

	To make method to return information (that is, its return type is not void) 

4. What is an expression bodied method?  

	an expression-bodied method is merely a syntactic convenience. 

5. What is the scope of a variable?  

	Simply the region of the program in which that variable is usable. 

6. What is an overloaded method? 

	If two identifiers have the same name and are declared in the same scope. Can only return with different parameters list. 

7. How do you call a method that requires arguments?  

	Overloading methods. Write the name of the method followed by any arguments between parentheses. 

8. How do you write a method, that is, specify the method definition, that requires a parameter list? 

	Return type , name, parameter lists (even if it is void it has to have a return type), and the body 

9. How do you specify a parameter as optional when defining a method?  

	When you define a method by providing a default value for the parameter. Provide a default value for the parameter in the method declaration, by using assignment operator. 

10. How do you pass an argument to a method as a named parameter? 

	you specify the name of the parameter, followed by a colon and the value to use.  

11. How do you return values from a method? Can you return multiple values from a method, and if so, how?  

	A statement with the return keyword followed by a value that matches the return type will return that value to the method caller.(Write a return statement within the method.). Yes, Tuple. 
	
12. What is a tuple? How do you define a method that returns multiple values? Give an example of a method that returns multiple values other than the example in the book.  

	A tuple is simply a small collection of values, specifying a list of types as part of the method definition; one type for each value returned. Use a bare list in partheses to return multiple values (int, int). 


13. Examine the method definition on page 83 of the book. Desk check the execution of this method. What do you discover? This is called recursion.  

	Where a method call a method. One step: check to see if you finish, second step: if not finish, call it again with a change value. 


14. How does the compiler resolve an ambiguity between named arguments and optional parameters? 

	The compiler can distinguish between the methods because they have different parameter lists. 

 15. The book states: “A key feature of C# and other languages designed for the .NET Framework is the ability to interoperate with applications and components written with other technologies.” What is the COM and how is the CLR dependent on the COM?  

	Component Object Model (COM). COM does not support overloaded methods; instead, it uses methods that can take optional parameters. 