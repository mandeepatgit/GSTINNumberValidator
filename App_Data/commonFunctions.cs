using System;
using System.Collections.Generic;

using System.Web;

/// <summary>
/// Summary description for commonFunctions
/// </summary>
public class commonFunctions
{

    public commonFunctions()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /**
	 * Method to get the check digit for the gstin (without checkdigit)
	 * 
	 * @param gstinWOCheckDigit
	 * @return : GSTIN with check digit
	 * @throws Exception
	 */
    public static string getGSTINWithCheckDigit(string gstinWOCheckDigit)
    {
        int factor = 2;
        int sum = 0;
        int checkCodePoint = 0;
        char[] inputChars;
        char[] cpChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        try
        {
            if ((gstinWOCheckDigit == null))
                throw new Exception("GSTIN supplied for checkdigit calculation is null");
            //char[] charArr = sentence.ToCharArray();
            //cpChars = GSTN_CODEPOINT_CHARS.ToCharArray();
            inputChars = gstinWOCheckDigit.Trim().ToCharArray();
            int mod = cpChars.Length;
            //int i = (inputChars.Length - 1);
            for (int i = inputChars.Length - 1; i >= 0; i--)
            {
                int codePoint = -1;
                for (int j = 0; j < cpChars.Length; j++)
                {
                    if (cpChars[j] == inputChars[i])
                    {
                        codePoint = j;
                    }
                }
                int digit = (factor * codePoint);
                factor = (factor == 2) ? 1 : 2;
                digit = (digit / mod) + (digit % mod);
                sum += digit;
            }
            checkCodePoint = (mod - (sum % mod)) % mod;
            return (gstinWOCheckDigit + cpChars[checkCodePoint]);
        }
        finally
        {
            inputChars = null;
            cpChars = null;
        }
    }
    /**
	 * Method for checkDigit verification.
	 * 
	 * @param gstinWCheckDigit
	 * @return
	 * @throws Exception
	 */
    public static bool verifyCheckDigit(String gstinWCheckDigit)
    {
        Boolean isCDValid = false;
        String newGstninWCheckDigit = null;
        if (gstinWCheckDigit.Length < 15)
        {
            return isCDValid;
        }
        else
        {
            newGstninWCheckDigit = getGSTINWithCheckDigit(gstinWCheckDigit.Substring(0, gstinWCheckDigit.Length - 1));
        }
        if (gstinWCheckDigit.Trim().Equals(newGstninWCheckDigit))
        {
            isCDValid = true;
        }
        return isCDValid;
    }

}