class Solution:
    def fizzBuzz(self, n: int) -> List[str]:
        arr = []
        for i in range(1,n+1):
            arr.append("")
            if i % 3 == 0:
                arr[i-1] += "Fizz"
            if i % 5 == 0:
                arr[i-1] += "Buzz"
            elif i % 3 != 0:
                arr[i-1] += str(i)
        return arr