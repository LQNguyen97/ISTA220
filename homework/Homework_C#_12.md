# Linh Nguyen
## Homework C# 12

1.How does inheritance promote the principle of don’t repeat yourself (DRY)?

	You can augment each class with the functionality unique to a particular type of class.

2.What is the syntax of a derived class that inherits from a base class?

	class DerivedClass : BaseClass
	{
		...
	}

3.Do all user defined types (classes and structs) inherit from some base class? If so, what is it?

	Yes. Every classes inherit directly or indirectly from Object Class. In C# everything is an Object.

4.What happens if you do not have a default constructor in a base class when creating a derived class?

	The compiler attempts to silently insert a call to the base class’s default constructor before executing the code in the
	derived-class constructor.

5.Can you assign a variable of a derived class to another variable of its base class? Why or why not?

	Yes. Example: Horse is a mammal. Derived classes are specified of base class.

6.Can you assign a variable of a derived class to another variable of of a derived class of its base class?
Why or why not?

	No, since each derived class is a specific class directly under the base class.
	(Horse and Whale are both mammal but Horse is not a Whale, and vice versa.)

7.Can you assign a variable of a base class to another variable of a derived class? Why or why not?

	Yes, because the base class is higher in the hierarchy. (Horse is a mammal).

8.Under what circumstances would you want to use the new keyword when defining a method in a derived class?

	If you’re sure that you want the two methods to have the same signature, you can silence the warning by
	using the new keyword.

9.What is a virtual method? Why would you want to define a virtual method?

	A method that is intended to be overridden, used when a method's basic functionality is 
	the same but sometimes more functionality is needed in the derived class

10.What does override do? Why does it do it?

	Overriding a method is a mechanism for providing different implementations of the same method.
	The methods are all related because they are intended to perform the same task, but in a class-specific manner.

11.How do you define an extension type?

	You define an extension method in a static class and specify the type to which the method applies
	as the first parameter to the method, along with the *this* keyword.

12.Why do you define an extension type?

	Allows you to add new methods in the existing class or in the structure without modifying the source code of the original
	type and you do not require any kind of special permission from the original type and there is no need to re-compile the
	original type.

13.(Not in book) Explain the Liskov substitution principle.

	A derived class should be able to be used in the same manner as the base class, according to relevant contracts.
