using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private void Awake()
    {
        EventHolder.OnCoffeeDetect += OnCoffeeDetect;
    }

    private void OnCoffeeDetect(Transform obj)
    {
        Debug.Log("Ses cixar");
    }
}