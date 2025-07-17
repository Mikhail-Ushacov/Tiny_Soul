using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Получен урон: " + damage + " | Осталось HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        Debug.Log("Лечение: " + healAmount + " | HP теперь: " + currentHealth);
    }

    void Die()
    {
        Debug.Log("Игрок умер!");
        // TODO: переход в ад
    }
}
