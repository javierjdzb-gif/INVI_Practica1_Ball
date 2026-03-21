using System;
using Interfaces;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class CharacterHealthSystem : MonoBehaviour, IDamageable
{
    [Header("Health")]
    [SerializeField] private float maxHealth = 100f;
    private float currentHealth;

    [Header("UI")]
    [SerializeField] private Slider healthSlider;

    private void Awake()
    {
        if (healthSlider == null)
            healthSlider = FindObjectOfType<Slider>();
    }

    private void Start()
    {
        currentHealth = maxHealth;
        StartCoroutine(ResetHealthBar());
    }

    private IEnumerator ResetHealthBar()
    {
        yield return null; // espera un frame para que el Slider esté listo
    
        if (healthSlider != null)
        {
            healthSlider.minValue = 0;
            healthSlider.maxValue = 1;
            healthSlider.value = 1f;
        }
    
        UpdateHealthBar();
    }

    public void TakeDamage(float amount)
    {
        Debug.Log("Daño recibido: " + amount + " | Vida actual: " + currentHealth);
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();

        if (currentHealth <= 0)
            Die();
    }

    private void UpdateHealthBar()
    {
        if (healthSlider == null)
            healthSlider = FindObjectOfType<Slider>();
        
        if (healthSlider != null)
            healthSlider.value = currentHealth / maxHealth;
    }

    private void Die()
    {
        SceneManager.LoadScene("DeathScene");
        Debug.Log("El personaje ha muerto");
        // Aquí puedes poner: reiniciar escena, mostrar game over, etc.
    }
}