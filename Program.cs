// string[] fradulentOrderIDs = new string [3];

// fradulentOrderIDs[0] = "A123";
// fradulentOrderIDs[1] = "B456";
// fradulentOrderIDs[2] = "C789";
string[] fradulentOrderIDs = {"A123", "B456", "C789"};


Console.WriteLine($"First: {fradulentOrderIDs[0]}\nSecond: {fradulentOrderIDs[1]}\nThird: {fradulentOrderIDs[2]}");

fradulentOrderIDs[0] = "D000";

Console.WriteLine($"reassing First: {fradulentOrderIDs[0]}");

Console.WriteLine($"there are {fradulentOrderIDs.Length} ID's to process");