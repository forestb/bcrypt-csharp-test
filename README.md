<!-- TOC -->

- [1. Introduction](#1-introduction)
  - [1.1. Why bcrypt?](#11-why-bcrypt)
- [2. Code Sample](#2-code-sample)
- [3. Summary](#3-summary)

<!-- /TOC -->

# 1. Introduction
The purpose of this project is to get a better understanding of ([this particular implementation of](https://archive.codeplex.com/?p=bcrypt)) bcrypt in C#/.NET.

## 1.1. Why bcrypt?
> It uses a variant of the Blowfish encryption algorithm’s keying schedule, and introduces a work factor, which allows you to determine how expensive the hash function will be. Because of this, bcrypt can keep up with Moore’s law. As computers get faster you can increase the work factor and the hash will get slower.

# 2. Code Sample
```csharp
var hashedString = BCrypt.Net.BCrypt.HashString(stringToHash, workFactor);
```

# 3. Summary
bcrypt is a hashing algorithm that 

| Work Factor | Execution Time (ms) | Message                                                                               |
| ----------- | ------------------- | ------------------------------------------------------------------------------------- |
| 10          | 181                 | Executing the hash function 1 times, with a work factor of 10 took 181 milliseconds.  |
| 11          | 368                 | Executing the hash function 1 times, with a work factor of 11 took 368 milliseconds.  |
| 12          | 1260                | Executing the hash function 1 times, with a work factor of 12 took 1260 milliseconds. |
| 13          | 1462                | Executing the hash function 1 times, with a work factor of 13 took 1462 milliseconds. |
| 14          | 4056                | Executing the hash function 1 times, with a work factor of 14 took 4056 milliseconds. |
| 15          | 7287                | Executing the hash function 1 times, with a work factor of 15 took 7287 milliseconds. |