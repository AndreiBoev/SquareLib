# ���������� ��� ���������� ������� ����� � ������������

��� ���������� ������������� ������� ��� ���������� ������� ����� � ������������ �� ������ �� ����������.

## ���������

��� ��������� ���������� ����� ��������������� NuGet:

```bash
nuget install SquareLib
```

## ���������� �� �������������

���� ���������� SquareLib.dll ��������� � ����� SquareLib/SquareLib/bin/Release.
� ���� �� �������� ��������� xml-���� ������������ SquareLib.xml, ������� �������� ��� xml-����������� �� ����.

### ����

��� ���������� ������� ����� ����������� ����� CalculateCircle. �� ��������� ������ ����� � �������� ��������� � ���������� �������.

```C#
using SquareLib;

double radius = 5;
SquareClass squareClass = new SquareClass();
double circleSquare = squareClass.CalculateCircle(radius);
Console.WriteLine($"������� ����� � �������� {radius} �����: {circleSquare}");
```

### �����������

��� ���������� ������� ������������ ����������� ����� CalculateTriangle. �� ��������� ����� ���� ������ ������������ � �������� ���������� � ���������� �������.

```C#
using SquareLib;

double a = 3;
double b = 4;
double c = 5;
SquareClass squareClass = new SquareClass();
double triangleSquare = squareClass.CalculateTriangle(a, b, c);
Console.WriteLine($"������� ������������ �� ��������� {a}, {b}, {c} �����: {triangleSquare}");
```

### �������������� ������(���� ��� �����������)

��� ���������� ������� �������������� ������ ����� ������������ ����� �alculateShape. �� ��������� ������ ���������� � �������� ���������� � ���������� �������.

```C#
using SquareLib;

double a = 3;
double b = 4;
double c = 5;

SquareClass squareClass = new SquareClass();
double triangleSquare = squareClass.�alculateShape(new double[] { a, b, c });
Console.WriteLine($"������� ������������ �� ��������� {a}, {b}, {c} �����: {triangleSquare}");

double radius = 5;
double circleSquare = squareClass.CalculateShape(new double[] { radius });
Console.WriteLine($"������� ����� � �������� {radius} �����: {circleSquare}");
```