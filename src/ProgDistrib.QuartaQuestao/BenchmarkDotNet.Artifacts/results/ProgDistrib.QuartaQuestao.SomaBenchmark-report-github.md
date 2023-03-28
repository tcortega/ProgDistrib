``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1265/22H2/2022Update/SunValley2)
12th Gen Intel Core i5-12400F, 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.201
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2


```
|     Method |      Mean |    Error |   StdDev |
|----------- |----------:|---------:|---------:|
| SomaRapida |  38.98 ms | 0.309 ms | 0.289 ms |
|  SomaLerda | 162.43 ms | 3.139 ms | 3.489 ms |
