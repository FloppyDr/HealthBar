using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private UnityEvent _healthChanged = new UnityEvent();
    private float _curretHealth;
    private float _maxHealth = 100f;
    private float _minHealth = 0f;

    public float Health => _curretHealth;

    public event UnityAction HealthChanged
    {
        add => _healthChanged.AddListener(value);
        remove => _healthChanged.AddListener(value);
    }

    private void Start()
    {
        _curretHealth = _maxHealth;
    }

    public void GetDamage(float damage)
    {
        if (damage >= _curretHealth)
        {
            _curretHealth = _minHealth;
        }
        else
        {
            _curretHealth -= damage;
        }

        _healthChanged.Invoke();
    }

    public void GetHeal(float heal)
    {
        _curretHealth += heal;

        if (_curretHealth >= _maxHealth)
        {
            _curretHealth = _maxHealth;
        }

        _healthChanged.Invoke();
    }
}
