namespace Pine2D.Math;

public static class MathP
{
	public static double Map(double x, double inMin, double inMax, double outMin, double outMax)
	{
		return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}

public struct ComplexNum
{
	public ComplexNum(double re, double im)
	{
		Re = re;
		Im = im;
	}

	public readonly double Re;
	public readonly double Im;
}