//Create and use both an out variable in a method and
//a tuple. They do not have to be in the same method


bool successDivide = Divide(5, 0, out double result);

Console.WriteLine(result);


static bool Divide(double x, double y, out double result)
{
    if (y==0)
    {
        result = 0;
        return false;
    }

    result = x / y;

    return true;
}









//Create a variable in one method, pass it into another
//method, modify it in the method, and without
//returning it, use the updated value in the initial
//method. Use two different techniques to make this
//work.



