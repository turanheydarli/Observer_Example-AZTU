using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StackHolder : MonoBehaviour
{
    [SerializeField] private float lerpSpeed;
    [SerializeField] private Vector3 stackOffset;

    public List<Transform> coffeeList;
    public static StackHolder Instance { get; private set; }

    private Sequence sequence;

    private void Awake()
    {
        coffeeList = new List<Transform>();

        if (Instance == null)
        {
            Instance = this;
        }

        EventHolder.OnCoffeeDetect += EventHolderOnOnCoffeeDetect;
    }

    private void EventHolderOnOnCoffeeDetect(Transform obj)
    {
        obj.AddComponent<CollectedCoffee>();
        obj.tag = "Collected";
        coffeeList.Add(obj);
    }

    private void Update()
    {
        FollowStack();
    }

    private void FollowStack()
    {
        for (int i = 1; i < coffeeList.Count; i++)
        {
            Vector3 prevPos = coffeeList[i - 1].transform.position + stackOffset;
            Vector3 currentPos = coffeeList[i].transform.position;

            coffeeList[i].transform.position = Vector3.Lerp(currentPos, prevPos, lerpSpeed * Time.deltaTime);
        }
    }
}