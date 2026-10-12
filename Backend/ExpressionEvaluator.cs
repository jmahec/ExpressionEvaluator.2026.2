using System.Globalization;

namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix) => EvalutePostfix(ToPostfix(infix));

    // Splits the text into tokens: whole numbers (multi-digit and decimal), operators and parentheses.
    private static Queue<string> Tokenize(string infix)
    {
        var tokens = new Queue<string>();
        var i = 0;
        while (i < infix.Length)
        {
            if (char.IsDigit(infix[i]) || infix[i] == '.')
            {
                var start = i;
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    i++;
                }
                tokens.Enqueue(infix.Substring(start, i - start));
            }
            else
            {
                tokens.Enqueue(infix[i].ToString());
                i++;
            }
        }
        return tokens;
    }

    private static Queue<string> ToPostfix(string infix)
    {
        var postfix = new Queue<string>();
        var stack = new Stack<string>();
        foreach (var token in Tokenize(infix))
        {
            if (!IsOperator(token))
            {
                postfix.Enqueue(token);
            }
            else if (token == ")")
            {
                var ope = stack.Pop();
                while (ope != "(")
                {
                    postfix.Enqueue(ope);
                    ope = stack.Pop();
                }
            }
            else
            {
                // Pops every operator with a priority greater than or equal to the incoming one.
                while (stack.Count > 0 && PriorityStack(stack.Peek()) >= PriorityInfix(token))
                {
                    postfix.Enqueue(stack.Pop());
                }
                stack.Push(token);
            }
        }
        while (stack.Count > 0)
        {
            postfix.Enqueue(stack.Pop());
        }
        return postfix;
    }

    private static int PriorityStack(string op) => op switch
    {
        "^" => 3,
        "*" => 2,
        "/" => 2,
        "+" => 1,
        "-" => 1,
        "(" => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityInfix(string op) => op switch
    {
        "^" => 4,
        "*" => 2,
        "/" => 2,
        "+" => 1,
        "-" => 1,
        "(" => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static bool IsOperator(string item) => item is "^" or "*" or "/" or "+" or "-" or "(" or ")";

    private static double EvalutePostfix(Queue<string> postfix)
    {
        var stack = new Stack<double>();
        foreach (var item in postfix)
        {
            if (IsOperator(item))
            {
                var ope2 = stack.Pop();
                var ope1 = stack.Pop();
                stack.Push(Calculate(ope1, ope2, item));
            }
            else
            {
                stack.Push(double.Parse(item, CultureInfo.InvariantCulture));
            }
        }
        return stack.Pop();
    }

    private static double Calculate(double ope1, double ope2, string item) => item switch
    {
        "*" => ope1 * ope2,
        "/" => ope1 / ope2,
        "+" => ope1 + ope2,
        "-" => ope1 - ope2,
        "^" => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}
