namespace CsDll
{
    public class CorrectColor
    {
        /// <summary>
        /// The function takes the color values to be modified and then
        /// multiplies the relevant values and writes them to the bitmap,
        /// repeating this over and over again
        /// from the beginning to the end of its section
        /// </summary>
        /// <param name="RGBvalues">Pointer to the beginning of the bitmap</param>
        /// <param name="begin">The beginning of the section be processed by the function</param>
        /// <param name="finish">The end of the section to be processed by the function</param>
        /// <param name="redNew">The red color value read from the slider</param>
        /// <param name="greenNew">The green color value read from the slider</param>
        /// <param name="blueNew">The blue color value read from the slider</param>
        public static void CsColorCorr(byte[] RGBvalues, int begin, int finish, byte redNew, byte greenNew, byte blueNew)
        {
            // prepare a variable that will hold the final blue value
            float blueFinal = 0;
            // prepare a variable that will hold the final green color value
            float greenFinal = 0;
            // prepare a variable that will hold the final red value
            float redFinal = 0;

            // calculate a new blue value to be used later in the loop
            float blueCorrected = 255.0f - blueNew;
            // calculate a new green color value to be used later in the loop
            float greenCorrected = 255.0f - greenNew;
            // calculate a new red value to be used later in the loop
            float redCorrected = 255.0f - redNew;

            for (int i = begin; i <= finish - 4; i += 4)
            {
                // calculate end value for blue using original color from bitmap
                blueFinal = 255.0f / blueCorrected * (float)RGBvalues[i];
                // calculate the end value for the green color using the original color from the bitmap
                greenFinal = 255.0f / greenCorrected * (float)RGBvalues[i + 1];
                // calculate the end value for the red color using the original color from the bitmap
                redFinal = 255.0f / redCorrected * (float)RGBvalues[i + 2];

                // if the calculated value for blue color is greater than the maximum value
                // which can be written in a byte, it is set to 255
                if (blueFinal > 255)
                {
                    blueFinal = 255;
                }
                // if the computed value for a blue color is less than zero, it is replaced with zero
                else if (blueFinal < 0)
                {
                    blueFinal = 0;
                }

                // if the calculated value for green is greater than the maximum value
                // which can be written in a byte, it is set to 255
                if (greenFinal > 255)
                {
                    greenFinal = 255;
                }
                // if the calculated value for green is less than zero, it is replaced with zero
                else if (greenFinal < 0)
                {
                    greenFinal = 0;
                }

                // if the computed value for red is greater than the maximum value
                // which can be written in a byte, it is set to 255
                if (redFinal > 255)
                {
                    redFinal = 255;
                }
                // if the computed value for red is less than zero, it is replaced with zero
                else if (redFinal < 0)
                {
                    redFinal = 0;
                }

                // write new value for blue back to bitmap
                RGBvalues[i] = (byte)blueFinal;
                // write new value for green color back to bitmap
                RGBvalues[i + 1] = (byte)greenFinal;
                // write new value for red color back to bitmap
                RGBvalues[i + 2] = (byte)redFinal;
            }

        }

    }
}