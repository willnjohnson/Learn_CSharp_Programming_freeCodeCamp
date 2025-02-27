﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Learn_CSharp_Programming_freeCodeCamp
{
    internal class Program
    {
        // [#051] Structures
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            public Person(string name, int age, int birthMonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;
            }
        };

        // [#052 / #053 / #054] Classes / Class functions / Class fields
        class Person2
        {
            private string name;
            private int age;

            // [#055] Class properties (shorthand to setters and getters)
            public string Name { 
                get => name; 
                set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name"; 
            }
            public int Age {  
                get => age; 
                set => age = (value >= 0 && value <= 150) ? value : -1; 
            }

            public Person2(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            /* Without arrow function
            public void SetName(string name)
            {
                this.name = (!string.IsNullOrEmpty(name)) ? name : "Invalid name";
            }

            public string GetName()
            {
                return name;
            }

            public void SetAge(int age)
            {
                this.age = (age >= 0 && age <= 150) ? age : -1;
            }

            public int GetAge()
            {
                return age;
            } 
            
            */

            // With arrow function, similar to Javascript
            public void SetName(string name) => this.name = (!string.IsNullOrEmpty(name)) ? name : "Invalid name";

            public string GetName() => name;

            public void SetAge(int age) => this.age = (age >= 0 && age <= 150) ? age : -1;

            public int GetAge() => age;

            public string ReturnDetails()
            {
                //return $"Name: {name}\nAge: {age}";
                return $"Name: {Name}\nAge: {Age}";
            }

            // Override
            public override string ToString()
            {
                return $"Name: {Name}\nAge: {Age}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Person2)
                {
                    Person2 person = obj as Person2;
                    return Name.Equals(person.Name) && Age == person.Age;
                }

                return false;
            }
        }

        static void Main(string[] args)
        {
            /* 
            [#001] Hello world
            
            Console.WriteLine("Hello world!");

            */

            /*
            [#002] Numeric data types

            Console.WriteLine($"Integers range from {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"Longs range from {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"Doubles range from {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"Floats range from {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"Decimals range from {decimal.MinValue} to {decimal.MaxValue}");

            int age = 27;
            Console.WriteLine(age);

            long bigNumber = 900_000_000L;
            Console.WriteLine(bigNumber);

            double negative = -55.2D;
            Console.WriteLine(negative);

            float precision = 5.000001F;
            Console.WriteLine(precision);

            decimal money = 14.99M;
            Console.WriteLine(money);

            int x = 10, y = 20, z = 30;

            */

            /*
            [#003] Text based data types

            string name = "William";
            char letter = 'W';

            Console.WriteLine($"My name is {name}");
            Console.WriteLine(letter);
            */

            /*
            [#004] Converting string to numbers

            int age = Convert.ToInt32("27"); // convert string 27 to int
            long bigNumber = Convert.ToInt64("900000000");
            double negative = Convert.ToDouble("-55.2");
            float precision = Convert.ToSingle("5.000001");
            decimal money = Convert.ToDecimal("14.99");
            Console.WriteLine(age);
            Console.WriteLine(bigNumber);
            Console.WriteLine(negative);
            Console.WriteLine(precision);
            Console.WriteLine(money);
            */

            /*
            [#005] Boolean data type

            bool isMale = true;
            Console.WriteLine(isMale);
            */

            /*
            [#006] Operators

            int age = 27;
            Console.WriteLine(++age); // increment then print
            Console.WriteLine(age); // print
            Console.WriteLine(age--); // print then decrement

            age += 1;
            age = age + 1;
            Console.WriteLine(age);

            age *= 10;
            Console.WriteLine(age);

            Console.WriteLine((Double) age / 3);

            char ch = 'a'; // U+0061
            ch += 'b'; // U+0062
            Console.WriteLine(ch); // U+00C3

            */

            /*
            [#007] Remainder
            
            int firstNum = 10;
            int secondNum = 3;

            Console.WriteLine(firstNum % secondNum); // 10 / 3 = 3r1
            */

            /*
            [#008] Var keyword (personally I would probably avoid using var, just to maintain good practices)

            var age = 27;
            var bigNumber = 900_000L;
            var negative = -55.2D;
            var precision = 5.000001F;
            var money = 14.99M;
            */

            /*
            [#009] Const keyword

            const int vat = 20; // note: cannot re-assign const's value to another value
            const double percentVAT = vat / 100D;
            int balance = 1000;

            Console.WriteLine(balance * percentVAT);
            */

            /*
            [#010] Exercise - Storing user data

            string name = "William";
            string number = "0123456789";
            int age = 27;

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);
            */

            /*
            [#011] Exeercise - Odd/Even checker

            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;

            Console.WriteLine(remainder==0 ? "Even" : "Odd");
            Console.WriteLine((num1 & 1)==1 ? "Odd" : "Even"); // alternate way
            */

            /*
            [#012] Console Input/Output

            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.Write($"Hello, {name}. How old are you? ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            Console.WriteLine($"Cool! You're {age}");
            */

            /*
            [#013] If statements
            
            Console.Write("How old are you? ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age >= 16)
            {
                Console.WriteLine("You can drive!");
            } else if (age >= 18)
            {
                Console.WriteLine("You can enlist in the army!");
            } else if (age >= 21)
            {
                Console.WriteLine("You can drink!");
            } else {
                Console.WriteLine("You're too young!");
            }
            */

            /*
            [#014] Switch statements

            Console.WriteLine("Enter day of the week (0: Sunday to 6: Saturday)");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 0: 
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It is Wednesday my dudes!");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("I don't know what day that is.");
                    break;
            }
            */

            /* 
            [#015] While loops

            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine($"Psst. Your random number is {randomNumber}");
            Console.WriteLine("Guess the number!");

            int answer = -1;

            do
            {
                Console.WriteLine("What number was generated?");
                string guess = Console.ReadLine();
                answer = Convert.ToInt32(guess);


                if (answer != randomNumber)
                {
                    Console.WriteLine("Try again!");
                }
            } while (answer != randomNumber);

            Console.WriteLine("Congrats!");
            */

            /*
            [#016] Numeric formatting

            double money = 10D / 3D; // 3.3333

            Console.WriteLine(money);
            Console.WriteLine(string.Format("£10 / £3 = £{0:.00}", money));
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            */

            /*
            [#017] TryParse function
            
            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine(); // 10h

                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(numInput);
                } else
                {
                    Console.WriteLine("Failed to convert!");
                }
            }
            */

            /*
            [#018] Times table

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine("{0} x {1} = {2}", i, num, i * num);
                Console.WriteLine($"{i} x { num} = {i*num}");
            }
            */

            /*
            [#019] Fizz buzz game

            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else if (i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            [#020] Verbatim string literal

            string speech = "He saod \"something\"";
            string path = "C:\\Users\\William\\Desktop\\C# Course";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            path = @"C:\Users\William\Desktop\C# Course"
            Console.WriteLine(path);
            */

            /*
            [#021] String interpolation

            string name = "William";
            int age = 27;

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.WriteLine($"Your name is {name} and your age is {age}");
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);

            Console.WriteLine(string.Concat("Your name is ", nameof, " and your age is ", age));

            string[] names = new string[] { "William", "Test", "Test" };
            Console.WriteLine(string.Concat(names);
            */

            /*
            [#022] Empty string

            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            
            if (name != "")
            {
                Console.WriteLine($"Your name is {name}");
            } else
            {
                Console.WriteLine("Name is empty");
            }
            */

            /*
            [#023] String Equals function

            string message = "Hello";
            string compare = "Hello";

            if (message == compare)
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Diff");
            }
            */

            /*
            [#024] String iteration looping
            
            string message = "C# is awesome";

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('C'))
                {
                    contains = true;
                }
            }

            Console.WriteLine(contains);
            */

            /*
            [#025] String IsNullOrEmpty function

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            if (name != "")
            {
                Console.WriteLine("0");
            }

            if (!name.Equals(""))
            {
                Console.WriteLine("1");
            }

            // better choice, because checks NULL case
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("2");
            }
            */

            /*
            [#026] Print string in reverse
            

            Console.WriteLine("Enter your message: ");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.Write('-');

            // hint: type "forr" to bring up IntelliSense shortcut
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            */

            /*
            [#027] Password checker
            
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password again: ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordC.Length >= 6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Passwords match");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                        }
                    } else
                    {
                        Console.WriteLine("Please enter 6 or more characters!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation.");
                }
            } else
            {
                Console.WriteLine("Please enter a password.");
            }
            */

            /*
            [#028] Arrays

            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 30;

            Console.WriteLine($"{num1} {num2} {num3} {num4}");

            int[] numbers = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i+1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine() );
            }

            int angleSum = 0;
            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum==180 ? "Valid" : "Invalid");
            */

            /*
            [#029] Array sorting

            int[] numbers = new int[]
            {
                9, 2, 0, 5, 5, 6, 7, 8, 9
            };

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            */

            /*
            [#030] Array reversal

            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            Array.Reverse(numbers);

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            */

            /*
            [#031] Array clearing

            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            Array.Clear(numbers, 5, 5);

            for (int i = 5; i < 10; i++)
            {
                numbers[i] = default;
            }

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            */

            /*
            [#031] Array IndexOf
            
            int[] numbers = new int[]
            {
                90, 199, 22, 50, 30
            };

            Console.WriteLine("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers, search, 0, 2);

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");
            } else
            {
                Console.WriteLine($"Number {search} has not been found");
            }
            */

            /* 
            [#032] Lists <>

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }
            */

            /* 
            [#033] Dictionary

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                { "Math", "William" },
                { "Science", "Test" }
            };

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teachers["Math"]);
                teachers["Math"] = "New Teach";
            } else
            {
                Console.WriteLine("Math teacher not found");
            }

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            */

            /* 
            [#034] Exercise - Odd/Even number split

            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                } else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Printing even numbers:");
            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nPrinting odd numbers:");
            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }
            */

            /*
            [#035] Exercise - Array of multiples

            int num = 10;
            int length = 10;
            int[] result = new int[length];
            int counter = 0;

            for (int i = 1; i <= result.Length; i++, counter++)
            {
                result[counter] = num * i;
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            */

            /*
            [#036] Functions

            WelcomeMessage();
            */

            /*
            [#037] Void functions
            
            bool success = int.TryParse("123", out int result);
            Console.WriteLine(success);

            string test = "Hello";

            StringBuilder sb = new StringBuilder();
            */

            /*
            [#037] Return type functions

            PrintIntroduction();

            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }
            
            foreach (int item in numbers)
            {
                Console.Write($"{ item} ");
            }
            */

            /*
            [#038] Function parameters

            Console.WriteLine(Add(50, 50));

            int num = ReadInt("Enter a number");
            Console.WriteLine(num);

            int num1 = ReadInt("Angle");
            Console.WriteLine(num1);

            int firstNum = ReadInt("Enter first number");
            int secondNum = ReadInt("Enter second number");

            Console.WriteLine(Add(firstNum, secondNum));
            */

            /*
            [#039] Optional parameters

            int result = Add2(5);
            Console.WriteLine(result);

            PrintName();
            */

            /*
            [#040] Named parameters 

            string nameInput = "William";
            int ageInput = 27;
            string addressInput = "123 Somewhere Lane";

            PrintDetails(   age: ageInput, 
                            name: nameInput, 
                            address: addressInput);
            */

            /*
            [#041] Out parameters

            int num = 0;
            bool success = test(out num);
            Console.WriteLine(num); // 5
            Console.WriteLine(success); // True

            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk"
            };

            Console.Write("Enter an item to search: ");
            string search = Console.ReadLine();

            Console.WriteLine(
                FindInList(search, shoppingList, out int index) ? $"Found {search} at index {index}" : "Not found"
                );
            */

            /*
            [#042] Reference parameters

            string name = "William";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName)) {
                Console.WriteLine($"Your new name is {name}!");
            } else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }
            */

            /*
            [#043] Exercise: Area of a Triangle

            int width = ReadInt("Enter width");
            int height = ReadInt("Enter height");

            int result = CalcArea(width, height);

            Console.WriteLine($"The area is {result}");
            */

            /*
            [#044] Exercise: Sum of int Array

            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            int result = SumOfNumbers(numbers);

            if (result > -1)
                Console.WriteLine($"The total is {result}");
            else
                Console.WriteLine("Cannot add up an empty array!");

            if (SumOfNumbers(numbers, out int total))
                Console.WriteLine($"The total is {total}");
            else
                Console.WriteLine("Cannot add up an empty array!");
            */


            /*
            [#045 / #046 / #047] Exception handling, Try...catch, and Printing error messages

            int num = 0;
            bool isChecking = true;

            while (isChecking)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Incorrect format!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Number too large!");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }

            Console.WriteLine($"Successfully entered {num}");
            */

            /*
            [#048] Exercise - Custom TryParse

            bool isSuccessful = false;
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(isSuccessful ? "Cool!" : "Eh!");

            Console.Write("Enter a number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Cool!");
            } else
            {
                Console.WriteLine("Eh!");
            }
            */

            /*
            [#049] Debugging

            string name = "William";
            int age;
            age = 27;

            PrintDetails(name, age);

            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);
            */

            /*
            [#050] Example: Fix logic error
            
            int age = 35;

            if (age > 18) // && age < 30)
            {
                Console.WriteLine("Over 18");
            } else if (age > 30) // && age < 50)
            {
                Console.WriteLine("Over 30");
            } else if (age > 50)
            {
                Console.WriteLine("Over 50");
            }
            */

            /* 
            [#051] Structures
            
            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth} - {person.number}");
            */

            /*
            [#052 / #053 / #054] Classes / Class functions / Class fields

            Person2 person = new Person2("William", 27); // calls the constructor

            //Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());

            person.SetName("New Name");
            person.SetAge(20);
            Console.WriteLine($"Your name is {person.GetName()} and your age is {person.GetAge()}");
            */

            /*
            [#055] Class properties 

            Person2 person = new Person2("William", 27);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Harry";
            person.Age = 20;
            Console.WriteLine($"Your name is {person.GetName()} and your age is {person.GetAge()}");
            */

            /*
            [#056] Class ToString function override
            */
            Person2 person = new Person2("William", 27);
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine(person.ToString());
            Console.WriteLine(person);

            Person2 anotherPerson = new Person2("William", 27);

            if (person.Equals(anotherPerson))
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Not same");
            }

            person.Name = "Harry";
            person.Age = 20;

            Console.WriteLine(person.ReturnDetails());

            if (person.Equals(anotherPerson))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }

            Console.ReadLine(); 
        }


        static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}";
        }

        static Person ReturnPerson()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birthmonth: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Person person;

            //person.name = name;
            //person.age = age;
            //person.birthMonth = birthMonth;
            //person.number = number;

            //return person;

            return new Person(name, age, birthMonth, number);
        }

        static string ReadFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
        }

        static bool TryParse(string input, out int result)
        {
            result = -1;

            try {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // better approach
        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;

            if (numbers.Length <= 0)
                return false;

            foreach (int number in numbers)
            {
                total += number;
            }

            return true;
        }

        // note: downside, what if numbers list contains negative number?
        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length <= 0)
                return -1;

            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }

        static int CalcArea(int width, int height)
        {
            return (width * height) / 2;
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            
            return false;
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }

        static bool MyTryParse(string s, out int result)
        {
            result = 0;
            return true;
        }

        static bool test(out int num)
        {
            num = 5;
            return true;
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }

        static void PrintName(string name = "William")
        {
            Console.WriteLine($"My name is {name}");
        }

        static int Add2(int a, [Optional] int b) // alternatively, can have "int b = default"
        {
            Console.WriteLine($"b = {b}");
            return a + b;
        }

        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Calling function");
        }

        static string ReturnName()
        {
            return "William";
        }

        static int ReturnAge()
        {
            return 27;
        }

        static void PrintIntroduction()
        {
            Console.WriteLine(ReturnName());
            Console.WriteLine(ReturnAge());
        }
    }
}
