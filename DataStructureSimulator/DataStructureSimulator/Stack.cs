using System;
using System.Collections.Generic;

public class LinkedStack<E> : LinkedList<E>
{
	// Constructs a stack using a doubly LinkedList
	public LinkedStack() : base()
	{
	}

	class EmptyStackException : Exception { }

	// Adds ele to the top of the stack
	public void push(E ele)
	{
		this.AddFirst(ele);
	}

	// Returns the size of the stack
	public int size()
	{
		return base.Count;
	}

	// Determines whether this stack is empty
	public Boolean isEmpty()
	{
		return this.size() == 0;
	}

	// Remove the top element of the stack and return it
	public E pop()
	{
		// Throw an exception if this stack is empty
		if (this.isEmpty())
		{
			throw new EmptyStackException();
		}

		E top = this.top();
		this.RemoveFirst();
		return top;
	}

	public E top()
	{
		// Throw an exception if this stack is empty
		if (this.isEmpty())
		{
			throw new EmptyStackException();
		}
		return this.First.Value;
	}
}
