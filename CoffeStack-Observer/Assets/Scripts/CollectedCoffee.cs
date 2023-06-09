using UnityEngine;

public class CollectedCoffee : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            EventHolder.CoffeeDetected(other.transform);
        }
    }
}