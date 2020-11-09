using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public float damageRadius = 0f;
    public GameObject impactEffect;

    public void Seek(Transform target)
    {
        this.target = target;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
    }

    private void HitTarget()
    {
        GameObject effectInstance = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 2f);

        if(damageRadius > 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);
        }

        Destroy(gameObject);
    }

    private void Damage(Transform attacker)
    {
        Destroy(attacker.gameObject);
    }

    private void Explode()
    {
        Collider[] collisions = Physics.OverlapSphere(transform.position, damageRadius);
        foreach(Collider collision in collisions)
        {
            //Only damage the attackers
            if(collision.tag == "Attacker")
            {
                Damage(collision.transform);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, damageRadius);
    }
}