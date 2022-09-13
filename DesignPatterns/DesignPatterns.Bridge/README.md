# DesignPatterns.Bridge

The main function of the bridge pattern is to separate the implementation part from the abstraction part so that the abstraction and implementation of a class can vary independently.
i.e supports two hierarchies that can grow independently

There are in two part in Bridge Pattern:
	*Implementation or Body
	*Abstraction or Handling

When to use Bridge Pattern
	*When both implementation and its functional abstraction needs are extended using another sub-class.
	*When you don't want to affect clients due to changes in implementation.
	*When you want to avoid permanent binding between implementation and its functional abstraction.