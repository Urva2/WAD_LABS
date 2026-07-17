Console.WriteLine("Demonstartion of List:");
List<int> list = [45,18,33,7,15];
foreach(int s in list)
{
    Console.WriteLine(s);
}
Console.WriteLine("Demonstartion of Dictionary:");
Dictionary<int,string> dict = new Dictionary<int,string>();
dict.Add(0, "Hii");
dict.Add(1, "Hello");
dict.Add(2, "Bye");
foreach(KeyValuePair<int,string> d in dict)
{
    Console.WriteLine(d.Key+":"+d.Value);
}
Console.WriteLine("Demonstartion of Stack(LIFO) :");
Stack<int> st = new Stack<int>();
st.Push(45);
st.Push(18);
st.Push(33);
st.Push(7);
st.Push(15);    
foreach(var item in st)
{
    Console.WriteLine(item);
}
Console.WriteLine("Demonstartion of Queue(FIFO):");
Queue<int> queue = new Queue<int>();
queue.Enqueue(45);
queue.Enqueue(18);
queue.Enqueue(33);
queue.Enqueue(7);
queue.Enqueue(15);
foreach(int item in queue)
{
    Console.WriteLine(item);
}

