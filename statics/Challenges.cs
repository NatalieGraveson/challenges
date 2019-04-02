namespace challenges
{

  static class Challenges
  {

    class program
    {
      public static int DoubleInteger(int num)
      {
        return num * 2;
      }


      public static bool IsNumberEven(int num)
      {
        return num % 2 == 0;
      }

      public static string GetFileExtention(string str)
      {
        int cutIndex = str.LastIndexOf('.');
        if (cutIndex > -1)
        {
          return str.Substring(cutIndex + 1);
        }
        return null;
      }

      public static string LongestString(string[] strArr)
      {

        string Longest = "";
        foreach (var string in strArr)
      {
          if (string.Length > Longest.Length)
          {
            Longest = string;
          }
        }
        return Longest;

      }

      public static int ArraySUm(int[] nums)
      {
        int sum = 0
  for (int i = 0; i < arr.Length; i++)
        {
          sum += arr[i];
        }
        return sum;
      }



    }







  }
}