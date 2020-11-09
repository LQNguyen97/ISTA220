# Linh Nguyen
## Homework C# 14

1.What is the difference between a managed resource and an unmanaged resource?

	Unmanaged resource is not directly under the control of the garbage collector. (File stream, network connections)
	The CLR will automatically clear up any managed resources that an object uses
	

2.When is memory for an object (reference type) allocated? When is the memory deallocated?

	The *new* operation allocates a chunk of raw memory from the heap. (Instantiate)
	The memory that the object lived in must be deallocated when the variable No longer reference it.

3.What is a destructor?

	A special method of a class and it is used in a class to destroy the object or instances of classes.

4.What is the difference in syntax between a constructor and a destructor?

	The syntax for writing a destructor is a tilde (~) followed by the name of the class.

5.Give some examples of scarce resources. Why would you want to manage scarce resources?

	Memory, database connections, or file handles. Some resources are just too valuable to lie around waiting for
	an arbitrary length of time until the garbage collector actually releases them.

6.What is exception-safe disposal?

	Ensure that a disposal method is always called, regardless of whether there is an exception.

7.How do you think that the using statement works for resource management? Give an informal, English
language, explanation of how it works.

	You use *using statement* to create an object that will be destroyed when the object out of the *using statement* scope.

8.What ill effects could result from attempting to dispose of a resource more than once?

	Generating a System.ObjectDisposedException

9.We will look at threads later in the term. For now, what is your understanding of how threads interact
with resource management? A good guess is a siufficient answer to this question.

	A thread is a separate path of execution in an application that run separately.

10.Why does the book recommend not attempting to force the garbage collector? Are their any exceptions
to this recommendation?

	The GC.Collect method does not wait for garbage collection to be complete before it returns, so you still don’t 
	know whether your objects have been destroyed.
	In unit tests. Call GC.Collect() before and after some test to find potential memory leaks.