using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSPawn : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform spawnRotation;
    public GameObject enemyPrefab;
    public float timeNextEnemy;
    public float spawnControl;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemys();
    }
    void spawnEnemys()
    {
        if (Time.time > timeNextEnemy)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnRotation.rotation);
            timeNextEnemy = Time.time + spawnControl;
        }
    }
}
