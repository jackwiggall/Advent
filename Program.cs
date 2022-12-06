using System;
using System.Collections;

namespace Advent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Work\VS\Advent\inputs\day6.txt");

            //string[] output = { "" };
            int total = 0;

            foreach (string line in lines)
            {
                char one;
                char two;
                char three;
                char four;
                for (int i = 3; i < line.Length; i++) {
                    one = line[i-3];
                    two = line[i-2];
                    three = line[i-1];
                    four = line[i];
                    if (one == two || one == three || one == four || two == three || two == four || three == four)
                    {
                        continue;
                    }
                    else {
                        total = i+1;
                        break;
                    }
                }

                Console.WriteLine(line+"\t"+total);
            }

            //Console.WriteLine("answer is null");
    }
}

    /*void Day1() {
        // The files used in this example are created in the topic
        // How to: Write to a Text File. You can change the path and
        // file name to substitute text files of your own.

        // Read each line of the file into a string array. Each element
        // of the array is one line of the file.
        string[] lines = System.IO.File.ReadAllLines(@"D:\Work\VS\Advent\inputs\day1.txt");

        int[] output = { 0 };
        int count = 0;
        int total = 0;

        foreach (string line in lines)
        {
            if (line == "")
            {
                Array.Resize(ref output, output.Length + 1);
                output[count] = total;
                total = 0;
                count++;
                continue;
            }
            else
            {
                total = total + Int32.Parse(line);
            }
        }

        // Display the file contents by using a foreach loop.
        System.Console.WriteLine(@"D:\Work\VS\Advent\inputs\day1.txt = ");
        Array.Sort(output);
        Array.Reverse(output);
        foreach (int number in output)
        {
            Console.WriteLine("\t" + number);
        }
        int top1 = output[0];
        int top2 = output[1];
        int top3 = output[2];
        int top = top1 + top2 + top3;
        // Keep the console window open in debug mode.
        Console.WriteLine("1st Number is " + top1);
        Console.WriteLine("2nd Number is " + top2);
        Console.WriteLine("3rd Number is " + top3);
        Console.WriteLine("Answer is " + top);
        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }*/

    /*void day2() { 
            string[] lines = System.IO.File.ReadAllLines(@"D:\Work\VS\Advent\inputs\day2.txt");
            //A is rock > C
            //B is paper > A
            //C is scissors > B 

            string[] output = { "A" };
            int count = 0;
            int total2 = 0;
            int total1 = 0;

            foreach (string line in lines)
            {
                if (line == "")
                {
                    Array.Resize(ref output, output.Length + 1);
                    output[count] = line;
                    count++;
                    continue;
                }
                else
                {
                    char line0 = line[0];
                    char line2 = line[2];

                    switch (line2) //PART 2
                    {
                        case 'X': //lose
                            if (line0 == 'A') //rock so play scissors
                            {
                                total2=total2+3;
                                break;
                            }
                            if (line0 == 'B') //paper so play rock
                            {
                                total2++;
                                break;
                            }
                            if (line0 == 'C') //scissors so play paper
                            {
                                total2 = total2 + 2;
                                break;
                            }
                            //no bonus to total as lose
                            break;
                        case 'Y': //draw
                            total2 = total2 + 3; //draw bonus
                            if (line0 == 'A') { //rock so play rock
                                total2++;
                                break;
                            }
                            if (line0 == 'B') //paper so play paper
                            {
                                total2= total2 + 2;
                                break;
                            }
                            if (line0 == 'C') //scissors so play scissors
                            {
                                total2= total2 + 3;
                                break;
                            }
                            break;
                        case 'Z': //win
                            total2 = total2 + 6; //win bonus
                            if (line0 == 'A') //rock so play paper
                            {
                                total2=total2+2;
                                break;
                            }
                            if (line0 == 'B') //paper so play scissors
                            {
                                total2 = total2 + 3;
                                break;
                            }
                            if (line0 == 'C') //scissors so play rock
                            {
                                total2++;
                                break;
                            }
                            break;
                        default:
                            // code block
                            break;
                    }
                    //12683

                    //X is rock > C
                    //Y is paper > A
                    //Z is scissors > B
                    switch (line2) //PART 1
                    {
                        case 'X':
                            total1++;
                            break;
                        case 'Y':
                            total1 = total1 + 2;
                            break;
                        case 'Z':
                            total1 = total1 + 3;
                            break;
                        default:
                            // code block
                            break;
                    }
                    if (line0 == 'A' && line2=='Y' || line0 == 'B' && line2 == 'Z' || line0 == 'C' && line2 == 'X') { //WIN
                        total1= total1+6;
                        continue;
                    }
                    if (line0 == 'A' && line2 == 'X' || line0 == 'B' && line2 == 'Y' || line0 == 'C' && line2 == 'Z')
                    { //TIE
                        total1 = total1 + 3;
                        continue;
                    }
                    //12458
                }
            }
            foreach (string line in output)
            {
                Console.WriteLine("Part1 Total is: " + total1);
                Console.WriteLine("Part2 Total is: " + total2);
            }

        }*/

    /* void day3() {
    string[] lines = System.IO.File.ReadAllLines(@"D:\Work\VS\Advent\inputs\day3.txt");

        //string[] output = {"A"};
        int count = 0;
        int total = 0;

        for (int l = 0; l < lines.Length / 3; l++) {
            int linePos = l * 3;
            string line1 = lines[linePos];
            string line2 = lines[linePos+1];
            string line3 = lines[linePos+2];

            char[] repeats = { ' ' };
            int midLength = line.Length / 2;
            string compartment1 = line.Substring(0, midLength);
            string compartment2 = line.Substring(midLength, midLength);
            for (int i = 0; i < line1.Length; i++)
            {
                for (int j = 0; j < line2.Length; j++)
                {
                    for (int k=0;k<line3.Length;k++) {
                        if (line1[i] == line2[j] && line1[i] == line3[k] && line2[j] == line3[k])
                        {
                            //find char of possible repeat
                            int temp = (int)(line1[i]);
                            if (temp > 96)
                            {
                                temp = temp - 96;
                            }
                            else
                            {
                                temp = temp - 38;
                            }
                            bool found = false;
                            foreach (char c in repeats)
                            {
                                if (c == line1[i])
                                {
                                    found = true; //already in the list
                                }
                            }
                            if (!found)
                            {
                                repeats[count] = line1[i];
                                Array.Resize(ref repeats, repeats.Length + 1);
                                count++;
                                total = total + temp;
                                Console.WriteLine("Group "+l+" are " + line1[i]+" with "+temp);
                            }
                        }
                    }
                }
            }
            count = 0;
            continue;
        }
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Letters are " + output[count]);

        Console.WriteLine("Total is " + total);
        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }//part1 7517
    //part2 2585*/

    /*void day4() {
      string[] lines = System.IO.File.ReadAllLines(@"D:\Work\VS\Advent\inputs\day4.txt");

            int total = 0;

            foreach (string line in lines)
            {
                //string elf1 = "";
                //string elf2 = "";
                int[] elf1 = { 0 };
                int[] elf2 = { 0 };
                bool success = false;

                if (line == "")
                {
                    continue;
                }
                else
                {

                    String[] spearator = { ",", "-" };
                    Int32 count = 4;

                    // using the method
                    String[] strlist = line.Split(spearator, count,
                           StringSplitOptions.RemoveEmptyEntries);

                    int aisle0 = Int32.Parse(strlist[0]); //)-(int)('0'); //1 of 1-2
                    int aisle1 = Int32.Parse(strlist[1]); //2 of 1-2

                    int aisle2 = Int32.Parse(strlist[2]); //1 of 1-2
                    int aisle3 = Int32.Parse(strlist[3]); //2 of 1-2

                    /*for (int i = 0; i < 10; i++) { //for visual
                        //elf1
                        if (i >= aisle0 && i <= aisle1) {
                            elf1 += i.ToString();
                        }
                        else
                        {
                            elf1 += ".";
                        }
                        //elf2
                        if (i >= aisle2 && i <= aisle3)
                        {
                            elf2 += i.ToString();
                        }
                        else
                        {
                            elf2 += ".";
                        }
                    }*/

    /* //part 1
    if (aisle0 >= aisle2 && aisle1 <= aisle3 || aisle0 <= aisle2 && aisle1 >= aisle3) {
    total++;
    success = true;
    }*/
    /*Array.Resize(ref elf1, aisle1 - aisle0 + 1);
    Array.Resize(ref elf2, aisle3 - aisle2 + 1);
    for (int i = 0; i < aisle1 - aisle0 + 1; i++)
    {
    elf1[i] = aisle0 + i;
    }
    for (int i = 0; i < aisle3 - aisle2 + 1; i++)
    {
    elf2[i] = aisle2 + i;
    }
    for (int i = 0; i < aisle1 - aisle0 + 1; i++)
    {
    if (success)
    {
        break;
    }

    for (int j = 0; j < aisle3 - aisle2 + 1; j++)
    {
        if (elf1[i] == elf2[j])
        {
            total++;
            success = true;
            break;
        }
    }
    }
    Console.WriteLine(aisle0 + "-" + aisle1 + "\t" + aisle2 + "-" + aisle3 + "\t" + success);
                }
            }//part 1 605
            //part 2 914

            // Keep the console window open in debug mode.
            Console.WriteLine("Answer is " + total);
    Console.WriteLine("Press any key to exit.");
    System.Console.ReadKey();}
        */
    /*void day5() {
        string[] lines = System.IO.File.ReadAllLines(@"D:\Work\VS\Advent\inputs\day5.txt");

        Stack rone = new Stack();
        Stack rtwo = new Stack();
        Stack rthree = new Stack();
        Stack rfour = new Stack();
        Stack rfive = new Stack();
        Stack rsix = new Stack();
        Stack rseven = new Stack();
        Stack reight = new Stack();
        Stack rnine = new Stack();
        int count = 0;

        foreach (string line in lines)
        {
            count++;
            if (line[1] == '1')
            {
                break;
            }
            if (line[1] != ' ')
            {
                rone.Push(line[1]);
            }
            if (line[5] != ' ')
            {
                rtwo.Push(line[5]);
            }
            if (line[9] != ' ')
            {
                rthree.Push(line[9]);
            }
            if (line[13] != ' ')
            {
                rfour.Push(line[13]);
            }
            if (line[17] != ' ')
            {
                rfive.Push(line[17]);
            }
            if (line[21] != ' ')
            {
                rsix.Push(line[21]);
            }
            if (line[25] != ' ')
            {
                rseven.Push(line[25]);
            }
            if (line[29] != ' ')
            {
                reight.Push(line[29]);
            }
            if (line[33] != ' ')
            {
                rnine.Push(line[33]);
            }
        }
        Stack one = new Stack();
        Stack two = new Stack();
        Stack three = new Stack();
        Stack four = new Stack();
        Stack five = new Stack();
        Stack six = new Stack();
        Stack seven = new Stack();
        Stack eight = new Stack();
        Stack nine = new Stack();

        foreach (char c in rone)
        { //reverse stack
            one.Push(c);
        }
        foreach (char c in rtwo)
        { //reverse stack
            two.Push(c);
        }
        foreach (char c in rthree)
        { //reverse stack
            three.Push(c);
        }
        foreach (char c in rfour)
        { //reverse stack
            four.Push(c);
        }
        foreach (char c in rfive)
        { //reverse stack
            five.Push(c);
        }
        foreach (char c in rsix)
        { //reverse stack
            six.Push(c);
        }
        foreach (char c in rseven)
        { //reverse stack
            seven.Push(c);
        }
        foreach (char c in reight)
        { //reverse stack
            eight.Push(c);
        }
        foreach (char c in rnine)
        { //reverse stack
            nine.Push(c);
        }

        //NOW TO MOVE IT!
        int newCount = 0;
        foreach (string line in lines)
        {
            if (newCount != count + 1 || line == "")
            {
                newCount++; //skips line to right one
                Console.WriteLine(line);
                continue;
            }
            String[] spearator = { " " };

            // using the method
            String[] strlist = line.Split(spearator, 6,
                   StringSplitOptions.RemoveEmptyEntries);

            //move 1 from 3 to 2
            int amount = Int32.Parse(strlist[1]); //1
            int stackfrom = Int32.Parse(strlist[3]); //3
            int stackto = Int32.Parse(strlist[5]); //2

            //Console.WriteLine(line);
            object[] val = { "" };
            for (int i = 0; i < amount; i++) //get values to move
            {
                Array.Resize(ref val, val.Length + 1);
                if (one.Count > 0 && stackfrom == 1)
                { val[i] = one.Pop(); }
                else if (two.Count > 0 && stackfrom == 2)
                { val[i] = two.Pop(); }
                else if (three.Count > 0 && stackfrom == 3)
                { val[i] = three.Pop(); }
                else if (four.Count > 0 && stackfrom == 4)
                { val[i] = four.Pop(); }
                else if (five.Count > 0 && stackfrom == 5)
                { val[i] = five.Pop(); }
                else if (six.Count > 0 && stackfrom == 6)
                { val[i] = six.Pop(); }
                else if (seven.Count > 0 && stackfrom == 7)
                { val[i] = seven.Pop(); }
                else if (eight.Count > 0 && stackfrom == 8)
                { val[i] = eight.Pop(); }
                else if (nine.Count > 0 && stackfrom == 9)
                { val[i] = nine.Pop(); }
                else
                {
                    break;
                }
            } //move them
            for (int i = amount - 1; i > -1; i--)
            {
                if (stackto == 1)
                { one.Push(val[i]); }
                else if (stackto == 2)
                { two.Push(val[i]); }
                else if (stackto == 3)
                { three.Push(val[i]); }
                else if (stackto == 4)
                { four.Push(val[i]); }
                else if (stackto == 5)
                { five.Push(val[i]); }
                else if (stackto == 6)
                { six.Push(val[i]); }
                else if (stackto == 7)
                { seven.Push(val[i]); }
                else if (stackto == 8)
                { eight.Push(val[i]); }
                else if (stackto == 9)
                { nine.Push(val[i]); }
            }


        }

        Console.WriteLine("Total Elements are: " + one.Count + " " + two.Count + " " + three.Count + " " + four.Count + " " + five.Count + " " + six.Count + " " + seven.Count + " " + eight.Count + " " + nine.Count);
        Console.WriteLine("Top Elements are: " + one.Peek() + two.Peek() + three.Peek() + four.Peek() + five.Peek() + six.Peek() + seven.Peek() + eight.Peek() + nine.Peek());
    }*/ //RFFFWBPNS p1
     //CQQBBJFCS p2
}
