using UnityEngine;

public class UIManager : MonoBehaviour
{
    private void Awake()
    {
        EventHolder.OnCoffeeDetect += OnCoffeeDetect;
    }

    private void OnCoffeeDetect(Transform obj)
    {
        Debug.Log(obj.name);
    }
}