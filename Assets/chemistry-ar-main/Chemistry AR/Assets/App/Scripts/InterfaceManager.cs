using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    public void React()
    {
        foreach (KeyValuePair<string, GameObject> entry in ObjectLibrary.instance.objects)
        {
            Element element = entry.Value.GetComponent<Element>();
            element.React();
        }
    }

    public void Reset()
    {
        foreach (KeyValuePair<string, GameObject> entry in ObjectLibrary.instance.objects)
        {
            Element element = entry.Value.GetComponent<Element>();
            element.Reset();
        }
    }
}
