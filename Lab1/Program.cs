﻿using System;

namespace Lab1
{
    public class Program
    {

        static public bool Check(string str) {
            //string str = Console.ReadLine();
            Double num;
            bool isNum = Double.TryParse(str, out num);
            return isNum;
        }
        static void Main(string[] args)
        {
            Double currentVar = 0;
            Boolean flag = true;
            string state = "";
            string str;
            while (flag) {
            Console.WriteLine("Hello, do you want to choose option?");
            string option = Console.ReadLine();
            if (option.Equals("Yes")) {
                state = Console.ReadLine();
            }
            switch(state) {
                case "Single":
                    SingleOp op = new SingleOp();
                   
                    Console.WriteLine(currentVar);
                    currentVar = op.Action(currentVar);
                    
                    break;

                case "Binary":
                    BinaryOp binOp = new BinaryOp();
                    Console.WriteLine("Enter a second variable");
                    str = Console.ReadLine();
                    Double secondVar;
                    if (Program.Check(str)) {
                        secondVar = Double.Parse(str);
                    } else {
                        return;
                    }      
                    currentVar = binOp.Action(currentVar, secondVar);
                break;
               
                case "Exit":
                    flag = false;
                    break;
                    
                case "Clear":
                    currentVar = 0; 
                    break;
                
                case "Change":
                    bool numb = true;
                    Console.WriteLine("Enter value");
                    while (numb) {
                        str = Console.ReadLine();
                        if (Program.Check(str)) {
                            currentVar = Double.Parse(str);
                            numb = false;
                        } else {
                            Console.WriteLine("Incorrect value");
                        }        
                    }
                    break;
            }
            Console.WriteLine(currentVar);
            }
        }
 
    }
}
