# F# Mutability Pitfall: Unexpected Behavior with Mutable Variables and Function Calls

This example demonstrates a common pitfall in F# when dealing with mutable variables and function calls.  The initial implementation of `add` calculates the sum but doesn't dynamically update its result if the input variables change.  The solution shows how to correctly handle this situation.