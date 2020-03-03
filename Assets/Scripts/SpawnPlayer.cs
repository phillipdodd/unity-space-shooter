using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour, ISpawn
{
    [Space]
    [AssetList(Path = "Prefabs/PlayerShips")]
    public GameObject[] playerShips;

    private void Start()
    {
        SpawnNext();
    }

    public void SpawnNext()
    {
        int randomInt = Random.Range(0, playerShips.Length);
        GameObject selectedShip = playerShips[randomInt];
        if (selectedShip == null)
        {
            Debug.LogWarning(("selectedShip was null! randomInt was {0}", randomInt));
            selectedShip = playerShips[0];
        }
        Instantiate(selectedShip, transform.position, Quaternion.identity);
    }
}
