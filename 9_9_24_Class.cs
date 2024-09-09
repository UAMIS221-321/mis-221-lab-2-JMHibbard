// beg main
int firstNum = GetANumber();
int secondNum = GetANumber();
//System.Console.WriteLine(firstNum);
System.Console.WriteLine("Before the swap");
DisplayNumbers(firstNum, secondNum);
//Swap(firstNum,secondNum);
CompareNum(firstNum, secondNum);
Swap(ref firstNum, ref secondNum);
System.Console.WriteLine("After the swap");
DisplayNumbers(firstNum, secondNum);
CompareNum(firstNum, secondNum);
//DisplayNumbers(secondNum, firstNum);

// end main

static int GetANumber(){
    System.Console.WriteLine("Please enter a num");
    return int.Parse(Console.ReadLine());
}

static void DisplayNumbers(int firstNum, int secondNum){
    System.Console.WriteLine("The first num is "  + firstNum);
    System.Console.WriteLine($"The second num is {secondNum}");
}
//temporary swap
/*static void Swap(int firstNum, int secondNum){
    int temp = firstNum;
    firstNum = secondNum;
    secondNum = temp;
    System.Console.WriteLine("In the Swap");
    DisplayNumbers(firstNum, secondNum);
}*/
//swapping the references
static void Swap(ref firstNum, ref secondNum){
    int temp = firstNum;
    firstNum = secondNum;
    secondNum = temp;
    System.Console.WriteLine("In the Swap");
    DisplayNumbers(firstNum, secondNum);
}

static void CompareNum(int firstNum, int secondNum){
    if (firstNum > secondNum){
        System.Console.WriteLine("The first num is >");
    }else if(secondNum>firstNum){
        System.Console.WriteLine("The second num is >");
    } else{
        System.Console.WriteLine("They're the same");
    }
}