# Linh Nguyen
## Homework C# 15

1.What is the difference between a property and a field?

	Property looks like a field but acts as a method.
	Property contain 2 blocks of code, get(statement that execute when the proerty is read) and 
	set(statement that run upong writing to the property) keywords.
	You can’t use a property as a ref or an out argument to a method (although you can use a writable field as a ref or an out argument)

2.What is the difference between a property and a method?

	Property get and set accessors cannot take any parameters list, while method can take parameters list.

3.What is your understanding of encapsulation?

	Wrapping up of data under a single unit, or CLASS.

4.Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Do you think that the difference in case in the initial character of two different
identifiers is sufficient to distinguish them?

	Common to use identifiers that start with an uppercase letter for publicly accessible methods and fields and
	lowercase letter for private methods and fields.

5.Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use a write-only
property.

	Printing out a data list, serial number (Read only)
	Use to compare user's input data, password (write only)

6.Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private.
	
	If you make it public you can use it as reference and don't have to copy-paste similar codes.

7.What are restrictions on the use of properties?

	You can assign a value through a property of a structure or class only after the structure or class
	has been initialized.
	You can’t use a property as a ref or an out argument to a method (although you can use a writable field as a ref or an out argument).
	A property can contain at most one get accessor and one set accessor. A property cannot
	contain other methods, fi elds, or properties.
	The get and set accessors cannot take any parameters. The data being assigned is passed to the
	set accessor automatically by using the value variable.
	You can’t declare properties by using const

8.What is an object initializer? What is the syntax for an object initializer?

	Allow you to assign values to the fields or properties at the time of creating an object without invoking a constructor.
	Cat cat = new Cat { Age = 10, Name = "Fluffy" };
	class name, new name = new (classname) and assign properties
