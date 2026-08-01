Input:

SumNumbers(5)



=========================

Calling

=========================



SumNumbers(5)

│

└── 5 + SumNumbers(4)

&#x20;     │

&#x20;     └── 4 + SumNumbers(3)

&#x20;           │

&#x20;           └── 3 + SumNumbers(2)

&#x20;                 │

&#x20;                 └── 2 + SumNumbers(1)

&#x20;                       │

&#x20;                       └── 1 + SumNumbers(0)

&#x20;                             │

&#x20;                             └── return 0



=========================

Returning

=========================



SumNumbers(0) = 0

&#x20;       ↑

SumNumbers(1) = 1 + 0 = 1

&#x20;       ↑

SumNumbers(2) = 2 + 1 = 3

&#x20;       ↑

SumNumbers(3) = 3 + 3 = 6

&#x20;       ↑

SumNumbers(4) = 4 + 6 = 10

&#x20;       ↑

SumNumbers(5) = 5 + 10 = 15



=========================

Output

=========================



15

