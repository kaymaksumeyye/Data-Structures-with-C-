// C++Queue.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;


struct Node {
	int data;
	Node *next;
	Node()
	{
		this->data = 0;
		this->next = NULL;
	}
};

class Queue {
public:
	Node *queue;
	int size;
	Queue()
	{
		queue = new Node();
		size = 0;
	}
   
	void ENQueue(int data) {
		if (this->queue == NULL) {
			this->queue->data = data;
			this->queue->next = NULL;
			size++;
		}
		else{
			Node *oldQueue = queue;
			queue = new Node();
			queue->data = data;
			queue->next = oldQueue;
			size++;
		}

	}
    
	int DEQueue() {
		int result;
		Node *item;
		item = queue;
		if (size == 0)
			return -1;
		if (size == 1){
			result = queue->data;
			queue = NULL;
			size--;
			return result;
		}
		for (int i = 0; i < size-2; i++) {
			item = item->next;
		}
		Node *temp = item->next;
		result = item->next->data;
		item->next = NULL;
		//delete(temp);
		size--;
		return result;
	}

	void PrintQueue() {
		Node *item = queue;
		for (int i = 0; i < size; i++) {
			cout << item->data << "\n";
			item = item->next;
		}
	}
};

int main()
{
	Queue object;
	object.ENQueue(3);
	object.ENQueue(7);
	object.PrintQueue();

	cout <<"DeQueue running..." << object.DEQueue() << "\n";

	object.ENQueue(12);
	object.ENQueue(25);

	object.PrintQueue();

	cout << "DeQueue running..." << object.DEQueue() << "\n";

	cout << "DeQueue running..." << object.DEQueue() << "\n";


	return 0;
}
