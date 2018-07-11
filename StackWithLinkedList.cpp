// StackWithLinkedList.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

struct Node {
	int data;
	Node *next;
	Node()
	{
		data = 0;
		next = NULL;	   
	}

};

class Stack {
public:
	Node *stack;
	int size;
	Stack()
	{
		stack = new Node;
		size = 0;
	}

	void Push(int data) {
		if (stack == NULL) {
			stack->data = data;
			stack->next = NULL;
		}
		else {
			Node *oldStack = stack;
			stack = new Node();
			stack->data = data;
			stack->next = oldStack;
		}
		size++;
	}
	int Pop() {
		int result;
		if (size == 0)
			return -1;
		if (size == 1) {
			result = stack->data;
			stack = NULL;
			return result;
		}

		result = stack->data;
		Node * temp = stack;
		stack = stack->next;
		delete(temp);
		return result;			
	}

};

int main()
{
	Stack object;
	object.Push(4);
	object.Push(18);
	object.Push(10);

	cout << object.Pop() << "\n";
	cout << object.Pop() << "\n";

    return 0;
}

