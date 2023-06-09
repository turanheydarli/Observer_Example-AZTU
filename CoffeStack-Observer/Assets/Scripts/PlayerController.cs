using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float verticalSpeed;
    [SerializeField] private float speed;

    private void Start()
    {
       StackHolder.Instance.coffeeList.Add(transform.GetChild(0));
    }
    
    protected virtual void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, verticalSpeed)
                              * (speed * Time.deltaTime);
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -2.5f, 2.5f), transform.position.y,
            transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            EventHolder.CoffeeDetected(other.transform);
        }
    }
}