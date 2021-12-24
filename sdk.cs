using System;
using System.Collections.Generic;
using System.Text;

namespace sodokoORG
{
    public class sdk

    {
        //Thread tr = new Thread(new ThreadStart(row1));
        public static void row1(int[,] a, string result)
        {

            int row = 0;
            int col = 0;


            int count = 0;

            while (row < a.Length)
            {
                for (col = 0; col < a.Length; col++, count = 0)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[row, col] == a[row, i])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }


        }
        public static void colmn1(int[,] a, string result)
        {
            //column
            int row = 0;
            int col = 0;
            int count = 0;

            while (col < a.Length)
            {
                for (row = 0; row < a.Length; row++, count = 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (a[row, col] == a[i, col])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                col++;


            }
            if (result == "")
            {
                result = "true";

            }


        }
        public static void home1(int[,] a, string result)
        {

            int row = 0;
            int col = 0;


            int count = 0;

            while (row < 3)
            {
                for (col = 0; col < 3; col++, count = 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (a[row, col] == a[row, i])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 0;
                int col1 = 0;
                int count1 = 0;

                while (col1 < 3)
                {
                    for (row1 = 0; row1 < 3; row1++, count1 = 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (b[row1, col1] == b[col, i])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }
        public static void home2(int[,] a, string result)
        {

            int row = 0;
            int col = 0;


            int count = 0;

            while (row < 3)
            {
                for (col = 3; col < 6; col++, count = 0)
                {
                    for (int i = 3; i < 6; i++)
                    {
                        if (a[row, col] == a[row, i])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 0;
                int col1 = 3;
                int count1 = 0;

                while (col1 < 6)
                {
                    for (row1 = 0; row1 < 3; row1++, count1 = 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (b[row1, col1] == b[i, col1])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }
        /*//     ---------------------
                | --1-- | --2-- | --3-- |                           
                |  -4-  | --5-- | --6-- |
                | --7-  | ---8- | --9-- |                        
                 ---------------------
                */
        public static void home3(int[,] a, string result)
        {

            int row = 0;
            int col = 0;


            int count = 0;

            while (row < 3)
            {
                for (col = 6; col < 9; col++, count = 0)
                {
                    for (int i = 6; i < 9; i++)
                    {
                        if (a[row, col] == a[row, i])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 0;
                int col1 = 6;
                int count1 = 0;

                while (col1 < 9)
                {
                    for (row1 = 0; row1 < 3; row1++, count1 = 0)
                    {
                        for (int i = 6; i < 9; i++)
                        {
                            if (b[row1, col1] == b[i, col1])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }
        public static void home4(int[,] a, string result)
        {

            int row = 3;
            int col = 0;


            int count = 0;

            while (row < 6)
            {
                for (col = 0; col < 3; col++, count = 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (a[col, row] == a[i, row])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 3;
                int col1 = 0;
                int count1 = 0;

                while (col1 < 3)
                {
                    for (row1 = 3; row1 < 6; row1++, count1 = 0)
                    {
                        for (int i = 3; i < 6; i++)
                        {
                            if (b[row1, col1] == b[col, i])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }
        public static void home5(int[,] a, string result)
        {

            int row = 3;
            int col = 3;


            int count = 0;

            while (row < 6)
            {
                for (col = 3; col < 6; col++, count = 0)
                {
                    for (int i = 3; i < 6; i++)
                    {
                        if (a[col, row] == a[i, row])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 3;
                int col1 = 3;
                int count1 = 0;

                while (col1 < 6)
                {
                    for (row1 = 3; row1 < 6; row1++, count1 = 0)
                    {
                        for (int i = 3; i < 6; i++)
                        {
                            if (b[row1, col1] == b[col, i])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }
        public static void home6(int[,] a, string result)
        {

            int row = 3;
            int col = 6;


            int count = 0;

            while (row < 6)
            {
                for (col = 6; col < 9; col++, count = 0)
                {
                    for (int i = 6; i < 9; i++)
                    {
                        if (a[col, row] == a[row, i])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 3;
                int col1 = 6;
                int count1 = 0;

                while (col1 < 9)
                {
                    for (row1 = 3; row1 < 6; row1++, count1 = 0)
                    {
                        for (int i = 3; i < 6; i++)
                        {
                            if (b[row1, col1] == b[i, col])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }
        public static void home7(int[,] a, string result)
        {

            int row = 6;
            int col = 0;


            int count = 0;

            while (row < 9)
            {
                for (col = 0; col < 3; col++, count = 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (a[row, col] == a[row, i])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 3;
                int col1 = 0;
                int count1 = 0;

                while (col1 < 3)
                {
                    for (row1 = 6; row1 < 9; row1++, count1 = 0)
                    {
                        for (int i = 6; i < 9; i++)
                        {
                            if (b[row1, col1] == b[i, col1])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }
        public static void home8(int[,] a, string result)
        {

            int row = 6;
            int col = 3;


            int count = 0;

            while (row < 0)
            {
                for (col = 3; col < 6; col++, count = 0)
                {
                    for (int i = 3; i < 6; i++)
                    {
                        if (a[col, row] == a[i, row])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 3;
                int col1 = 3;
                int count1 = 0;

                while (col1 < 6)
                {
                    for (row1 = 6; row1 < 9; row1++, count1 = 0)
                    {
                        for (int i = 6; i < 9; i++)
                        {
                            if (b[row1, col1] == b[i, col1])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }
        public static void home9(int[,] a, string result)
        {

            int row = 6;
            int col = 6;


            int count = 0;

            while (row < 0)
            {
                for (col = 6; col < 9; col++, count = 0)
                {
                    for (int i = 6; i < 9; i++)
                    {
                        if (a[col, row] == a[i, row])
                            count++;
                        if (count >= 2)
                            result = "false";
                    }
                }
                row++;
            }
            if (result == "")
            {
                result = "true";
            }

            void colmn1(int[,] b, string result1)
            {
                //column
                int row1 = 6;
                int col1 = 6;
                int count1 = 0;

                while (col1 < 6)
                {
                    for (row1 = 6; row1 < 9; row1++, count1 = 0)
                    {
                        for (int i = 6; i < 9; i++)
                        {
                            if (b[row1, col1] == b[i, col1])
                                count1++;
                            if (count1 >= 2)
                                result1 = "false";
                        }
                    }
                    col++;


                }
                if (result1 == "")
                {
                    result1 = "true";

                }

            }
        }

    }
}
