using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public float Health, MaxHealth, Width, Height;

    [SerializeField] private RectTransform healthBar;

    public void SetMaxHealth(float maxHealth)
    {
        MaxHealth = maxHealth;
    }

    public void SetHealth(float health)
    {
        Health = health;
        float newWidth = (Health / MaxHealth) * Width;

        healthBar.sizeDelta = new Vector2(newWidth, Height);
    }

}
