===========================

Linked List - Notes

===========================



What is a Linked List?

\- A Linked List is a linear data structure.

\- It is made up of nodes connected together.

\- Each node stores:

&#x20; 1. Data

&#x20; 2. A reference (Next) to the next node.

\- The last node points to null.



\---------------------------------------



Node

\- Node is the basic unit of a Linked List.

\- Every node contains:

&#x20; - Data

&#x20; - Next



\---------------------------------------



Head

\- Head is a reference to the first node in the list.

\- If the list is empty, Head = null.



\---------------------------------------



Basic Operations



1\. Insert At Beginning

\- Create a new node.

\- Point its Next to the current Head.

\- Move Head to the new node.



2\. Insert At End

\- Create a new node.

\- Traverse to the last node.

\- Make the last node point to the new node.



3\. Display

\- Start from Head.

\- Print each node.

\- Continue until Next becomes null.



4\. Search

\- Traverse the list.

\- Compare each node with the required value.

\- Return True if found, otherwise False.



5\. Delete

\- Find the node to delete.

\- Connect the previous node to the next node.

\- Remove the target node.



\---------------------------------------



Advantages

\- Dynamic size.

\- Fast insertion and deletion.

\- Does not require contiguous memory.



\---------------------------------------



Disadvantages

\- Extra memory is needed for the Next pointer.

\- No direct access by index.

\- Searching takes more time than arrays.



\---------------------------------------



Important Notes

\- Head always points to the first node.

\- Next points to the next node.

\- The last node always has Next = null.

\- Traversing always starts from Head.

