# SQLite vs LiteDB

```md
BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.1042/21H2)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100-rc.1.22431.12
  [Host] : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain

|                     Method |    Mean |    Error |   StdDev |        Gen0 |       Gen1 |      Gen2 | Allocated |
|--------------------------- |--------:|---------:|---------:|------------:|-----------:|----------:|----------:|
| Get_All_Record_From_SQLite | 1.496 s | 0.1200 s | 0.3537 s |  22000.0000 |  9000.0000 | 2000.0000 | 121.22 MB |
| Get_All_Record_From_LiteDB | 2.308 s | 0.1572 s | 0.4634 s | 118000.0000 | 33000.0000 | 4000.0000 | 687.48 MB |

```
