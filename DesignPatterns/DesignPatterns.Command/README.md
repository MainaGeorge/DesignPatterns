# DesignPattern.Command

It is a data-driven behavioral pattern that turns a request into a stand-alone object known as a command.
It encapsulates all the information that is required to act i.e., it wraps the action and its required parameters together in an object.
It is used to separate the object that invokes the operation from the object that operates.

When to use Command Pattern
	*When we need to attach operations with objects using which we can queue operations, schedule their execution, or execute them remotely.
	*When we wish to implement reversible operations like undo and redo operations. Since the command pattern allows us to create objects that represent the actions that are to be performed in the application, we can create a list of tasks performed (list of command objects) and can undo or redo the task just by searching and executing the undo method of the last command object from the task list.