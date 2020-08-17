# Linh Nguyen
## Homework C# 10

1.What does an array look like in memory?

	The items in an array live in a contiguous (neighboring) block of memory and are accessed by using an index.

2.Where is memory allocated to hold an array, on the stack or on the heap?

	Heap

3.Where is memory allocated to hold an array reference, on the stack or on the heap?

	Stack

4.Can an array hold values of different types? This is a trick question, the answer is, “It depends.” What
determines the types that an array can hold?

	Depend. Only if it is an *object array*.
	An array can only hold values of the same type, cannot mix the types. Because memory size are contiguous

5.Describe the syntax of the condition for a foreach loop.

	The foreach statement declares an iteration variable that automatically acquires the value of each element in the array
	Foreach(Type, Name, Operator, Array)

6.How do you make a deep copy of a array?

	First, you create a new array instance of the same type and the same length as the array you are copying. 
	Second, you copy the data from the original array element by element to the new array

7.What is the difference in the syntax between a multi-dimensional array and an array of arrays?

	Multi-dimensional Always give you a Square(flat rectangle) array
	Array of arrays : Int [] [] 
	Multi-dimensional: int [,]

8.What is the difference in the uses for a multi-dimensional array and an array of arrays? In other words,
what determines whether you would use one as opposed to the other?

	Multidimensional arrays can consume a lot of memory. If the application uses only some of the data in each column, 
	allocating memory for unused elements is a waste

9.How do you “flatten” a multidimensional array? 

	for(int i = 0; i < outer.Legnth; i++)
		for(int j = 0; , < inner.Length; j++)
			Console.WriteLine(i,j);

10.(Thought question) When we use a for loop, we can change the values of the array elements inside
the loop. When we use a foreach loop, we cannot change the values of the arry elements inside the
loop. Why not? How is for different from foreach?

	Foreach loop (access the values) processes an instance of each element in a collection in turn,
	while a for loop (access to the location where the value is stored) can work with any data and is not restricted to
	collection elements alone.

