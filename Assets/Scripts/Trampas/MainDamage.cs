using System;
using Interfaces;
using UnityEngine;

public class MainDamage : MonoBehaviour
{
    [SerializeField] private float damageAmount = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IDamageable damageable))
        {
            damageable.TakeDamage(damageAmount);
        }
    }

    // Si la trampa es un trigger en lugar de colisión física:
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamageable damageable))
        {
            damageable.TakeDamage(damageAmount);
        }
    }
}