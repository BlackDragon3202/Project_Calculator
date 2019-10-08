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
