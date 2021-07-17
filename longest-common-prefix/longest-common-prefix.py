import re
class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        try:
            pattern = "^" + strs[0][0]
        except:
            return ""
        i = 0
        while True:   
            for str in strs:
                try:
                    assert re.search(pattern, str) is not None
                except:
                    if i == 0:
                        return ""
                    else:
                        return pattern[1:len(pattern)-1]
            i += 1
            try:
                pattern += strs[0][i]
            except:
                return pattern[1:len(pattern)]