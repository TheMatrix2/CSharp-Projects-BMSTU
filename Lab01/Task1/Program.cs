Type[] all_types = {typeof(byte), typeof(sbyte), typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong),
typeof(float), typeof(double), typeof(decimal)};

foreach (Type type in all_types)
{
    dynamic min_value = type.GetField("MinValue").GetValue(null);
    dynamic max_value = type.GetField("MaxValue").GetValue(null);

    Console.WriteLine($"Max value for {type.Name} type: {max_value}");
    Console.WriteLine($"Min value for {type.Name} type: {min_value}\n");
}