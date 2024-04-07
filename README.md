# Библиотека для вычисления площади круга и треугольника

Эта библиотека предоставляет функции для вычисления площади круга и треугольника на основе их параметров.

## Установка

Для установки библиотеки можно воспользоваться NuGet:

```bash
nuget install SquareLib
```

## Инструкции по использованию

Файл библиотеки SquareLib.dll находится в папке SquareLib/SquareLib/bin/Release.
В этом же каталоге находится xml-файл документации SquareLib.xml, который содержит все xml-комментарии из кода.

### Круг

Для вычисления площади круга используйте метод CalculateCircle. Он принимает радиус круга в качестве параметра и возвращает площадь.

```C#
using SquareLib;

double radius = 5;
SquareClass squareClass = new SquareClass();
double circleSquare = squareClass.CalculateCircle(radius);
Console.WriteLine($"Площадь круга с радиусом {radius} равна: {circleSquare}");
```

### Треугольник

Для вычисления площади треугольника используйте метод CalculateTriangle. Он принимает длины трех сторон треугольника в качестве параметров и возвращает площадь.

```C#
using SquareLib;

double a = 3;
double b = 4;
double c = 5;
SquareClass squareClass = new SquareClass();
double triangleSquare = squareClass.CalculateTriangle(a, b, c);
Console.WriteLine($"Площадь треугольника со сторонами {a}, {b}, {c} равна: {triangleSquare}");
```

### Неопределенная фигура(круг или треугольник)

Для вычисления площади неопределенной фигуры нужно использовать метод СalculateShape. Он принимает массив параметров в качестве параметров и возвращает площадь.

```C#
using SquareLib;

double a = 3;
double b = 4;
double c = 5;

SquareClass squareClass = new SquareClass();
double triangleSquare = squareClass.СalculateShape(new double[] { a, b, c });
Console.WriteLine($"Площадь треугольника со сторонами {a}, {b}, {c} равна: {triangleSquare}");

double radius = 5;
double circleSquare = squareClass.CalculateShape(new double[] { radius });
Console.WriteLine($"Площадь круга с радиусом {radius} равна: {circleSquare}");
```