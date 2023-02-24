
//Create a method that takes in two List<T> lists, intermixes them, and then returns a new list.Alternate
//pulling items from each list starting with the bigger
//list. Make sure the method can take in any List<T>.

using System.Runtime.CompilerServices;

List<string> list1 = new List<string>
{
    "Test 1",
    "Test 2",
    "Test 3",
    "Test 4",
    "Test 5"
};

List<string> list2 = new List<string>
{
    "Test 10",
    "Test 20",
    "Test 30",
    "Test 40"
};

var merge = MergeLists(list1, list2);

foreach (var m in merge)
{
    Console.WriteLine(m);
}

static List<T> MergeLists<T>(List<T> list1, List<T> list2)
{
    List<T> output = new List<T>();
    List<T> biggerList;
    List<T> smallerList;

    if (list1.Count > list2.Count)
    {
        biggerList = list1;
        smallerList = list2;
    }
    else { biggerList= list2; smallerList = list1; }

   for (int i = 0; i < biggerList.Count; i++)
    {
        output.Add(biggerList[i]);
        if (i < smallerList.Count)
        {
            output.Add(smallerList[i]);
        }
    }
    return output;
}

//Create another generics method that takes in two
//generic objects (of the same or different types). Make
//sure each object that is passed in has a Title property
//in it. Return the object with the longer title

Person person = new Person { Title = "Cat", Name = "Pixel" };
Address address = new Address { Title = "England", City = "Derby" };


var result = LongerTitle(person, address);
Console.WriteLine(result.Title);



static ITitle LongerTitle<T, U>(T item1, U item2) where T : ITitle where U : ITitle
{
    if (item1.Title.Length > item2.Title.Length)
    {
        return item1;
    } else { return item2; }
}
