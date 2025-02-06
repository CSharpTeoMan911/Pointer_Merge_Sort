# Pointer Merge Sort in C# 🚀
## Overview
This project demonstrates an advanced implementation of the Merge Sort algorithm using unsafe code and pointer manipulation in C#. The goal is twofold:

1) Performance Optimization ⚡: Merge Sort is traditionally known for its high memory usage due to frequent array copying. By leveraging pointers and manual memory management, this implementation minimizes memory overhead while maintaining the efficiency of the algorithm.
  
2) Showcase Advanced C# Features 💡: This project illustrates the capabilities of C# to manage memory like lower-level languages such as C and C++, offering a unique blend of high-level syntax and low-level control. Through the use of pointers, memory pinning, and direct memory manipulation, the project demonstrates how C# can handle complex memory tasks traditionally reserved for languages like C or C++.


## Key Features 🔑
* Unsafe Code 🔓: The use of unsafe keyword enables pointer arithmetic, offering performance improvements by accessing memory directly.
* Pointer-Based Memory Management 🧠: Unlike typical C# applications, this implementation manipulates memory directly using pointers, enabling low-level memory optimization while sorting.
* Manual Memory Allocation and Deallocation 💻: Using GCHandle to pin memory allows the program to work with pointers without worrying about garbage collection interference, mimicking manual memory management seen in C and C++.
* Merge Sort Algorithm 🏃: A classic divide-and-conquer sorting algorithm, implemented using pointer-based memory handling for better performance and reduced memory consumption.
* Benchmarking Performance 📊: The project benchmarks the sorting time over 100 iterations to highlight the performance improvements and memory management efficiency.

## Why This Project? 🤔
While C# is often seen as a higher-level language, this project aims to prove that it can perform low-level memory manipulation operations typically associated with languages like C and C++. By using unsafe code, we can access and manipulate raw memory directly, improving performance without sacrificing the ease of programming that C# provides.

By manually allocating and deallocating memory, the project ensures that the garbage collector does not interfere with memory management, leading to a more efficient use of memory compared to standard C# array-based operations. This approach allows the algorithm to perform similarly to traditional implementations in C/C++ while benefiting from C#'s high-level capabilities.

This project highlights how C# can be a powerful tool for system-level programming, where performance and memory control are crucial, without sacrificing the rich feature set of the language.

## Features Explored 🌟
* Unsafe Code 🔓: The unsafe modifier allows you to work directly with memory addresses and pointers. This enables the manipulation of data with much more control than typical C# code.
* Memory Pinning 📌: GCHandle.Alloc is used to pin memory, preventing the garbage collector from moving objects. This ensures safe access to raw memory addresses.
* Manual Memory Management 🛠️: By allocating and deallocating memory manually, we replicate a C/C++-like memory management style, optimizing memory use while working with large datasets.
* Merge Sort with Pointers 🔀: This implementation optimizes the classic Merge Sort algorithm by using pointers to avoid unnecessary memory allocations, reducing overhead in terms of both speed and memory consumption.
* Real-World Benchmarking ⏱️: The project includes performance benchmarks, measuring the time taken to sort large datasets, which demonstrate the benefits of using unsafe code and pointer manipulation for performance-critical applications.
  
## How It Works 🔧
### Memory Allocation and Pointers 🔍

Instead of relying on standard array operations, this implementation utilizes pointers to directly manage memory. Here’s how memory is managed:

1) Pinning Memory 📌: The GCHandle.Alloc method is used to pin memory, preventing the garbage collector from moving objects. This ensures that pointers can safely reference memory without risking access violations.

2) Pointer Manipulation ⚙️: Using unsafe code, the algorithm manipulates pointers directly, accessing and modifying values in memory. This approach eliminates the need for traditional array copying, which can be costly in terms of both time and memory.

3) Recursive and Iterative Sorting 🔄: The Merge Sort algorithm recursively divides the array into smaller subarrays, sorting them and then merging them back together. Pointers are used to traverse and manipulate the arrays directly during the merge process.

## Garbage Collection Control 🧹
Since garbage collection can interfere with memory manipulation, this implementation uses GCHandle to pin memory and ensure that the garbage collector doesn’t move objects around. This gives the program full control over memory, similar to how it would be handled in lower-level languages.

## Performance Optimization 🚀
The project compares the performance of the pointer-based implementation of Merge Sort to traditional array-based implementations by sorting large datasets and measuring execution time. By using pointers, this implementation is more memory-efficient and faster compared to conventional Merge Sort implementations in C#.

## How to Run the Project 🏁
1) Clone the repository to your local machine.

2) Open the project in Visual Studio or Visual Studio Code.

3) Ensure that the project is set to allow unsafe code. You can do this by modifying the .csproj file as follows:

```
<PropertyGroup>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
</PropertyGroup>
```

4) Build and run the project. The program will execute and print the performance benchmarks for sorting large datasets using the Pointer Merge Sort algorithm.

## Conclusion 🏆
This project serves as both a performance optimization and a showcase of C#'s ability to handle low-level memory operations typically associated with languages like C and C++. By using unsafe code and pointer manipulation, the project demonstrates that C# is capable of achieving memory efficiency and high performance similar to native code. Whether you’re working with large datasets or need to optimize memory-intensive applications, this implementation shows how you can leverage the power of pointers in C# to get the best of both worlds—high-level ease of development and low-level memory management control.

## License 📜
This code is licensed under the GNU General Public License version 2. Please see the LICENSE file for more details.
