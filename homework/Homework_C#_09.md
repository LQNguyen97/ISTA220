# Linh Nguyen
## Homework C# 09

1.What is an enum?

	Used to assign constant names to a group of numeric integer values. It makes constant values more readable.
	Where you give a series of number names. 

2.Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols,
like Private, Corporal, Sergeant or Lieutenant, Captain, Major?

	Enum Ranks {pvt, pfc, lcpl, cpl, sgt, ssgt, gysgt, 1sgt, sgtmaj}

3.Using the Ranks enum, assign a rank to yourself and a friend.

	Ranks linh = Ranks.cpl;

4.Determine the numeric index of particular ranks, using the Ranks enum.

	{1,2,3,4,5,6,7,8,9} as eranks. 1-9.

5.How do you select the type of an enum?

	You select a type of enum by specifying its type after a colon before the list. 

6.What is a struct?

	A structure is a value type data type. It helps you to make a single variable hold related data of
	various data types. The struct keyword is used for creating a structure. Structures are used to represent a record.

7.List some differences between classes and structs.

	Structure instances are called values and live on the stack.
	Class instances are called objects and live on the heap.

8.Are structs stored on the stack or on the heap? What about enums?

	Structs are allocated on the *stack*, if a local function variable, or on the heap as part of a class if a class member.
	As enum types are handled as integral types, they are stored in the *stack* and registers as their respective data
	types

9.Review the documentation for the C# System.Int32 struct. List the fields. List the methods.

	MaxValue and MinValue. CompareTo , Equals
	GetHashCode
	GetTypeCode
	Parse
	ToString
	TryFormat
	TryParse

10.Declare a struct named DOD with four branches.

		struct DoD
	{
		public string Air Force,
		public string Army,
		public string Marine,
		public string Navy
	};

11.Why can’t you create a default constructor for a struct?

	The reason for this constraint is to do with the fact that, unlike in C++, a C# struct is associated with
	value-type semantic and a value-type is not required to have a constructor.

12.What is CIL? What does the CLR do to the CIL?

	CIL (Common Intermediate Language). CLR (The Common Language Runtime).
	CLR transforms source code into a form of bytecode known as Common Intermediate Language (CIL).
	CIL generate byte code and CLR transforms the btye code to machine code (1s and 0s).
	