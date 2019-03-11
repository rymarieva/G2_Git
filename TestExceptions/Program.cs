﻿using System;

namespace TestExceptions
{
    class Program
    {
        public static void MethodWithException()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("My code produce exception");
            }
            
        }

        static void Main(string[] args)
        {
            Exception exception = new Exception("Message");

            string testString = null;

            try
            {
                Console.WriteLine(testString.Length);
                Console.WriteLine("Code after exception");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Catch area:");
                Console.WriteLine(e.Message);
                //throw new Exception($"My own exception, old message {e.Message}");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Catch NullReferenceException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Just Exception");
            }

            MethodWithException();
            Console.WriteLine("----------------------------");

            try
            {
                throw new Exception("Exception for finally");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Catch {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finally area");
            }

            Console.ReadKey();
        }
    }
}
