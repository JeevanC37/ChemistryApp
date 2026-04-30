using UnityEngine;

public class ElementNarrator : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hydrogenClip;
    public AudioClip oxygenClip;

    public void Narrate(string elementName)
    {
        switch (elementName.ToLower())
        {
            case "hydrogen":
                audioSource.clip = hydrogenClip;
                break;
            case "oxygen":
                audioSource.clip = oxygenClip;
                break;
            default:
                return;
        }
        audioSource.Play();
    }
}
