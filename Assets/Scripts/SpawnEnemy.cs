using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class SpawnEnemy : MonoBehaviour, ISpawn
{
    public GameObject spawnedGameObject;

    [SerializeField]
    private int spawnLimit = 10;
    
    [TitleGroup("Spawn Rate")]
    public float min = 2;
    [TitleGroup("Spawn Rate")]
    public float max = 3;

    private void Start()
    {
        Invoke("SpawnNext", Random.Range(min, max));
    }

    // public to be used by GameOverMenuController
    public void SpawnNext()
    {
        if (GameObject.FindGameObjectsWithTag(spawnedGameObject.tag).Length < spawnLimit)
        {
            GameObject g = Instantiate(spawnedGameObject, transform.position, Quaternion.identity);
        }

        Invoke("SpawnNext", Random.Range(min, max));
    }
}
