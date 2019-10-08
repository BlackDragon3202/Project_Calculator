using System;

namespace Lab1
{
    public class SingleOp
    {
        /// <summary>
        /// Действие над переменной, которое выбирает пользователь
        /// </summary>
        /// <param name="variable"></param>
        /// <returns>Возвращает новое значение переменной</returns>
        public Double Action(Double variable)
        {
            Double answer = variable;
            Boolean check = true;
            while (check)
            {
                string act = Console.ReadLine();
                check = false;
                switch (act)
                {
                    case "Abs":
                        answer = Abs(variable);
                        // check = false;
                        break;
                    case "-":
                        answer = Minus(variable);
                        break;
                    case "+":
                        answer = Plus(variable);
                        break;
                    case "++":
                        answer = Increment(variable);
                        break;
                    case "Sin":
                        answer = Sinus(variable);
                        break;
                    case "Cos":
                        answer = Cos(variable);
                        break;
                    case "--":
                        answer = Decrement(variable);
                        break;
                    case "Fact":
                        answer = Fact(variable);
                        //check = false;
                        break;
                    case "Sqrt":
                        answer = Sqrt(variable);
                        // check = false;
                        break;
                    default:
                        check = true;
                        break;
                }
            }
            return answer;
        }

        public Double Minus(Double variable)
        {
            if (variable > 0)
            {
                return -1 * variable;
            }
            return variable;
        }
        public Double Sinus(Double variable)
        {
            return Math.Sin(variable);
        }
        public Double Cos(Double variable)
        {
            return Math.Cos(variable);
        }

        public Double Increment(Double variable)
        {
            return ++variable;
        }
        public Double Decrement(Double variable)
        {
            return --variable;
        }

        public Double Plus(Double variable)
        {
            if (variable < 0)
            {
                return -1 * variable;
            }
            return variable;
        }


        /// <summary>
        /// Корень числа
        /// </summary>
        /// <param name="variable"></param>
        /// <returns>Возвращает корень числа</returns>

        public Double Sqrt(Double variable)
        {
            return Math.Sqrt(variable);
        }
        /// <summary>
        /// Модуль числа
        /// </summary>
        /// <param name="variable"></param>
        /// <returns>Возвращает модуль числа</returns>
        public Double Abs(Double variable)
        {
            return Math.Abs(variable);
        }
        /// <summary>
        /// Факториал числа
        /// </summary>
        /// <param name="variable"></param>
        /// <returns>Возвращает факториал числа</returns>
        public Double Fact(Double variable)
        {
            if (Convert.ToInt32(variable) <= 1)
            {
                // Console.WriteLine("ABC");
                return 1;
            }
            else if (Convert.ToInt32(variable) == variable)
            {
                return variable * Fact(variable - 1);
            }
            return variable;
        }
    }
}
