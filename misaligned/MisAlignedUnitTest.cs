namespace MisalignedSpace
{
    public class MisalignedUnitTest
    {
        public static void PairColorMapPrintVerification()
        {
            string expectedPairColorMap;
            bool isColorMapCorrect;
            
            expectedPairColorMap = GetColorMapPair();

            isCorrectColorPair = Debug.Equals(Misaligned.actualPairColorMap, expectedPairColorMap);
            
            if (!isCorrectColorPair)
                Console.WriteLine("Test failed!, pair color map is not correct.");
            else
                Console.WriteLine("Test passed.");
        }

        private static string GetColorMapPair()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            string output = string.Empty();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    output += $"{i * 5 + j} | {majorColors[i]} | {minorColors[j]}\r\n";
            }
            return output;
        }
    }
}
