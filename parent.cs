using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace sodokoORG
{
    public class parent : sdk
    {
        public static bool parent1(int[,] a, string result)
        {

            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0) Console.Write("");

                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0) Console.Write(" ");
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            string rresult = "";
            string cresult = "";
            string cresult1 = "";
            string cresult2 = "";
            string cresult3 = "";
            string cresult4 = "";
            string cresult5 = "";
            string cresult6 = "";
            string cresult7 = "";
            string cresult8 = "";
            string cresult9 = "";

            Thread row = new Thread(() => sdk.row1(a, rresult));
            Thread colmn = new Thread(() => sdk.colmn1(a, cresult));
            Thread home1 = new Thread(() => sdk.home1(a, cresult));
            Thread home2 = new Thread(() => sdk.home2(a, cresult));
            Thread home3 = new Thread(() => sdk.home3(a, cresult));
            Thread home4 = new Thread(() => sdk.home4(a, cresult));
            Thread home5 = new Thread(() => sdk.home5(a, cresult));
            Thread home6 = new Thread(() => sdk.home6(a, cresult));
            Thread home7 = new Thread(() => sdk.home7(a, cresult));
            Thread home8 = new Thread(() => sdk.home8(a, cresult));
            Thread home9 = new Thread(() => sdk.home9(a, cresult));
            row.Start();
            colmn.Start();
            home1.Start();
            try
            {
                row.Join();
                if (rresult == "false")
                {
                    result = "false";
                }

                colmn.Join();
                if (cresult == "false")
                {
                    result = "false";
                }
                home1.Join();
                if (cresult1 == "false")
                {
                    result = "false";
                }
                home2.Join();
                if (cresult2 == "false")
                {
                    result = "false";
                }
                home3.Join();
                if (cresult3 == "false")
                {
                    result = "false";
                }
                home4.Join();
                if (cresult4 == "false")
                {
                    result = "false";
                }
                home5.Join();
                if (cresult5 == "false")
                {
                    result = "false";
                }
                home6.Join();
                if (cresult6 == "false")
                {
                    result = "false";
                }
                home7.Join();
                if (cresult7 == "false")
                {
                    result = "false";
                }
                home8.Join();
                if (cresult8 == "false")
                {
                    result = "false";
                }
                home9.Join();
                if (cresult9 == "false")
                {
                    result = "false";
                }

            }
            catch (Exception)
            {

                return true;
            }

            return true;



        }
    }
}
