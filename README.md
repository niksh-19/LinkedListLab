# LinkedListLab

This C# project implements a simple linked list data structure with basic operations like adding nodes to the beginning or end of the list, removing nodes from the beginning or end, and accessing nodes by index.

## Components

## Node

The `Node` class represents a single node in the linked list. Each node contains a string value and a reference to the next node in the list.

## LinkedList

The `LinkedList` class represents the linked list itself. It maintains a reference to the head of the list and keeps track of the number of elements in the list.

## Public Methods

- `AddFirst(string value)`: Adds a new node with the specified value to the beginning of the list.
- `AddLast(string value)`: Adds a new node with the specified value to the end of the list.
- `RemoveFirst()`: Removes the first node from the list.
- `RemoveLast()`: Removes the last node from the list.
- `GetValue(int index)`: Retrieves the value of the node at the specified index in the list.

## Properties

- `Count`: Returns the number of nodes in the list.
- `Head`: Returns the head node of the list.

## Unit Tests

The `LinkedListTests` project contains unit tests for the `LinkedList` class using NUnit framework. These tests cover various scenarios to ensure the correctness of the implementation.

## Running Tests

To run the unit tests, build the solution and execute the test cases using an NUnit test runner or Visual Studio's built-in test explorer.

