# Pilgrim
a microservice cluster for single-domain authentication.

## Summary

All microservice clusters require a way to authenticate users. Pilgrim is a cluster of microservices for managing those tasks.

## Questions

* Is it possible to break IdentityServer 4 into parts and deploy it as serverless functions?
* Can I build and deploy an Azure Function (FaaS) conditionally depending on variables checked into code?
* Can I build and deploy an Azure Function (FaaS) conditionally depending on environmental variables?
* Which characters should go into a password salt? All upper/lower letters + digits + shifted digits = (26 + 26 + 10 + 10) = 72. Sixty-four could be pulled out of a random bitstream with six bits. A 64-character salt with 64 possible character values = a keyspace of 2<sup>6<sup>36</sup></sup> possible values.

## Links

* [Generating secure random numbers in C#](https://stackify.com/csharp-random-numbers/)
* [RNGCryptoServiceProvider Class](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.rngcryptoserviceprovider?redirectedfrom=MSDN&view=netframework-4.8)
* [RNGCryptoServiceProvider in .Net Core](https://stackoverflow.com/questions/38632735/rngcryptoserviceprovider-in-net-core)
* [How to store a password in database?](https://www.geeksforgeeks.org/store-password-database/)
* [How to store user passwords securely?](https://nakedsecurity.sophos.com/2013/11/20/serious-security-how-to-store-your-users-passwords-safely/)
* [Password-Based Key Derivation Function 2](https://en.wikipedia.org/wiki/PBKDF2)
* [bcrypt](https://en.wikipedia.org/wiki/Bcrypt)
* [Overview of ASP.NET Core Security](https://docs.microsoft.com/en-us/aspnet/core/security/?view=aspnetcore-3.0) - Start here.
* [Security Basics and ASP.NET Support (C#)](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-security/introduction/security-basics-and-asp-net-support-cs)
* [An Overview of Forms Authentication (C#)](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-security/introduction/an-overview-of-forms-authentication-cs)
* [User-Based Authorization (C#)](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-security/membership/user-based-authorization-cs)
* [Creating and Managing Roles (C#)](https://docs.microsoft.com/en-us/aspnet/web-forms/overview/older-versions-security/roles/creating-and-managing-roles-cs)

