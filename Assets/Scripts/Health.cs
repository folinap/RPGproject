using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health Stats")]
    [SerializeField] private int _maxHealth;
    private int _currentHealth;

    public event Action<float> HealthChanged;

    void Start()
    {
        _currentHealth = _maxHealth;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            ChangeHealth(-10);
        }
    }

    public void ChangeHealth(int value)
    {
        _currentHealth += value;
        if(_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }

        if(_currentHealth <= 0)
        {
            Death();
        }
        else
        {
            float _currentHealthAsPercentage = (float)_currentHealth / _maxHealth;
            HealthChanged?.Invoke(_currentHealthAsPercentage);
        }
    }

    private void Death()
    {
        HealthChanged?.Invoke(0);
        Debug.Log("YOU ARE DEAAD!!!");
    }
}
