namespace Calculator_Kitty
{
    public class Validate
    {
        public float Num { get; set; }
        public bool Check { get; set; }
    }
    public static class Calcfunction
    {
        public static Validate IsValidNumber(string a)
        {
            var check = float.TryParse(a, out float b);
            var validation = new Validate();
            if (check)
            {
                validation.Num = b;
                validation.Check = true;
            }
            return validation;
        }

        public static bool IsValidFunction(string a)
        {
            if (a == "+" || a == "-" || a == "*" || a == "/") return true;
            return false;
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            return a / b;
        }

    }
}
