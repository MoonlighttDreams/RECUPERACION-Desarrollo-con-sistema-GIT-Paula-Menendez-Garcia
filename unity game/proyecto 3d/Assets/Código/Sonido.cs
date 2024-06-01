using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Sonido
[System.Serializable]
public class Sonido
{
    public string name;
    public AudioClip clip;

    public float volume;

    public bool loop;

    public AudioSource source;

}
