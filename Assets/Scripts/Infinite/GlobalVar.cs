//Класс глобальных переменных, которые используются
//преимущественно в скрипте Generator для автоматической
//генерации в режиме Infinite mode
using UnityEngine;

public static class GlobalVar
{
    static int obstaclesCount = 10;
    static int level = 1;
    static float groundLength = 100f;
    static Vector3 startCoordinates;

    public static int GetFibonacci(int n)
    {
        if (n == 0) { return 0; }
        if (n == 1) { return 1; }
        int a = 0, b = 1, sum = 0, sumlag = 0, lag = 1, lag1 = 0;
        for (int i = 1; i < n; i++)
        {
            sum = a + b;
            sumlag = (a + b) / lag;
            if (i > 6)
            {
                lag1 += 10;
                lag = b / a + b / lag1;
            }
            a = b;
            b = sum;
        }
        return sumlag;
    }

    public static float GetGroundLength()
    {
        return groundLength;
    }
    public static void SetGroundLength(float _groundSize)
    {
        groundLength = _groundSize;
    }
    public static int GetLevel()
    {
        return level;
    }
    public static void SetLevel(int _level)
    {
        level = _level;
    }
    public static int GetObstaclesCount()
    {
        return obstaclesCount;
    }
    public static void SetObstaclesCount(int _obstaclesCount)
    {
        obstaclesCount = _obstaclesCount;
    }
    public static Vector3 GetStartCoordinates()
    {
        return startCoordinates;
    }
    public static void SetStartCoordinates(Vector3 _startCoordinates)
    {
        startCoordinates = _startCoordinates;
    }
}