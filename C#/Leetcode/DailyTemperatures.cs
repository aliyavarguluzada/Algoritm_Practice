namespace C_.Leetcode
{
    public static class DailyTemperatures
    {
        public static int[] DailyTemperaturesS(int[] temperatures)
        {

            // Input: temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
            // Output: [1, 1, 4, 2, 1, 1, 0, 0]

            int[] answers = new int[temperatures.Length];



            for (int i = 0; i < temperatures.Length; i++)
            {
                int day = 0;

                for (global::System.Int32 j = i + 1; j < temperatures.Length; j++)
                {
                    if (temperatures[i] < temperatures[j])
                    {
                        day++;
                        answers[i] = day;
                        break;
                    }
                    else
                    {
                        day++;
                    }
                }
            }


            return answers;
        }
    }
}
