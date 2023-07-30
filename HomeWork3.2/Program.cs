Console.WriteLine("\nOlha Shamray HOMEWORK 3.2");

//---Loop-1---
Console.WriteLine("\n---Loop-1---> For each element, add its index to its value, and output the resulting collection to console <---");
      
        double[] elements = new double[] { 1.1, 2.8, 3.5, 4.12, 5.84, 6.26, 7.03 };

        Console.WriteLine($"\nWe have the elements: " + string.Join("; ", elements));

        List<string> elementsInds = new List<string>();

        for (var i = 0; i < elements.Length; i++)
        {
            elementsInds.Add($"{elements[i]}[{i}]");
        }
        Console.Write($"The elements with their indexes: " + string.Join("; ", elementsInds));

//---Loop-2---
Console.WriteLine("\n\n---Loop-2---> Output elements of the collection one by one (use console.readline as a separator), until user enters 'x' to the program <---");

        Console.WriteLine("\nOutput the elements without indexes by pressing Enter or enter 'x' to finish:");
        for (var i = 0; i < elements.Length; i++)
        {
            Console.WriteLine($"{elements[i]}");

            if (Console.ReadLine() == "x")
            {
                break;
            }
        }

        Console.WriteLine("\nOutput the elements with indexes by pressing Enter or enter 'x' to finish:");
        for (var i = 0; i < elementsInds.Count(); i++)
        {   
            Console.WriteLine($"{elementsInds[i]}");

            if (Console.ReadLine() == "x")
            {
                break;
            }
        }

//---Loop-3---
Console.WriteLine("\n---Loop-3---> Read numbers one by one from console and save them to new collection. Do that until user enters 'not a number' string <---");

        List<double> values = new List<double>();
        string? value;
        bool isDouble;

        Console.WriteLine("\nPlease, enter numbers, then 'not a number' to finish:");
        do
        {   value = Console.ReadLine();

            if (isDouble = Double.TryParse(value, out var doubleValue)) // if (the entered value is parsed to double = true)
            {
                values.Add(doubleValue);
            }

        }   while (isDouble);

//---Loop-4---
Console.WriteLine("\n---Loop-4---> if there are 0 elements in the new cillection after step 3, repeat it (until user enters some numbers), then repeat step 2 (output numbers until user enters 'x' <---");
       
        if (values.Count() == 0)
        {   do
            {   Console.WriteLine("\nPlease, enter numbers, then 'not a number' to finish:");
                do
                {   value = Console.ReadLine();
                
                    if (isDouble = Double.TryParse(value, out var doubleValue)) // if (the entered value is parsed to double = true)
                    {
                        values.Add(doubleValue);
                    }

                }   while (isDouble);

            }   while (values.Count() == 0);
        }  

        Console.WriteLine($"The collection of numbers: " + string.Join("; ", values));

        Console.WriteLine("\nOutput the numbers by pressing Enter or enter 'x' to finish:");

        List<string> valuesInds = new List<string>();

        for (var i = 0; i < values.Count(); i++)
        {
            valuesInds.Add($"{values[i]}[{i}]");
        }

        for (var i = 0; i < valuesInds.Count(); i++)
        {
            Console.WriteLine($"{valuesInds[i]}");

            if (Console.ReadLine() == "x")
            {
                break;
            }
        }    
 
Console.WriteLine("\nThank you! Good bye!\n");