using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform attackerPrefab;
    public Transform spawnPoint;
    public float intervalTime = 5f;
    private float countdown = 2f;
    private int waveIndex = 0;
    public int numWaves = 5;

    void Update()
    {
        if (waveIndex == numWaves)
        {
            return;
        }

        if (countdown <= 0f)
        {
            //spawnWave();
            StartCoroutine(spawnWave());
            countdown = intervalTime;
        }
        countdown -= Time.deltaTime;
    }

    IEnumerator spawnWave()
    {
        waveIndex++;

        for (int i = 0; i < waveIndex; i++)
        {
            spawnAttacker();
            yield return new WaitForSeconds(0.7f);
        }
    }

    void spawnAttacker()
    {
        Instantiate(attackerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
