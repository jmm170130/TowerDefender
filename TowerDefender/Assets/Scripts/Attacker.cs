﻿using UnityEngine;
using UnityEngine.UI;

public class Attacker : MonoBehaviour
{
    public float speed = 10f;
    public float maxHealth;
    private float health;
    private bool dead;
    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = Wavepoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.5f)
        {
            nextPoint();
        }
    }

    void nextPoint()
    {
        if (wavepointIndex >= Wavepoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = Wavepoints.points[wavepointIndex];
    }
}