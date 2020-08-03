# Linh Nguyen
## Homework C# 07

1.What is a class? According to the book, what does a class “arrange?”
	
	A class is a TYPE. Called "Class" when you writing program, using "Type" when you using it. 	

2.What are the two purposes of encapsulation?

	To combine methods and data within a class; in other words, to support classification
	To control the accessibility of the methods and data; in other words, to control the use of
	the class

3.How do you instantiate an instance of a class? How do you access that instance?

	When you create an object, you are creating an instance of a class, therefore "instantiating" a class. Declaring a variable.
	returns a reference to the object it created. Often, this reference is assigned 
	to a variable of the appropriate type. 

4.What is the default access of the fields and methods of a class? How do you change the default?

	Private, you can explicitly state if the methods are public or private

5.What is the syntax for writing a constructor?

	Just add a public method that does not return a value and give it the same name as the class. 
	Does not have a return type, and have the same name as the class.

6.What is the difference between class fields and methods, and instance fields and methods? How do you
create class fields and methods?

	INSTANCE:
	You can only access instance variables and methods through AN INSTANCE of the class. You cannot access instance
	variables and emthods through the class.
	CLASS:
	You can only access class variables and methods through THE CLASS. 
	You cannot access class variables and methods through an instance.
	
7.How do you bring a static class in scope? Why would you want to bring a static class in scope?

	You can declare a method or a field as static. (using static)
	The purpose of a static class is purely to act as a holder of utility methods and fields
	
8.Can you think of a good reason to create an anonymous class? What is it?

	encapsulate a set of read-only properties into a single object without having to explicitly define
	a type first.
	An anonymous type is a type (class) without any name that can contain public
	read-only properties only. You create an anonymous class simply by using the new keyword and a pair 
	of braces defining the fields and values that you want the class to contain. 


9.What is polymorphism as this term is used in computer science? This is not in the book.

	Polymorphism is the ability of different objects to respond in a unique way to the same message
	Same method do different thing depend on the parameters in it. 

10.What is message passing as this term is used in computer science? This is not in the book.

	refers to the sending of a message to a process which can be an object, parallel process, subroutine, function or thread. 

11.What was the first object-oriented programming language?

	Simula (1967)

12.Consider this quote by Alexander Stepanov:
I find OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras
— families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting — saying that
everything is an object is saying nothing at all.
Who is Alexander Stephanov? What do you think about this quote?

	A computer scientist and the key person behind the C++ Standard Template Library.
	To solve real world problems you have to apply different type of interfaces to make the program
	work in real world. 
	 