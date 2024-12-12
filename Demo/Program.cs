using System.ComponentModel;

namespace Demo
{
    internal class Program
    {
        //static int sum(int x, int y)
        //{
        //    return x - y;
        //}
        static void Main(string[] args)
        {
            #region Error Types
            #region Syntax Error - Compilation Error
            //console.WriteLine("Hello, World!");
            //iint x = 7;
            #endregion

            #region RunTime Error
            //int x = 5;
            //int y = 0;
            //Console.WriteLine(x / y);
            #endregion

            #region Logical Error
            //int a = 10;
            //int b = 5;
            //Console.WriteLine(sum(a, b));
            #endregion

            #region Warning
            //int x; //4 Byte
            #endregion

            #endregion

            #region Variables
            //5
            //int num = 5;
            #endregion

            #region Data Types

            #region CLS - CTS
            //int x = 5; //4 Byte
            //string name = "test"; // 8 Byte
            //name='Ali' //6 Byte
            #endregion

            #endregion

            #region Reference Type
            //Point p1;
            //p1 = new Point();

            //Point p2;
            //p2 = new Point();

            //p2 = p1;

            //p1.x = 10;
            //Console.WriteLine(p2.x);
            #endregion

            #region Object

            #endregion




            #region Notes
            /*
             * There is Compiler and Interpreter
             * Compiler checks there is no errors in code, then run like C#
             * Interpreter runs code line-by-line like Java Script
             * CLR (Stack) who's cotrol giving address to variable once you runs code
             * Once you runs code, variables saved in RAM not hard disk
               because RAM is temporary 
             * Database savd in Hard Disk
             * Data types saved in Common Type System (CTS) that have all data types in .net
             * Inside CTS there is Common Language Specification (CLS) that have common things
               between .net languages 
             * We can write more than one programming language in CLS
             * Data types saved in RAM specially in stack and heap
             * Stack Larger than heap and and we save data types in stack because we know space
             * Data types in .net divided into 2 types:- 
               1- Value type (Primitive) 
                  saved in stack 
            that larger than heap and both in the RAM
               2- Reference type (Non Primitive) 
                  saved in stack that saves address and heap that saves the main thing
             */
            #endregion
        }
}
}











