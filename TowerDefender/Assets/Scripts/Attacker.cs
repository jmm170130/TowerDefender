using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Attacker : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;
    public float maxHealth;
    public int worth;
    private float health;
    private Transform target;
    private int wavepointIndex = 0;

    public Image Healthbar;

    void Start()
    {
        target = Wavepoints.points[0];
        speed = startSpeed;
        health = maxHealth;
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.5f)
        {
            nextPoint();
        }

        speed = startSpeed;
    }

    void nextPoint()
    {
        if (wavepointIndex >= Wavepoints.points.Length - 1)
        {
            PlayerStats.LivesLeft--;
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = Wavepoints.points[wavepointIndex];
    }

    public void Slow(float slowPercentage)
    {
        speed = startSpeed * (1f - slowPercentage);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        Healthbar.fillAmount = health / maxHealth;
        
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += worth;
        Destroy(gameObject);
    }
}
