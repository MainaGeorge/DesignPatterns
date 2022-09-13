# DesignPatterns.Momento

The momento pattern is used to implement the undo operation i.e., it allows us to save and restore an object to its previous state. 
It wraps the entire object state in a single object known as the Memento that allows the entire state to be saved and restored in a single action.

When to use Memento Pattern
	*When we wish to produce the snapshots of the object's state to get the ability to restore the previous states of an object.