using System;
using System.Collections.Generic;

namespace Lab1
{
    public class MultipleOp
    {
        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Возвращает сумму чисел</returns>
        public Double Add(Double first, List<Double> list)
        {
            foreach (Double element in list)
            {
                first += element;
            }
            return first;
        }
        /// <summary>
        /// Действие над переменными, которое выбирает пользователь.
        /// </summary>
        /// <param name="currentVar"></param>
        /// <param name="secondVar"></param>
        /// <returns>Возвращает результат операции</returns>
        public Double Action(Double currentVar, List<Double> list)
        {
            Double answer = currentVar;
            Boolean check = true;
            while (check)
            {
                string act = Console.ReadLine();
                check = false;
                switch (act)
                {
                    case "+":
                        answer = Add(currentVar, list);

                        break;
                    case "-":
                        answer = Minus(currentVar, list);

                        break;
                    case "*":
                        answer = Mult(currentVar, list);

                        break;
                    default:
                        check = true;
                        break;
                }
            }
            return answer;

        }

        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns> Возвращает разность чисел</returns>
        public Double Minus(Double first, List<Double> list)
        {
            foreach (Double element in list)
            {
                first -= element;
            }
            return first;
        }


        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Возвращает произведение</returns>
        public Double Mult(Double first, List<Double> list)
        {
            foreach (Double element in list)
            {
                first *= element;
            }
            return first;
        }

    }
}
