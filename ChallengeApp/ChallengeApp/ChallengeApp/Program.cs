int[] grades = new int[51];
//string[] dayOfWeeks = new string[7];

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwaretek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");

//for(int i=0;i<dayOfWeeks.Count;i++)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}
foreach(var day in dayOfWeeks)
{
    Console.WriteLine(day);
}