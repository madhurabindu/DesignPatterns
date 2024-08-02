# Composite (Structural Pattern)

## Overview
Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects

## Intent
- Composite pattern enables clients of an interface to treat the individual objects and objects composed into a tree structure uniformly
- Composite will be treated by the client atomically and the internal children of the composite are not exposed to the client

## UML Diagram
![plot](./composite.png)

## Code Example
This Example shows a communication channel in a School. A students marks, results or feedback are communicated 1 - to -1 
While the Notifications from school such as Events, Holidays or Summer vacation / Reopen is bradcasted to all students

The broadcasting of message is a good example of a composite.
The client can treat individual messaging and bradcasting in the sameway, while the broadcaster builds the tree structure that allows the broadcaster to send the message to each of its components.

The tree structure could be created by creating a composite for each class and each section, and a broadcaster could decide the level of broadcasting of message. A tree structure can be formed with Composite of each section, forming a child in Composite or each class, forming a child in composite of the School.

## Example Output
![output](composite_output.png)

## Mapping the UML classes to Example code
| **File/Class Name** | **Mapping Class in UML**  |
| :-----: | :-: |
|[Base.interfaces/IClient.cs](./Base.Interfaces/IClient.cs)|*Component Interface*|
|[Imp.Clients/SingleClient.cs](./Imp.Clients/SingleClient.cs)|*Leaf*|
|[Imp.Clients/Broadcaster.cs](./Imp.Clients/Broadcaster.cs)|*Composite*|
|[Imp.Clients/Client1.cs](./Imp.Clients/Client1.cs)|*Leaf1*|
|[Imp.Clients/Client2.cs](./Imp.Clients/Client2.cs)|*Leaf2*|
|[Imp.Clients/Client3.cs](./Imp.Clients/Client3.cs)|*Leaf3*|

## Points to Remember
- Typically used in places where we have composites that contain components, each of which could be a composite

## Resources
- https://refactoring.guru/design-patterns/composite
- https://sourcemaking.com/design_patterns/composite
