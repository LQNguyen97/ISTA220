# Linh Nguyen
## Homework C# 13


1.What is an interface as the term is used on object-oriented programming?

	**An interface separate the whats from the hows.**
	By using an interface, you can completely separate the names and signatures of the methods of a class from the method’s
	implementation.

2.How do you define an interface?

	"Interface  + Name"
	As a method signature with no implementation

3.Can an interface have variables, fields, or properties?

	Interface does not have fields in other words we can't declare variables in an interface.

4.How do you define a method in an interface?

	It is used to provide total abstraction. All member in the interface are declared with the empty body and 
	are public and abstract by default.
	Replace implementation with just a semi colon. 

5.Can you instantiate an object through an interface? Why or why not?

	YES. 

6.Using the new keyword, can you declare a reference to an interface?

	YES, we can make reference of it that refers to the object of its implementing class.

7.Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how
can it do so?

	Yes. Classes can have multiple interfaces
	It must provide the implementation of all the members of all interfaces and separate them with a comma.

8.What does it mean to explicitely implement an interface?

	Explicitly telling the compiler that a particular member belongs to that particular interface
	Reference the method through appropriate interface.

9.What are the restrictions on interfaces?

	It cannot contain constant, fields, operators, instances constructors or types nor can an interface contain static
	members of any kind.

10.What is the difference between an abstract class and an interface?

	An abstract class needs to come from a derived class and interface is what the user sees.
	**Abstract class can contain implementation, but interface cannot contain implementation.**

11.What is an abstract method?

	Is a method without a body. It is done by retrieving it from the derived class.

12.What is an sealed class?

	Used to restrict the inheritance features of object oriented programming. Once class is defined as a sealed class.
	this class cannot be inherited.

13.What is an sealed method?

	Method you cannot override. 
	
	