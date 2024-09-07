public class clsCalculator
{
    public static float FinalResult = 0.0f;

    public delegate float delOnMathOperation(float Num1, float Num2);
    delOnMathOperation OnMathOperation;

    public clsCalculator(delOnMathOperation MathOperation)
    {
        this.OnMathOperation = MathOperation;
    }

    public float PerformOperation(float EffectedNumber, float Number)
    {
        return OnMathOperation.Invoke(EffectedNumber, Number);
    }
    public float PerformSharedOperation(float Number)
    {
        return OnMathOperation.Invoke(clsCalculator.FinalResult, Number);
    }
}