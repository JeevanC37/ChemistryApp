using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [HideInInspector]
    public List<Element> nearbyElements = new List<Element>();

    private void OnTriggerEnter(Collider other)
    {
        Element element = other.GetComponent<Element>();
        if (element != null && !nearbyElements.Contains(element))
        {
            nearbyElements.Add(element);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Element element = other.GetComponent<Element>();
        if (element != null && nearbyElements.Contains(element))
        {
            nearbyElements.Remove(element);
        }
    }

    private void OnDisable()
    {
        nearbyElements.Clear();
    }
}
