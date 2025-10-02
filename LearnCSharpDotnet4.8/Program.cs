using System;
using System.Collections.Generic;
using System . IO;
using System.Linq;
using System . Runtime . CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpDotnet4._8
{
	internal class Program
	{
		static void Main(string[] args)
		{

                  #region Name

                  #endregion

                  #region File Size
                  //FileInfo f = new FileInfo("C:/wifiServiceLog.txt");

                  //string fileSize = f.Length.ToString();

                  //Console . WriteLine ("File size: " + fileSize);

                  string projectDir = Directory.GetCurrentDirectory();

                  string solutionDir = Directory.GetParent(projectDir).Parent.FullName;

                  string filePath = Path.Combine(solutionDir, "files","abc.txt");

                  FileInfo fileInfo = new FileInfo(filePath);

                  long fileSize = fileInfo.Length;

                  Console . WriteLine ($"The size of the file is:  { GetFileSize(fileSize)}" );

                  string GetFileSize ( long sizeInBytes )
                  {
                        if( sizeInBytes <= 1024 )
                        {
                              return $"{sizeInBytes} bytes";
                        }
                        else if (sizeInBytes <= 1024 * 1024 )
                        {
                              double sizeInKB = sizeInBytes / 1024.0;
                              return $"{sizeInKB:F2} KB";
                        }
                        else if ( sizeInBytes <= 1024 * 1024 * 1024 )
                        {
                              double sizeInMB = sizeInBytes /1024 * 1024 * 1024;
                              return $"{sizeInMB:F2} MB";
                        }
                        else
                        {
                              double sizzeInGB = sizeInBytes / Math.Pow(1024, 4);
                              return $"{sizzeInGB:F2} GB";

                        }
                  }



                  #endregion

                  #region Reverse Words in Sentence
                  //string line = "Display the pattern like pyramid using the alphabet.";

                  //StringBuilder result = new StringBuilder();

                  //List<string> wordList = new List<string>();

                  //string [ ] words = line.Split(new [] {" ", "\n", "\b"} , StringSplitOptions.None);

                  //for ( int i = words.Length - 1 ; i >= 0 ; i-- )
                  //{
                  //      //result += words [ i ] + " ";
                  //      result . Append ( words [i] + " ");
                  //}

                  //Console . WriteLine ("\nReverse String: " + result.ToString().Trim());


                  #endregion

                  #region Sum of digits of an integer number
                  //Console . WriteLine ("Enter an integer: ");
                  //int n =  Convert.ToInt32(Console.ReadLine());

                  //int sum = 0;

                  //while ( n != 0 )
                  //{
                  //      sum += n % 10;
                  //      n /= 10;
                  //}

                  //Console.WriteLine ("Sum of the digits of number: " +sum);

                  //Console . Write("Enter an integer: ");
                  //string input = Console.ReadLine();

                  //if ( int.TryParse(input, out int number ) )
                  //{
                  //      int sumOfDigits = input
                  //            .ToCharArray()
                  //            .Where ( c => char.IsDigit(c))
                  //            .Sum( c => c - '0');

                  //      Console.WriteLine("Sum: " +sumOfDigits);
                  //}

                  //else
                  //{
                  //      Console . WriteLine ("Please enter a valid integer.");
                  //}



                  #endregion

                  #region Sum of Prime numbers till 500
                  //bool IsPrime ( int number )
                  //{
                  //      if ( number <= 1 ) return false;

                  //      for ( int i = 2 ; i <= Math . Sqrt ( number ) ; i++ )
                  //      {
                  //            if ( number % i == 0 ) return false;
                  //      }

                  //      return true;
                  //}

                  //int count = 0;
                  //long sum = 0;
                  //int num = 2;

                  //while ( count < 5 )
                  //{
                  //      if ( IsPrime ( num ) )
                  //      {
                  //            sum += num;
                  //            count++;
                  //      }
                  //      num++;
                  //}

                  //Console . WriteLine ( "Sum: " + sum );

                  #endregion

                  #region Print Odd Numbers from 1 to 99
                  //int num = 0;

                  //for( int n =1 ; n < 100 ; n ++  )
                  //{
                  //      if ( n % 2 != 0 )
                  //      {
                  //            Console . WriteLine (n);
                  //      }
                  //}
                  #endregion

                  #region Find Longest Word in String
                  //string line = "Write a C# Sharp Program to display the following pattern using the alphabet." ;
                  //var result = FindLongesWord(line);
                  //Console . WriteLine ("Input Line: " + line );
                  //Console . WriteLine ("Longest word: " + result);

                  //string FindLongesWord( string input)
                  //{
                  //      string [ ] words = input.Split( new [] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

                  //      string longestWord = "";

                  //      foreach( string word in words )
                  //      {
                  //            if ( word.Length > longestWord . Length )
                  //            {
                  //                  longestWord = word;
                  //            }
                  //      }

                  //      return longestWord;
                  //}
                  #endregion

                  #region Add 1st Char to Front & Back
                  //string sample = "The quick brown fox jumps over the lazy dog.";
                  //var s = sample . Substring ( 0 , 1 );
                  //Console . WriteLine ( s+ sample + s  );
                  #endregion

                  #region C to K or F
                  //Console . Write("Enter the amount of celsius: " );
                  //int Tc = int.Parse(Console.ReadLine());

                  //int Tk = Tc + 273;
                  //int Tf = Tc * 18/10 + 32;

                  //Console.WriteLine("Kelvin {0}", Tk);
                  //Console.WriteLine("Fehrenheit {0}", Tf);

                  #endregion

                  #region Swap first and last characters
                  //string data1 = "w3resource";
                  //string data2 = "Python";
                  //string data3 = "to";

                  //Console . WriteLine (SwapChar(data1));
                  //Console . WriteLine (SwapChar(data2));
                  //Console . WriteLine (SwapChar(data3));

                  //string SwapChar ( string inputString)
                  //{
                  //      string l = inputString.Substring(inputString.Length - 1);
                  //      string f = inputString.Substring(0, 1);
                  //      string m = inputString.Substring(1, inputString.Length -2);
                  //      //if ( inputString . Length > 1 )
                  //      //{
                  //      //      return $"{f}{m}{n}"; 
                  //      //}
                  //      //else 
                  //      //{
                  //      //      return inputString;
                  //      //}
                  //      string swappedString = l + f + m;

                  //      //ternary operator
                  //      return inputString . Length > 1 ? swappedString : inputString;
                  //}
                  #endregion

                  #region Multiply Three Numbers
                  //int n1, n2, n3;

                  //Console . Write ("Input the first number to multiply: ");
                  //n1 = int . Parse ( Console . ReadLine ( ) );
                  //Console . Write ( "Input the second number to multiply: " );
                  //n2 = int . Parse ( Console . ReadLine ( ) );
                  //Console . Write ( "Input the third number to multiply: " );
                  //n3 = int . Parse ( Console . ReadLine ( ) );

                  //int result = n1 * n2 * n3;

                  //Console . WriteLine ($"{n1} x {n2} x {n3} = {result} " );
                  //Console . WriteLine ( "Output: {0} x {1} x {2} = {3}", n1, n2, n3, result);

                  #endregion

                  #region Remove Character by Index
                  //string  testData = "w3resource";

                  // string remove_char(string str, int n )
                  //{
                  //      return str . Remove ( n , 1 );
                  //}

                  //Console . WriteLine ("Output: " + remove_char(testData, 2) );

                  #endregion

                  #region Swap numbers 
                  //int num1, num2, temp;

                  //               Console . WriteLine ("Enter first number: " );
                  //num1 = int.Parse(Console.ReadLine ());

                  //               Console . WriteLine ("Enter second number: " );
                  //               num2 = int . Parse ( Console . ReadLine ( ) );

                  //               Console . WriteLine ( " ==== Before swapping number ====" );
                  //               Console . WriteLine ( $"First number: {num1} \n Second number: {num2}" );

                  //               temp = num1;
                  //num1 = num2;
                  //num2 = temp;

                  //               Console . WriteLine (" ==== After swapping number ====" );
                  //               Console . WriteLine ($"First number: {num1} \n Second number: {num2}" );
                  #endregion

                  Console . ReadKey ( );



		}	



    }
}


