using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sueloinfinito : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0;
    public float tileLength = 30;
    public int numberOfTiles =5;
    private List<GameObject> activeTiles = new List<GameObject>();

    public Transform playerTransform;

    // Spawn de la primera tile
    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
                SpawnTile(0);
            else
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }


    // Posición para eliminar los tiles
    void Update()
    {
    if(playerTransform.position.z -35 > zSpawn - (numberOfTiles*tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
    }
        }

    // Spawn de tiles
    public void SpawnTile(int tileIndex)
    {
        GameObject go =Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;

    }

    // Eliminar tiles
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}