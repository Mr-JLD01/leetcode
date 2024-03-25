class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        string_size = len(s)
        position = 0
        size = 1
        largest = 0
        moved_position = False

        while position + size <= string_size:
            substring = s[position : size + position]

            if size > 1 and substring[-1:] == substring[-2:-1]:
                position += size - 1
                continue

            char_set = set(substring)
            moved_position = False
            for char in char_set:
                if substring.count(char) > 1:
                    position += 1
                    moved_position = True
                    break
            if not moved_position:
                largest = size
                size += 1
        return largest