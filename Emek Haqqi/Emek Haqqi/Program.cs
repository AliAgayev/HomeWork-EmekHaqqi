using System;

namespace Emek_Haqqi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContiniue = true;
            double grossSalary = 0;
            string maritalStatus = "";
            double familyAllowance = 0;
            int childrenCount = 0;
            double childCompensation = 0;
            string degreeOfDisability = "";
            double inComeTaxPercent = 0;
            double inComeTaxAmount = 0;
            double latestSalary = 0;
            do
            {
                Console.Write("Emek haqqini daxil edin: ");
                grossSalary = Convert.ToInt32(Console.ReadLine());
                Console.Write("Aile veziyyetini daxil edin (e/E: evli, s/S: subay, d/D: dul) : ");
                maritalStatus = Console.ReadLine().ToLower();

                if (maritalStatus == "e" || maritalStatus == "d")
                {
                    if (maritalStatus == "e")
                    {
                        familyAllowance += 50;
                        grossSalary = grossSalary + familyAllowance;
                    }

                    Console.Write("Usaq sayini daxil edin: ");
                    childrenCount = Convert.ToInt32(Console.ReadLine());
                    if (childrenCount == 1)
                    {
                        childCompensation += 30;
                        grossSalary = grossSalary + childCompensation;
                    }
                    else if (childrenCount == 2)
                    {
                        childCompensation = 30 + 25;
                        grossSalary = grossSalary + childCompensation;
                    }
                    else if (childrenCount == 3)
                    {
                        childCompensation = 30 + 25 + 20;
                        grossSalary = grossSalary + childCompensation;
                    }
                    else
                    {
                        childCompensation = 30 + 25 + 20 + (childrenCount - 3) * 15;
                    }
                }

                Console.Write("Elillik dereceniz varmi? (b / B: bəli, y / Y: yox)");
                degreeOfDisability = Console.ReadLine().ToLower();
                if (degreeOfDisability == "y")
                {
                    if (grossSalary <= 1000)
                    {
                        inComeTaxPercent = 15;
                        inComeTaxAmount = (grossSalary / 100) * 15;
                        latestSalary = grossSalary - inComeTaxAmount;
                    }
                    else if (grossSalary > 1000 || grossSalary <= 2000)
                    {
                        inComeTaxPercent = 20;
                        inComeTaxAmount = (grossSalary / 100) * 20;
                        latestSalary = grossSalary - inComeTaxAmount;
                    }
                    else if (grossSalary > 2000 || grossSalary <= 3000)
                    {
                        inComeTaxPercent = 25;
                        inComeTaxAmount = (grossSalary / 100) * 25;
                        latestSalary = grossSalary - inComeTaxAmount;
                    }
                    else if (grossSalary > 3000)
                    {
                        inComeTaxPercent = 30;
                        inComeTaxAmount = (grossSalary / 100) * 30;
                        latestSalary = grossSalary - inComeTaxAmount;
                    }

                }
                else
                {
                    if (grossSalary <= 1000)
                    {
                        inComeTaxPercent = 15 / 2;
                        inComeTaxAmount = (grossSalary / 100) * 15;
                        latestSalary = grossSalary - inComeTaxAmount;
                    }
                    else if (grossSalary > 1000 || grossSalary <= 2000)
                    {
                        inComeTaxPercent = 20 / 2;
                        inComeTaxAmount = (grossSalary / 100) * 20;
                        latestSalary = grossSalary - inComeTaxAmount;
                    }
                    else if (grossSalary > 2000 || grossSalary <= 3000)
                    {
                        inComeTaxPercent = 25 / 2;
                        inComeTaxAmount = (grossSalary / 100) * 25;
                        latestSalary = grossSalary - inComeTaxAmount;
                    }
                    else if (grossSalary > 3000)
                    {
                        inComeTaxPercent = 30 / 2;
                        inComeTaxAmount = (grossSalary / 100) * 30;
                        latestSalary = grossSalary - inComeTaxAmount;
                    }
                }

                Console.WriteLine($"Aile muavinetiniz = {familyAllowance}");
                Console.WriteLine($"Usaq pulunuz = {childCompensation}");
                Console.WriteLine($"Gelir vergisi dereceniz = {inComeTaxPercent} ");
                Console.WriteLine($"Gelir vergisi mebleginiz = {Math.Round(inComeTaxAmount,2)}");
                Console.WriteLine($"Umumi emek haqqiniz = {grossSalary}");
                Console.WriteLine($"Xalis emek haqqiniz = {latestSalary}");


                int[] Currencies = { 200, 100, 50, 20, 10, 5, 1 };
                int currencyCount = 0;

                foreach (var item in Currencies)
                {
                    currencyCount = Convert.ToInt32(Math.Floor(latestSalary / item));

                    if (currencyCount != 0)
                    {
                        Console.WriteLine($"{item} AZN-lik {currencyCount} eded pul vahidi");
                    }
                    latestSalary = latestSalary - (currencyCount * item);
                }

                string query = "";
                Console.WriteLine("Basqa isci melumati elave etmek isteyirsinizmi? (b / B: bəli, x / X: xeyr)");
                query = Console.ReadLine().ToLower();
                if (query=="b")
                {
                    isContiniue = true;
                }
                else
                {
                    isContiniue = false;
                }


            } while (isContiniue);
        }
    }
}
