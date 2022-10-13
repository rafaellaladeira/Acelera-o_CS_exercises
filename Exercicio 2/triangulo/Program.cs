namespace triangulo;

public static string Triangle()
{
     public static teste(double xSide, double ySide, double zSide)
    {
        var name = "";

        if (xSide == ySide == zSide) name = "Triângulo Equilátero";
        else if ((xSide == ySide) || (ySide == zSide) || (zSide == xSide)) name = "Triângulo Isósceles";
        else name = "Triângulo Escaleno";

        return name;
    }
}