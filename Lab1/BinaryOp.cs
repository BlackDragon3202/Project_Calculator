using System;

namespace Lab1
{
    public class BinaryOp
    {
        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Возвращает сумму чисел</returns>
        public Double Add(Double first, Double second)
        {
            return first + second;
            
        }
/// <summary>
/// Действие над переменными, которое выбирает пользователь.
/// </summary>
/// <param name="currentVar"></param>
/// <param name="secondVar"></param>
/// <returns>Возвращает результат операции</returns>
        public Double Action(Double currentVar, Double secondVar) {
            Double answer = currentVar;
            Boolean check = true;
            while (check) {
                string act = Console.ReadLine();
                check = false;
                switch(act) {
                    case "+":
                    answer = Add(currentVar, secondVar);
                   // check = false;
                    break;
                    case "-":
                    answer = Minus(currentVar, secondVar);
                    //check = false;
                    break;
                    case "*":
                    answer = Mult(currentVar, secondVar);
                   // check = false;
                    break;
                    case "/":
                    answer = Div(currentVar, secondVar);
                   // check = false;
                    break;
                    case "^":
                    answer = Pow(currentVar, secondVar);
                   // check = false;
                    break;
                    case "%":
                    answer = Mod(currentVar, secondVar);
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
        /// Вычитание
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns> Возвращает разность чисел</returns>
        public Double Minus(Double first, Double second) {
            return first - second;
        } 
        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Возвращает произведение</returns>
        public Double Mult(Double first, Double second) {
            return first * second;
        }
        /// <summary>
        /// Делит одно число на другое
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Возвращает частное</returns>
        public Double Div(Double first, Double second) {
            return first / second;
        }
        /// <summary>
        /// Возводит одно число в степень,  равную
        /// другому числу
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Возвращает результат</returns>
        public Double Pow(Double first, Double second) {
            return Math.Pow(first, second);
        }
        /// <summary>
        /// Остаток от деления
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>ВОзвращает остаток от деления</returns>
        public Double Mod(Double first, Double second) {
           return first % second;
       }
    }
}
