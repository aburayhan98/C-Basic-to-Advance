
using System.Collections;
using System.Collections.Specialized;

List<string> names = new List<string>(); //list contain single parameter
names.Add("Dhaka");
names.Add("Jalaluddin");

List<int> ages  = new List<int>();
ages.Add(20);
ages[0] = 5;

names.Remove("Jalaluddin");

ArrayList items = new ArrayList();   //non-generic instance of list, if we set object it can be work same
items.Add("Dhaka");
items.Add(2.3);
items.Add(true);

Dictionary<string,int> persons = new Dictionary<string, int>(); //no non-generic instance here
persons.Add("Jalaluddin", 42);
persons["Jalaluddin"] = 41; //index by key

NameValueCollection settings = new NameValueCollection();
settings.Add("port", "465");

HashSet<string> keys = new HashSet<string>(); //cannot contain duplicate element
keys.Add("jalaluddin"); //keep the same value at once
keys.Add("jalaluddin");

Hashtable hashtabe = new Hashtable(); 
hashtabe.Add("jalaluddin", "42");
hashtabe.Add("jalaluddin", "41"); //throw exception error, cannot contain duplicat element

SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>(); //keep sorting formate
sortedDictionary.Add("abc", "44");                                                             
sortedDictionary.Add("aaa", "33");
foreach (var item in sortedDictionary)
    Console.WriteLine(item);

SortedSet<string> sortedSet = new SortedSet<string>(); //it cannot accept duplicate content/value
sortedSet.Add("tareq");
sortedSet.Add("arif");
sortedSet.Add("arif");
sortedSet.Add("monir");
foreach (var item in sortedSet)
    Console.WriteLine(item);

Stack<int> stack = new Stack<int>();  //generic form , LIFO
stack.Push(30);
stack.Push(40);

while (stack.Count > 0)
    Console.WriteLine(stack.Pop());
 
Stack stack2 = new Stack();  //non genric
stack2.Push(30);
stack2.Push(true);

Queue<int> queue = new Queue<int>(); //Generic form, FIFO
queue.Enqueue(30);
queue.Enqueue(40);

while (queue.Count > 0)
    Console.WriteLine(queue.Dequeue());

/*
 * two types of built in collection
 * 1. Generic(<>) 
 * 2.Non-Generic(no object)
 * List contain single parameter
 * not fixed size
 * list can added list in nested 
 * List can be used major rather then array
 * List always have numeric indexing
 * Dictionary is using key for indexing
 * good to use premitive data
 * Dictionary have fixed string set
 * Sort dictionary is generic
 * it cannot contain duplicate contain
 */