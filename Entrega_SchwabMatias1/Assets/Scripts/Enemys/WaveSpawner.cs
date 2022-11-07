using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWaves = 5f;
    private float countdown;
    public Transform startWavePos;
    public Transform startWaveRot;
    
        
    private void Update()
    {
        if(countdown <=0f)
        {
            spawnWave();
            countdown = timeBetweenWaves;
            Instantiate(enemyPrefab, startWavePos.position, startWaveRot.rotation);
        }
        countdown -= Time.deltaTime;
        

        void spawnWave()
        {
            Debug.Log("Wave Incoming!");
        }
        
    }

}
