/*

Solve the classic Tower of Hanoi problem using recursion.
Instructions:
1. Write a method:
void TowerOfHanoi(int n, char from, char to, char aux)
2. Input:
Number of disks n
3. Output:
Print the steps to move all disks from source to destination using
auxiliary rod
4. Example for n = 3 :
Move disk 1 from A to C
Move disk 2 from A to B
Move disk 1 from C to B
*/

using System;

class Program
{
    static void TowerOfHanoi(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine("Move disk 1 from " + from + " to " + to);
            return;
        }

        TowerOfHanoi(n - 1, from, aux, to);
        Console.WriteLine("Move disk " + n + " from " + from + " to " + to);
        TowerOfHanoi(n - 1, aux, to, from);
    }

    static void Main()
    {
        int n = 3; 
        TowerOfHanoi(n, 'A', 'C', 'B');
    }
}



/*
Output:

Move disk 1 from A to C
Move disk 2 from A to B
Move disk 1 from C to B
Move disk 3 from A to C
Move disk 1 from B to A
Move disk 2 from B to C
Move disk 1 from A to C

*/