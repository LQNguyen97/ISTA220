# Linh Nguyen
## Homework C# 08

1.What is the difference between deep copy and shallow copy?

	Shallow Copy: Copy a reference to these fields. Copy
	Deep Copy: created object to make a complete copy of the internal reference types. Copy what the references points to.

2.What is the value of a reference after you declare and initialize it?

	Memory address/Location in the heap.

3.How do you declare a value type?

	You can declare a value type by using the reserved keyword (double, float).
	You must specify the type and assign it a value.
	
4.How do you declare a reference type?

	Use keywords to declare reference types (*new* keyword)
	

5.Does C# allow you to assign NULL to a value type?

	Depend, nothing will be written to the command window

6.Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?

	no, null is itself a reference, so you cannot assign it to a value type.
	you cannot use a nullable variable as a parameter to a method that expects an ordinary value type.

7.What is the difference between the stack and the heap?

	Stack memory is organized like a stack of boxes piled on top of one another. 
	Heap memory is like a large pile of boxes strewn around a room rather than stacked neatly on
	top of one another. Each box has a label indicating whether it is in use. 

8.What does it mean when we say that all classes are specialized types?

	When you create your own class you are creating a type that is doing a particular thing, class = type.

9.What does ref do?

	The ref keyword passes arguments by reference. It means any changes made to this argument
	in the method will be reflected in that variable when control returns to the calling method.

10.What does out do?

	used for the passing the arguments to methods as a reference type. 
	It is generally used when a method returns multiple values.

11.Describe boxing and unboxing in your own words.

	Boxing is used take a value type and turn it into reference type.
	Unboxing is used to take a reference type and turn it into a value type.

12.What does cast do?

	a method by which a value is converted from one data type to another.
	Cast is an explicit conversion by which the compiler is informed about the conversion and
	the resulting possibility of data loss.