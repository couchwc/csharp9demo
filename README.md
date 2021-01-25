# C#9 Demo App

This is a C#8 project. However, there are a few places where upgrading to C#9 can make things a lot clearer and more concise using the new features of the language. 

New features are [here](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#pattern-matching-enhancements).

Here's a checklist of stuff I put around to be used to upgrade the app:
- [ ] [Records](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/records)
- [ ] [Init only setters](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/init)
- [x] [Top-level statements](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/top-level-statements)
- [ ] [Pattern matching enhancements](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/patterns3) (admittedly I could've gotten more creative with this one)
- [x] [Target-typed new expressions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-new)
- [x] [Static anonymous functions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/static-anonymous-functions)
- [x] [Covariant return types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/covariant-returns)
- [x] [Extension GetEnumerator support for foreach loops](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/extension-getenumerator)
- [x] [Lambda discard parameters](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/lambda-discard-parameters)

Here's stuff I didn't put in and why
- [Native sized integers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/native-integers) <- This is for low level optimization
- [Function pointers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/function-pointers) <- This is only for unsafe code
- [Suppress emitting localsinit flag](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/skip-localsinit) <- This is for low level optimization
- [Target-typed conditional expressions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-conditional-expression) <- This is nuance for optimization
- [Attributes on local functions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/local-function-attributes) <- Would be too convoluted to shoehorn into this app
- [Module initializers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/module-initializers) <- Would be too convoluted to shoehorn into this app
- [New features for partial methods](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/extending-partial-methods) <- This is for generated code
