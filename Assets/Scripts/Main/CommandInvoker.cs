using System.Collections.Generic;

/// <summary>
/// A class responsible for invoking and managing commands.
/// </summary>
public class CommandInvoker
{
    // A stack to keep track of executed commands.
    private Stack<ICommand> commandRegistry = new Stack<ICommand>();

    /// <summary>
    /// Process a command, which involves both executing it and registering it.
    /// </summary>
    /// <param name="commandToProcess">The command to be processed.</param>
    public void ProcessCommand(ICommand commandToProcess)
    {
        ExecuteCommand(commandToProcess);
        RegisterCommand(commandToProcess);
    }

    /// <summary>
    /// Execute a command, invoking its associated action.
    /// </summary>
    /// <param name="commandToExecute">The command to be executed.</param>
    public void ExecuteCommand(ICommand commandToExecute) => commandToExecute.Execute();

    /// <summary>
    /// Register a command by adding it to the command registry stack.
    /// </summary>
    /// <param name="commandToRegister">The command to be registered.</param>
    public void RegisterCommand(ICommand commandToRegister) => commandRegistry.Push(commandToRegister);
}