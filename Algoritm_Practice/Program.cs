using Algoritm_Practice.AlgosNDataStructures.LinkedList;

SinglyLinkedList<int> list = new SinglyLinkedList<int>();

list.AddNodeBack(1);
list.AddNodeBack(2);
list.AddNodeBack(6);
list.AddNodeBack(6);
list.AddNodeBack(4);
list.AddNodeBack(5);
list.AddNodeBack(3);



//list.PrintList();

list.removeDuplicateFromSortedList();

list.PrintList();

