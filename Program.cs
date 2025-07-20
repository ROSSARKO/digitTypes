using static System.Console;
string[] typeNames = 
[
    "sbyte", "byte", "short", 
    "ushort", "int", "uint", 
    "long", "ulong", "float", 
    "double", "decimal"
];
short[] bytesOfMemory = 
[
    sizeof(sbyte), sizeof(byte), sizeof(short), 
    sizeof(ushort), sizeof(int), sizeof(uint), 
    sizeof(long), sizeof(ulong), sizeof(float), 
    sizeof(double), sizeof(decimal)
];
object[] minValueTypes = 
[
    (sbyte.MinValue), (byte.MinValue), (short.MinValue), 
    (ushort.MinValue), (int.MinValue), (uint.MinValue), 
    (long.MinValue), (ulong.MinValue), (float.MinValue), 
    (double.MinValue), (decimal.MinValue)
];
object[] maxValueTypes = 
[
    (sbyte.MaxValue), (byte.MaxValue), (short.MaxValue), 
    (ushort.MaxValue), (int.MaxValue), (uint.MaxValue), 
    (long.MaxValue), (ulong.MaxValue), (float.MaxValue), 
    (double.MaxValue), (decimal.MaxValue)
];
var str = $"{"Types",-10}{"Byte(s) of memory",10} {"Min",19} {"Max",39}";

for (var i = 0; i < str.Length; i++)
{
    Write("-");
}
WriteLine();
WriteLine(str);
for (var i = 0; i < str.Length; i++)
{
    Write("-");
}
WriteLine();
for (var i = 0; i < typeNames.Length; i++)
{
    str = $"{typeNames[i],-10}{bytesOfMemory[i],0} \t {minValueTypes[i], 30} \t {maxValueTypes[i], 30}";
    WriteLine(str);
}
ReadLine();