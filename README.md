# Pilgrim
a microservice cluster for single-domain authentication.

## Summary

All microservice clusters require a way to authenticate users. Pilgrim is a cluster of microservices for managing those tasks.

## Notes

### Password Salting

A _salt_ is an alphanumeric representation of a binary number, an encoding like UTF-8. It is prepended or appended to a plaintext password to thwart the use of off-the-shelf rainbow tables for brute-force cryptanalysis. Static salts have the advantage of not being stored with usernames and requiring an additional breach to reveal. Dynamic salts are stored with the password on a per-user basis, but have the advantage of requiring a unique rainbow table for each user.

The most secure method is to use both an application-level static salt and a user-level dynamic salt in order to prevent both single-point-of-breach and single-rainbow-table cryptanalysis.

## Testing

In addition to a full suite of unit tests, the application will require automated penetration and "cracking" tests. Cracking tests should have an adjustable intensity to allow for periodic "no-holds-barred" testing.

Also, we should figure out how feasible it is to create and destroy databases in Azure on demand for automated testing.

## Questions

* Is it possible to break IdentityServer 4 into parts and deploy it as serverless functions?
* Can I build and deploy an Azure Function (FaaS) conditionally depending on variables checked into code?
* Can I build and deploy an Azure Function (FaaS) conditionally depending on environmental variables?
* Which characters should go into a password salt? All upper/lower letters + digits + shifted digits = (26 + 26 + 10 + 10) = 72. Sixty-four could be pulled out of a random bitstream with six bits. A 64-character salt with 64 possible character values = a keyspace of 2<sup>216</sup> possible values?

## Links

* [Geary tests (test of randomness](https://www.statisticssolutions.com/runs-test-of-randomness/)
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

