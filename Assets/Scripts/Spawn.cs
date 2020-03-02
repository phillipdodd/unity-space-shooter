using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject gameObjectToSpawn;

    [SerializeField]
    private int spawnLimit = 10;
    
    [Header("Spawn Rate")]
    public float min = 2;
    public float max = 3;

    private void Start()
    {
        Invoke("SpawnNext", Random.Range(min, max));
    }

    // public to be used by GameOverMenuController
    public void SpawnNext()
    {
        if (GameObject.FindGameObjectsWithTag(gameObjectToSpawn.tag).Length < spawnLimit)
        {
            GameObject g = Instantiate(gameObjectToSpawn, transform.position, Quaternion.identity);
        }
        // Do not loop if spawning the player
        if (!gameObjectToSpawn.gameObject.name.Contains("Player"))
        {
            Invoke("SpawnNext", Random.Range(min, max));
        }
    }
}
