# Exercise 2: Implementing the Factory Method Pattern

## Scenario:
You are developing a document management system that needs to create different types of documents (e.g., Word, PDF, Excel). To support this extensibility and decoupling, the Factory Method Pattern is used.

## Steps Taken:

### 1. Create a New C# Project:
- Initialized a new **C# Console Application** named `FactoryMethodPatternExample`.

### 2. Define Document Interfaces:
- Created a **common interface** `IDocument` which defines a method `Open()` for all document types.

### 3. Create Concrete Document Classes:
- Implemented the `IDocument` interface in separate classes:
  - `WordDocument`
  - `PdfDocument`
  - `ExcelDocument`
- Each class provided its own implementation of the `Open()` method.

### 4. Implement the Factory Method:
- Created an **abstract class** `DocumentFactory` with an abstract method `CreateDocument()`.
- Created **concrete factory classes**:
  - `WordDocumentFactory`
  - `PdfDocumentFactory`
  - `ExcelDocumentFactory`
- Each factory class overrides `CreateDocument()` to return an instance of the appropriate document type.

### 5. Test the Factory Method Implementation:
- Created a test class to demonstrate the creation and usage of different document types using their corresponding factories.
- Verified that document creation was abstracted and type-specific logic was encapsulated within factory classes.

## Output:
The Factory Method Pattern was successfully implemented in C#. Different types of documents (Word, PDF, Excel) were created dynamically at runtime using specialized factory classes, ensuring flexibility and adherence to the Open/Closed Principle.
![image](https://github.com/user-attachments/assets/171cd7be-0730-4ebb-8d14-da15f70b34fa)

