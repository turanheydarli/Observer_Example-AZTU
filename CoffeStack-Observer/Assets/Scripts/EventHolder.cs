using System;
using UnityEngine;

public static class EventHolder
{
    public static event Action<Transform> OnCoffeeDetect;

    public static void CoffeeDetected(Transform coffee)
    {
        OnCoffeeDetect?.Invoke(coffee);
    }
}