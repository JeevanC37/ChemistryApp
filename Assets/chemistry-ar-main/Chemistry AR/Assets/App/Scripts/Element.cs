using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Element : MonoBehaviour
{
    public string symbol = "";
    [Space(5)]

    public bool isReactive = false;
    public List<GameObject> molecules = new List<GameObject>();
    [Space(5)]

    [HideInInspector] public bool reacted = false;

    [HideInInspector] public GameObject atom = null;
    [HideInInspector] public Trigger[] triggers = null;
    [HideInInspector] public Dictionary<string, GameObject> reactions = new Dictionary<string, GameObject>();

    private void Awake()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        rigidbody.isKinematic = true;

        atom = transform.GetChild(0).gameObject;
        triggers = GetComponentsInChildren<Trigger>();

        foreach (var molecule in molecules)
        {
            reactions[molecule.name] = molecule;
            molecule.SetActive(false); // Make sure molecules are hidden initially
        }
    }

    public void React()
    {

        Debug.Log($"{symbol} React called");
        if (!isReactive || reacted)
            return;

        List<Element> nearbyElements = new List<Element>();

        foreach (var trigger in triggers)
        {
            foreach (var nearby in trigger.nearbyElements)
            {
                if (nearby != null && !nearby.reacted)
                {
                    nearbyElements.Add(nearby);
                }
            }
        }

        // ===================== H2O Reaction =====================
        if (symbol == "O")
        {
            var nearbyH = nearbyElements.FindAll(e => e.symbol == "H");
            if (nearbyH.Count >= 2)
            {
                reacted = true;
                nearbyH[0].reacted = true;
                nearbyH[1].reacted = true;

                atom.SetActive(false);
                nearbyH[0].atom.SetActive(false);
                nearbyH[1].atom.SetActive(false);

                if (reactions.ContainsKey("H2O"))
                    reactions["H2O"].SetActive(true);
            }
        }

        // ===================== NO Reaction =====================
        else if (symbol == "N")
        {
            var nearbyO = nearbyElements.FindAll(e => e.symbol == "O");
            if (nearbyO.Count >= 1)
            {
                reacted = true;
                nearbyO[0].reacted = true;

                atom.SetActive(false);
                nearbyO[0].atom.SetActive(false);

                if (reactions.ContainsKey("NO"))
                    reactions["NO"].SetActive(true);
            }
        }
    }

    public void Reset()
    {
        if (!reacted) return;

        atom.SetActive(true);

        foreach (var trigger in triggers)
        {
            foreach (var nearby in trigger.nearbyElements)
            {
                if (nearby != null)
                {
                    nearby.atom.SetActive(true);
                    nearby.reacted = false;

                    foreach (var mol in nearby.molecules)
                        mol.SetActive(false);
                }
            }
        }

        foreach (var molecule in molecules)
        {
            molecule.SetActive(false);
        }

        reacted = false;
    }
}
