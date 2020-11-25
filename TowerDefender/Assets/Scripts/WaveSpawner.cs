using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public static int numAttackersAlive = 0;

    public Transform attackerPrefab;
    public Transform spawnPoint;

    public float intervalTime = 5f;
    public GameManager gameManager;
    public int numWaves = 5;

    private float countdown = 2f;
    private int waveIndex = 0;

    void Update()
    {
        if (numAttackersAlive > 0)
        {
            return; 
        }

        if (waveIndex == numWaves)
        {
            gameManager.WinLevel();
            this.enabled = false;
        }

        if (countdown <= 0f)
        {
            StartCoroutine(spawnWave());
            countdown = intervalTime;
            return;
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
        numAttackersAlive++;
    }
}
