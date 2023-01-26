/*Dictionary<int, int> map1 = {1: 111,2: 222,};
Dictionary<String, String> map2 = {"name": "Tom","age": "25"}; 
 
Ushbu 2 xil turdagi Dictionary berilgan bo`lsa quyidagicha Console ga chop qiladigan yagona PrintDictionary() 
deb nomlangan Generic funksiya yozing.
 
Key: name, Value: Tom
Key: age, Value: 25
Key: 1, Value: 111
Key: 2, Value: 222*/
namespace OOP_11.vazifa_List.Person
{
    internal class Person
    {
        Dictionary<int, int> map1 = new()
        {
            { 1,111 },
            { 2,222}
        };
        Dictionary<String, String> map2 = new()
        {
            {"name", "Tom"},
            {"age", "25" }
        };
        public static void PrintDictionary()
        {
            
        }
    }
}
