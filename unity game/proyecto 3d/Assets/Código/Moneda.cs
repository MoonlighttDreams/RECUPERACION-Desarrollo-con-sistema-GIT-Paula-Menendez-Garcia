using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    // Monedas 
    void Start()
    {
        
    }
    // Rotación monedas
    void Update()
    {
        transform.Rotate(70 * Time.deltaTime, 0, 0);

    }
    // Contador monedas
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        { 
            Destroy(gameObject);
            Panelgameover.numberOfCoins += 1;
        }
    }
}
