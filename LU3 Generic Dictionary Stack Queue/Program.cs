//Dictionary
//also part of the collection build-in
//stores in key-value pairs
//key is used to uniquely identify an item in a collection and its value is the data
////associated with the key
//Using System.Collection.Generic

//General syntax
//

//create a dictionary to store some key value parts
Dictionary <string, int> dict = new Dictionary<string, int>();
dict.Add("apple", 4);
dict.Add("orange", 5);
dict.Add("banana", 6);

//calculate the total number of fruits stored in the dictionary 
//make use of a foreach loop
int total = 0;

foreach (KeyValuePair<string, int> pair in dict)
{
    total += pair.Value;
    

}
Console.WriteLine("Total number of fruits: {0}", total);
//ContainsKey()
if (dict.ContainsKey("apple"))
{
    Console.WriteLine("We have apple");

}
else {
    Console.WriteLine("we have no apple");
}