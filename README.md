# HeadFirstDesignPatterns
This is a collection of examples from the book, principles and design patterns definitions added below.

## Principles
- Encapsulate what varies.
- Favor composition over ingeritance
- Program to interfaces, not implementations.
- Strive for loosely coupled designs between objects that interact.
- Classes should be open for extension, but closed for modification.
- Dependency Inversion Principle: Depend upon abstractions. Do not
depend upon concrete classes.

## Patterns

### Strategy
Defines a family of algorithms, encapsulates each one, and makes them 
interchangeable. Strategy lets the algorithm 
vary independently from clients that use it.

### Observer

Defines a one-to-many dependency between objects so that when one object changes state, 
all its dependents are notified and updated automatically.

### Decorator

The Decorator Pattern attaches additional responsibilities to an object dynamically. 
Decorators provide a flexible alternative to subclassing for extending functionality.

### Factory Method Pattern
Defines an interface
for creating an object, but lets subclasses decide which
class to instantiate. Factory Method lets a class defer
instantiation to subclasses.
