using UnityEngine;

public class Music : MonoBehaviour
{
    private void Start()
    {
        GetComponent<AudioSource>().volume = Nastroika.Zvuk;
    }
}
