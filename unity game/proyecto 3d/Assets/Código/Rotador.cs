using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
  

    // Rotador de ruedas en selección
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }
}
