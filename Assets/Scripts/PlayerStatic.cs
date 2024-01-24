using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatic : MonoBehaviour
{
    public float Health, MaxHealth;

    [SerializeField]
    private HealthBar healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(MaxHealth);
    }

    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void setHealth(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        healthBar.SetHealth(Health);
    }
}
