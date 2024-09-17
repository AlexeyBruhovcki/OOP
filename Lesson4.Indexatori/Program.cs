// Индексаторы

using Lesson4.Indexatori;
List<string> list = new List<string>()
{
    "Cat",
    "Dog",
    "Bird",
    "Mouse",
    "Goose",
    "Beaver"
};
List<string> list2 = new List<string>()
{
    "Spoon",
    "Fork",
    "Cheese",
    "Mouse",
    "Duck",
    "Plank"
};
MassOfStrings stringList = new MassOfStrings(6);
MassOfStrings stringList2 = new MassOfStrings(6);
stringList.Print();
stringList.AddList(list);
stringList2.AddList(list2);
stringList.Print();
stringList2.Print();
Console.WriteLine(stringList[3]);
MassOfStrings stringList3=MassOfStrings.Merge(stringList, stringList2);
MassOfStrings mergeListDistinct = MassOfStrings.MergeDistinct(stringList, stringList2);
stringList3.Print();
mergeListDistinct.Print();
stringList3.Add("Pope");
stringList3.Print();

