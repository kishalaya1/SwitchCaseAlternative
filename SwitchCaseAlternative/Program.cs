// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Reflection;

Console.WriteLine("Hello, World!");



#region Switch case Functions
static void SwitchCaseExample()
{
    Console.WriteLine("Please enter a letter from A to E in Upper Case: ");
    string? inputLetter = Console.ReadLine();
    string selectedKey = inputLetter ?? string.Empty;
    OriginalSwitchCase(selectedKey);
}

#region Switch Case expression
static void SwitchCaseExpressionExample()
{
    Console.WriteLine("Executing a switch-expression Demo");
    Console.WriteLine("Please enter a letter from A to E in Upper Case: ");
    string? inputLetter = Console.ReadLine();
    string selectedKey = inputLetter ?? string.Empty;

    // Use a switch expression to pick the Action to run
    Action target = selectedKey switch
    {
        "A" => CaseA,
        "B" => CaseB,
        "C" => CaseC,
        "D" => CaseD,
        "E" => CaseE,
        _ => None
    };

    target();
}
#endregion
static void OriginalSwitchCase(string caseToExecute)
{
    Console.WriteLine("Executing a classic switch statement Demo ");

    switch (caseToExecute)
    {
        case "A":
            CaseA();
            break;
        case "B":
            CaseB();
            break;
        case "C":
            CaseC();
            break;
        case "D":
            CaseD();
            break;
        case "E":
            CaseE();
            break;
        default:
            None();
            break;
    }

}
#endregion

#region Switch Case Alternative

Dictionary<string, (Action Action, string Name)> functionMap = new()
{
    ["A"] = (CaseA, nameof(CaseA)),
    ["B"] = (CaseB, nameof(CaseB)),
    ["C"] = (CaseC, nameof(CaseC)),
    ["D"] = (CaseD, nameof(CaseD)),
    ["E"] = (CaseE, nameof(CaseE)),
};

static void Default(Dictionary<string, (Action Action, string Name)> functionMap)
{
    Console.WriteLine("Please select a letter in Upper Case to execute the particular algorithm example: ");
    foreach (var func in functionMap)
    {
        Console.WriteLine($"{func.Key} : {func.Value.Name }");
    }
    string? inputLetter = Console.ReadLine();
    string selectedKey = inputLetter ?? string.Empty;    
    if (functionMap.TryGetValue(selectedKey, out var target))
    {
        target.Action();
    }
    else
    {
        None();
    }    
}

#endregion


#region  Major Functions
static void None()
{
    Console.WriteLine("No function selected to execute");
    Console.ReadKey();
}
static void CaseA()
{
    Console.WriteLine("executing Case A");

    Console.ReadKey();
}
static void CaseB()
{
    Console.WriteLine("executing Case B");

    Console.ReadKey();
}
static void CaseC()
{
    Console.WriteLine("executing Case C");

    Console.ReadKey();
}
static void CaseD()
{
    Console.WriteLine("executing Case D");

    Console.ReadKey();
}
static void CaseE()
{
    Console.WriteLine("executing Case E");

    Console.ReadKey();
}
#endregion

#region executable Func

//uncomment this function to run switch case example
//SwitchCaseExample();

//uncomment this function to run switch case expression example
//SwitchCaseExpressionExample();

//uncomment this function to run switch case alternative example
Default(functionMap);

#endregion