class Solution
    {
        //Complete this function
        public int count;
        public int lcs(int x, int y,string s1, string s2)
        {
            // your code here
            count = 0; 
            int iterator = 0;
            for(int ictr = 0; ictr < s1.Length; ictr++)
            {
                iterator = 0;
                for(int ictr1 = 0; ictr1 < s2.Length; ictr1++)
                {
                    if(s1[ictr] == s2[ictr1] && iterator == 0)
                    {
                        count+=1;
                        iterator += 1;
                    }
                }
            }
            return count;
        }
    }