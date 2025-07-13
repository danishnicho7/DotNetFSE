# Exercise 9: Implementing the Command Pattern

## Scenario:
You are developing a **home automation system** where commands can be issued to turn devices (like lights) on or off. The **Command Pattern** is used to encapsulate requests as objects, allowing for parameterization, queuing, and logging of operations.

## Steps Taken:

### 1. Create a New C# Project:
- Created a **C# Console Application** named `CommandPatternExample`.

### 2. Define Command Interface:
- Created an interface `ICommand` with a method:
  - `void Execute();`

### 3. Implement Concrete Commands:
- Implemented two concrete command classes:
  - `LightOnCommand` that turns the light on.
  - `LightOffCommand` that turns the light off.
- Both classes implement the `ICommand` interface and hold a reference to a `Light` receiver object.

### 4. Implement Invoker Class:
- Created a class `RemoteControl` that:
  - Contains a method `SetCommand(ICommand command)` to store a command.
  - Contains a method `PressButton()` that calls `command.Execute()`.

### 5. Implement Receiver Class:
- Created a class `Light` that contains:
  - `void TurnOn()` – turns the light on.
  - `void TurnOff()` – turns the light off.

### 6. Test the Command Implementation:
- In the main program:
  - Instantiated the `Light` receiver.
  - Created `LightOnCommand` and `LightOffCommand` objects.
  - Used `RemoteControl` to execute these commands.
  - Demonstrated issuing commands to control the light.

## Output:
The **Command Pattern** was successfully implemented in **C#**, allowing decoupling between command issuers (invokers) and receivers (devices). This enables extensibility and flexibility in command management for home automation systems.
![image](https://github.com/user-attachments/assets/73ba97c2-4560-44a7-bc6a-e75e984d95c2)

