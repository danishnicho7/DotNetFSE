# Exercise 6: Implementing the Proxy Pattern

## Scenario:
You are building an **image viewer application** that retrieves images from a **remote server**. To optimize performance, you need to **delay loading** images until necessary and **cache them** after the first load. The **Proxy Pattern** is used to handle lazy initialization and caching.

## Steps Taken:

### 1. Create a New C# Project:
- Created a **C# Console Application** named `ProxyPatternExample`.

### 2. Define Subject Interface:
- Created an interface `IImage` with a method:
  - `void Display();`

### 3. Implement Real Subject Class:
- Implemented a class `RealImage` that:
  - Implements the `IImage` interface.
  - Loads an image from a simulated remote server (e.g., printing "Loading image from server...").
  - Displays the image via the `Display()` method.

### 4. Implement Proxy Class:
- Implemented a class `ProxyImage` that:
  - Also implements `IImage`.
  - Holds a private reference to a `RealImage` instance.
  - Performs **lazy initialization**: loads the image only on first `Display()` call.
  - Reuses the same `RealImage` instance for future calls (caching behavior).

### 5. Test the Proxy Implementation:
- Created a test scenario where:
  - A `ProxyImage` object is created and `Display()` is called multiple times.
  - Output shows the image is loaded from the server **only once**, and subsequent calls reuse the cached image.

## Output:
The **Proxy Pattern** was successfully implemented in **C#**, enabling **lazy loading** and **caching** of remote images. This significantly improves performance by avoiding unnecessary remote operations and promoting efficient resource use.
![image](https://github.com/user-attachments/assets/4f860ff2-2a37-4df9-bf5e-7878829bf075)
