using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sonido[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Sonido s in sounds)

        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop = s.loop;
        }
        PlaySound("MainTheme");
    }

    public void PlaySound(string name)
    {
        foreach (Sonido s in sounds)

        {
            if (s.name == name)
                s.source.Play();
        }
    }
}
