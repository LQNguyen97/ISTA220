# Linh Nguyen
## Homework C# 17

1.What is a type parameter?

	A type parameter is a placeholder for a specific type that a client specifies when they create an instance of the generic type.

2.What does a type parameter do?

	Specify the types of objects on which they operate. Specialized the method/class.
	Indicate that a class is a generic class by providing a type parameter in angle brackets

3.How many type parameters can a generic class have?

	A generic class can have multiple type parameters.

4.What is the difference between a generic class and a generalized class?

	Generic classes use type parameters and a generalized class takes parameters that can be cast to different/specialized types.

5.What is a constraint? How do you specify a constraint?

	By using a constraint, you can limit the type parameters of a generic class to those that implement a particular set of interfaces and therefore provide the methods defined by those interfaces.

6.What is a generic method? How do you define a generic method?

	With a generic method, you can specify the types of the parameters and the return type by using a type parameter like that used when you define a generic class. You define generic methods by using the same type parameter syntax you use when you create generic classes.

7.What do we mean when we say that a generic type interface is invariant?

	The IWrapper interface is said to be invariant. You cannot assign an IWrapper object to a reference of type IWrapper, even if type A is derived from type B. By default, C# implements this restriction to ensure the type safety of your code.
	(When the code Cannot implicitly convert type)
	**The parameters you pass to the method have to match each other.** 

8.What do we mean when we cay that a generic type interface is covariant?

	You can assign an IRetrieveWrapper object to an IRetrieve-Wrapper reference as long as there is a valid conversion from type A to type B, or type A derives from type B.
	(Covariance allows interface methods to have more derived return types than that defined by the generic type parameters)
	Pass a parameter that is not match. (out: assign modify parameter without return method.)

9.Does covariance work with value types? Does it work with reference types?

	Covariance works only with reference types. This is because value types cannot form inheritance hierarchies.

10.What do we mean when we cay that a generic type interface is contravariant?

	Contravariance follows a similar principle to covariance except that it works in the opposite direction; it enables you to use a generic interface to reference an object of type B through a reference to type A as long as type B derives from type A.