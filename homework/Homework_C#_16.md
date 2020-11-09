# Linh Nguyen
## Homework C# 16

1.Give five examples (using valid C# code) of the five bitwise operators listed in the text. (Page 365)

	The NOT (~) operator ~204 = 0b0_11111111_11111111_11111111_00110011
	The left-shift (<<) operator  204 << 2 = 48
	The OR (|) operator  204 | 24 = 220
	The AND (&) operator  204 & 24 = 8
	The XOR (^) operator 204 ^ 24 = 212 

2.Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code.

	Yes, The >> operator shifts its left-hand operand right by the number of bits defined by its right-hand operand.
	1001 >> 2 = 10
	
3.Explain in detail this code: bits & (1 << index);.

	One will shift to the left and will equal. Test to see whether or not the bit in the index is on or off.

4.Explain in detail this code: bits |= (1 << index);.

	bit is the same or equal to index shift to the left. Evaluates the index and shift it to the left were it will equal to bits.
	Turn the bit on.

5.Explain in detail this code: bits &= (1 << index);.

	bits i sthe smae as index miinus 1. Truth if you have two true false other wise. returns a true or a false.

6.How does C# interpret this? bool peek = bits[n];

	Assigns true or false to peek of binary value index n

7.How does C# interpret this? bits[n] = true;

	if bits n is 1 it is true. It turns the n number into true.

8.How does C# interpret this? bits[n] ^= true;

	The result of bits is the same as one it is true.

9.Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
(a) permission = 0 --- None
(b) permission = 1 --- Read
(c) permission = 2 --- Write
(d) permission = 3 --- Read/Write
(e) permission = 4 --- Execute
(f) permission = 5 --- Read/Execute
(g) permission = 6 --- Write/Execute
(h) permission = 7 --- Read/Write/Execute

10.Answer the previous question by converting the decimal permissions into binary permissions. What
does this tell you about using this shceme of permissions?

	1 position allows permissions

