using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        public static void Group_By_Owner(Dictionary<string, string> dict)
        {
            Dictionary<string, List<string>> valuePairs = new Dictionary<string, List<string>>();
            foreach (var item in dict)
            {
                var itemKey = item.Key;
                var itemValue = item.Value;
                if (valuePairs.ContainsKey(itemValue))
                {
                    valuePairs[itemValue].Add(itemKey);
                }
                else
                {
                    List<string> lst = new List<string>();
                    lst.Add(itemKey);
                    valuePairs.Add(itemValue, lst);
                }
            }
            foreach (var item in valuePairs)
            {
                string fileNames = "";
                foreach (var item1 in item.Value)
                {
                    fileNames += item1 + ",";

                }
                Console.WriteLine(item.Key + " : [" + fileNames.Trim(',') + "]");

            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>(){
                {"Input.txt", "Randy"},
                {"Code.py", "Stan"},
                {"Output.txt", "Randy"}
            };
            Group_By_Owner(dict);
        }
    }
    }
