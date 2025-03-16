int Depth_Value;
double Interest;
int Term;
double Interest_Value = 0;

do
{
    Console.Write("Depth Value (an integer > 0, VND): ");
}
while (!int.TryParse(Console.ReadLine(), out Depth_Value) || Depth_Value <= 0);
do
{
    Console.Write("Interest (a number > 0): ");
}
while (!double.TryParse(Console.ReadLine(), out Interest) || Interest <= 0);
do
{
    Console.Write("Terms (a number > 0, month): ");
}
while (!int.TryParse(Console.ReadLine(), out Term) || Term <= 0);

for (int i = 0; i < Term; i++)
{
    Interest_Value = Depth_Value * ((Interest / 100) / 12) * Term;
}
Console.Write("Interest Value: " + Interest_Value);