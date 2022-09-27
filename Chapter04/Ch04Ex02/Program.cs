#region Usings
using Microsoft.EntityFrameworkCore;
#endregion

#region MainMethod


string comparison;
Console.WriteLine("Enter a number:");
double var1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter another number:");
double var2 = Convert.ToDouble(Console.ReadLine());
if (var1 < var2)
    comparison = "less than";
else
{
    if (var1 == var2)
        comparison = "equal to";
    else
        comparison = "greater than";
}
Console.WriteLine($"The first number is {comparison}  the second number.");
#endregion
