Input:

FindFactorial(5)



=========================

Calling

=========================



FindFactorial(5)

│

└── 5 × FindFactorial(4)

&#x20;     │

&#x20;     └── 4 × FindFactorial(3)

&#x20;           │

&#x20;           └── 3 × FindFactorial(2)

&#x20;                 │

&#x20;                 └── 2 × FindFactorial(1)

&#x20;                       │

&#x20;                       └── return 1



=========================

Returning

=========================



FindFactorial(1) = 1

&#x20;       ↑

FindFactorial(2) = 2 × 1 = 2

&#x20;       ↑

FindFactorial(3) = 3 × 2 = 6

&#x20;       ↑

FindFactorial(4) = 4 × 6 = 24

&#x20;       ↑

FindFactorial(5) = 5 × 24 = 120



=========================

Output

=========================



120

