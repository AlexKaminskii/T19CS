
// zad 1


int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("* - | ");
}


// tabliczka mnożenia

/*
for (int i = 1;i < 11;i++)
{
    for (int j = 1; j < 11; j++)
    {
        Console.Write(i*j + "\t") ;
    }
    Console.WriteLine();
}
*/



// gwiazdki




///
///
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();


for (int i = 0; i < n; i++)
{


    for (int j = 0; j < n - i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


Console.WriteLine();
Console.WriteLine();


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int k = n - i - 1; k < n; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine(" ");
}

Console.WriteLine();
Console.WriteLine();



for (int i = 0; i < n; i++)
{


    for (int j = n - i; j < n; j++)
    {
        Console.Write(" ");
    }


    for (int k = 0; k < n - i; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine("");
}



// zad 5



int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j == n / 2)
        {
            Console.Write("*");
        }
        else if (i == n / 2)
        {
            Console.Write(" - ");
        }
        else
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine();
}


// zad 6

int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i + j == n - 1)
        {
            Console.Write("?");
        }
        else if (i == j) 
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}




// zad 7


int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j == 0 ) 
        {
            Console.Write("*");
        }
        else if (i == n - 1 || j == n - 1 || i == 0 || (i == n / 2 && j == n / 2))
        {
            Console.Write(" *");
        }
        else 
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}
