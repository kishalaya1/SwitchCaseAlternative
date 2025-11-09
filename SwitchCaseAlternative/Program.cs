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

string[] FuncNames = { "CaseA", "CaseB", "CaseC", "CaseD", "CaseE" };

Action[] selectedFuncs = {
    CaseA,
    CaseB,
    CaseC,
    CaseD,
    CaseE
};

static void Default(Action[] selectedFuncs, Dictionary<string, (Action Action, string Name)> functionMap, string[] funcNames)
{
    Console.WriteLine("Please select a no to execute the particualar algorithm example: ");
    foreach (var func in functionMap)
    {
        Console.WriteLine($"{func.Key} : {func.Value.Name }");
    }
    string? inputLetter = Console.ReadLine();
    string selectedKey = inputLetter ?? string.Empty;
    //var targetFunc = functionMap[selectedKey];
    if (functionMap.TryGetValue(selectedKey, out var target))
    {
        target.Action();
    }
    // selectedFuncs[targetFunc];
    //selectedFuncs[functionMap.TryGetValue(,)]();
    //targetFunc();
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

//SwitchCaseExample();
Default(selectedFuncs, functionMap, FuncNames);

#endregion