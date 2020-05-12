using System;
using System.Collections;
using System.Linq;
using System.Management.Instrumentation;
using System.Collections.Generic;
using System.ComponentModel;

public class AnalyzerClass
{
    // here will be analyzing stuff

    /// <summary>
    /// позиція виразу, на якій знайдена синтаксична помилка (у
    /// випадку відловлення на рівні виконання - не визначається)
    /// </summary>
    private static int erposition = 0;

    /// <summary>
    /// Вхідний вираз
    /// </summary>
    public static string expression = "";

    /// <summary>
    /// Показує, чи є необхідність у виведенні повідомлень про помилки.
    /// У разі консольного запуску програми це значення - false.
    /// </summary>
    public static bool ShowMessage = true;
    /// <summary>
    /// Останнє повідомлення про помилку.
    /// Поле і властивість для нього
    /// </summary>
    public static string lastError = "";
    /// <summary>
    /// Перевірка коректності структури в дужках вхідного виразу
    /// </summary>
    /// <returns>true - якщо все нормально, false- якщо є
    /// помилка</returns>
    /// метод біжить по вхідному виразу, символ за символом аналізуючи
    /// його, і рахуючи кількість дужок. У разі виникнення
    /// помилки повертає false, а в erposition записує позицію, на
    /// якій виникла помилка.
    public static bool CheckCurrency()
    {
        int p = 0, k = 0;
        for(int i = 0; i < expression.Length; i++)
        {
            if (expression.Substring(i, 1) == "(")
            {
                //if(i > 1 && i < expression.Length -1 && !Char.IsNumber(expression, i-1) && expression.Substring(i-1, 1) != " " && !Char.IsNumber(expression, i + 1) && expression.Substring(i + 1, 1) != " ")
                //{
                //    p = 1;
                //    k = i;
                //    break;
                //}
                p++;
                k = i;
            }
            else if (expression.Substring(i, 1) == ")")
            {
                p--;
            }
        }
        if (p != 0)
        {
            lastError = "Error 01 at " + (k + 1).ToString();
            erposition = k;
            return false;
        }
        return true;
    }

    /// <summary>
    /// Форматує вхідний вираз, виставляючи між операторами
    /// пропуски і видаляючи зайві, а також знаходить нерозпізнані оператори, стежить за кінцем рядка
    /// а також знаходить помилки в кінці рядка
    /// </summary>
    /// <returns>кінцевий рядок або повідомлення про помилку, що починаються з спец. символу &</returns>
    public static string Format()
    {
        string newExp = "";
       
        if (expression.Substring(0,1) == "(")
        {
            newExp = newExp + expression.Substring(0, 1);
        }
        else if (Char.IsNumber(expression, 0))
        {
            newExp = newExp + expression.Substring(0, 1);
        }
        else
        {
            return "Помилка початку виразу";
        }
        for (int i = 1; i < expression.Length; i++)
        {
            
            if (expression.Substring(i, 1) != " ")
            {
                if (Char.IsNumber(expression, i))
                {
                    if (!Char.IsNumber(expression, i - 1))
                    {
                        newExp = newExp + " ";
                    }
                    newExp = newExp + expression.Substring(i, 1);
                }
                else if (expression.Substring(i, 1) == "+" || expression.Substring(i, 1) == "-" || expression.Substring(i, 1) == "/" || expression.Substring(i, 1) == "*" || expression.Substring(i, 1) == "(" || expression.Substring(i, 1) == ")" || expression.Substring(i, 1) == "%")
                {
                    if (i > 3 && newExp.Substring(i - 1, 1) == " " && (newExp.Substring(i - 1, 1) == "+" || newExp.Substring(i - 1, 1) == "-" || newExp.Substring(i - 1, 1) == "/" || newExp.Substring(i - 1, 1) == "*" || expression.Substring(i - 1, 1) == "%"))
                    {
                        //Два підряд оператори на <i> символі.
                        lastError = "Error 04 at " + (i + 1).ToString();
                        erposition = i;
                        return "Error 04 at " + (i + 1).ToString();
                    }
                    newExp = newExp + " " + expression.Substring(i, 1);
                }
                else
                {
                    //Невідомий оператор на <i> символі.
                    lastError = "Error 02 at " + (i + 1).ToString();
                    erposition = i;
                    return "Error 02 at " + (i + 1).ToString();
                }
            }
        }
        if (!Char.IsNumber(expression, expression.Length - 1) && expression.Substring(expression.Length - 1, 1) != " " && expression.Substring(expression.Length - 1, 1) !=")")
        {
            //Незавершений вираз
            lastError = "Error 05";
            return "Error 05";
        }
        expression = newExp;
        return newExp;
    }

