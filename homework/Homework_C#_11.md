# Linh Nguyen
## Homework C# 11

1.What is a parameter array?

	An array that can take any number of arguments, possibly of different types, as parameters.

2.How do you define a method that takes an arbitrary number of arguments?

	By declaring two or more methods with the same name in the same scope which is also know as
	overloading.

3.How do you call a method that takes an arbitrary number of argiments?

	By using a params parameter, you can call it by regular method. 

4.Why can’t you use an array to pass an arbitrary number of arguments to a method?

	You can't declare an array without knowing the size of the array.

5.How many parameters can a method have?

	As many as it wants.
	
6.Do parameter arguments have to have the same type?

	Yes. The parameters of a method get their actual values from the arguments that are 
	specified when the method is invoked.
	Unless you declare an array as object, since everything is an object.

7.What is the difference between a method that takes a parameter argument and one that takes optional
arguments?

	A method that takes optional parameters still has a fi xed parameter list, and you cannot pass
	an arbitrary list of arguments.

8.How do you define a method that takes different (and arbitrary) types of arguments?

	We define it as a Dynamic parameter.

9.Write a method that accepts any number of arguments of a given type.

	Public static void UseParams(params int[] list)

10.Write a method that accepts any number of arguments of any type.

	Public static void UseParams2(params object[] list)

