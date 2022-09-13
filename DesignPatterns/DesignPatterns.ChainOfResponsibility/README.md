# DesignPatterns.ChainOfResponsibility

It is a behavioral design pattern that allows us to pass a request between a chain of objects. 
Each object in the chain contains its processing logic that performs some action and decides the next object from the chain to delegate the work. 
It is used in decoupling the sender from the receiver.

When to use Chain of Responsibility Pattern
	*When we wish to decouple the request's sender from its receiver.
	*When the request provided to the application can be handled by passing it to a series of objects.
	*When we need to enhance the flexibility of the duties assigned to objects.