    /// <summary>
    /// Формує масив, в якому розташовуються оператори і символи
    /// представлені в зворотному польському записі(без дужок)
    /// На цьому ж етапі відшукується решта всіх помилок (див.
    /// код). По суті - це компіляція.
    /// </summary>
    /// <returns>массив зворотнього польського запису</returns>
    public static ArrayList CreateStack(ArrayList stack, string[] expMas)
    {
        ArrayList temp = new ArrayList();
        for (int i = 0; i < expMas.Length; i++)
        {
            if(expMas[i] == "(")
            {
                int p = 0;
                for (int j=i+1;j< expMas.Length; j++)
                {
                    if(expMas[j] == "(")
                    {
                        p++;
                    }
                    if(expMas[j] == ")")
                    {
                        if(p == 0)
                        {
                            string[] newMas = new string[j - i - 1];
                            for (int k = 0; k < j - i - 1; k++)
                            {
                                newMas[k] = expMas[i + 1 + k];
                            }
                            stack = CreateStack(stack, newMas);
                            i = j;
                            break;
                        }
                        p--;
                    }
                }
                if (temp.Count != 0 && (temp[temp.Count - 1].Equals("*") || temp[temp.Count - 1].Equals("/") || temp[temp.Count - 1].Equals("%")))/*temp[temp.Count - 1] == "*" || temp[temp.Count - 1] == "/" || temp[temp.Count - 1] == "%")*/
                {
                    stack.Add(temp[temp.Count - 1]);
                    temp.RemoveAt(temp.Count - 1);
                }
                if (temp.Count != 0 && (i < expMas.Length - 1 && (expMas[i + 1] == "+" || expMas[i + 1] == "-")))
                {

                    stack.Add(temp[temp.Count - 1]);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
            if (Char.IsNumber(expMas[i], 0))
            {
                stack.Add(expMas[i]);
                if (temp.Count != 0 && (temp[temp.Count - 1].Equals("*") || temp[temp.Count - 1].Equals("/") || temp[temp.Count - 1].Equals("%")))/*temp[temp.Count - 1] == "*" || temp[temp.Count - 1] == "/" || temp[temp.Count - 1] == "%")*/
                {
                    stack.Add(temp[temp.Count - 1]);
                    temp.RemoveAt(temp.Count - 1);
                }
                if (temp.Count != 0 && (i < expMas.Length - 1 && (expMas[i + 1] == "+" || expMas[i + 1] == "-")))
                {

                    stack.Add(temp[temp.Count - 1]);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
            else if (expMas[i] == "+" || expMas[i] == "-" || expMas[i] == "*" || expMas[i] == "/" || expMas[i] == "%")
            {
                temp.Add(expMas[i]);
            }
        }
        while(temp.Count != 0)
        {
            stack.Add(temp[temp.Count - 1]);
            temp.RemoveAt(temp.Count - 1);
        }
        return stack;
    }

    /// <summary>
    /// Обчислення зворотнього польського запису
    /// </summary>
    ///<returns>результат обчислень,або повідомлення про помилку</returns>
    public static string RunEstimate(ArrayList stack)
    {
        ArrayList temp = new ArrayList();
        for(int i = 0; i < stack.Count; i++)
        {
            if (Char.IsNumber(stack[i].ToString(), 0))
            {
                temp.Add(stack[i]);
            }
            else
            {
                double left = Convert.ToDouble(temp[temp.Count - 2]);
                double right = Convert.ToDouble(temp[temp.Count - 1]);
                temp.RemoveAt(temp.Count - 1);
                temp.RemoveAt(temp.Count - 1);
                switch (stack[i])
                {
                    case "+":
                        temp.Add(CalcClass.Add(left, right).ToString());
                        break;
                    case "-":
                        temp.Add(CalcClass.Sub(left, right).ToString());
                        break;
                    case "*":
                        temp.Add(CalcClass.Mult(left, right).ToString());
                        break;
                    case "/":
                        temp.Add(CalcClass.Div(left, right).ToString());
                        break;
                    case "%":
                        temp.Add(CalcClass.Mod(left, right).ToString());
                        break;

                }
            }
            
        }
        return temp[0].ToString();
    }
    
    /// <summary>
    /// Метод, який організовує обчислення. По черзі запускає
    /// CheckCorrency, Format, CreateStack і RunEstimate
    /// </summary>
    /// <returns></returns>
    public static string Estimate(string exp)
    {
        expression = exp;
        CheckCurrency();
        //Console.WriteLine(expression);
        Console.WriteLine(Format());
        string[] expMas = expression.Split(' ');
        ArrayList stack = new ArrayList();
        stack = CreateStack(stack, expMas);
        //for (int i = 0; i < stack.Count; i++)
        //{
        //    Console.WriteLine(stack[i]);

        //}
        Console.WriteLine(RunEstimate(stack));
        return expression;
    }
}


