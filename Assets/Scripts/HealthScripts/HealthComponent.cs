using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthComponent : MonoBehaviour, IDamageable
{
    [SerializeField]
    private float currentHealth;
    public float CurrentHealth => currentHealth;

    [SerializeField]
    private float maxHealth;
    public float MaxHealth => maxHealth;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public virtual void Destroy()
    {
        Destroy(gameObject);
        if (gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy();
        }
        
    }

}
