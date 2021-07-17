class Solution:
    def countPrimes(self, n: int) -> int:
        primes = [1] * n
        numPrimes = 0
        for i in range(2,n):
            if not primes[i]:
                continue
            numPrimes += 1
            for j in range(i**2, n, i):
                primes[j] = 0
        return numPrimes