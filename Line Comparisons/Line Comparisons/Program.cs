// See https://aka.ms/new-console-template for more information
using Line_Comparisons;
Console.WriteLine(" 1-LengthOfTheLine \n 2-TwoLinesAreEqual\n 3-CompareTwoLineswithOperaors\n 4-CompareToMethod");
int x = Convert.ToInt32(Console.ReadLine());
switch(x)
{
    case 1:
        //Console.WriteLine("Welcome To Line Comparisons Problems");
        //UC1_LengthOfTheLine.LengthOfLines();
        break;
    case 2:
        //UC2_TwoLinesEqual.TwoLinesAreEquals();

        break;
    case 3:
        //UC3_Compare_Two_Lines.ComparedTwoLines();
        break;
    case 4:
        UC4_CompareToTwoLines.CompareToMethod();
        break;
    default:
        Console.WriteLine("Complete the programme");
        break;
}




