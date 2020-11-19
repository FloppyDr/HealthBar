using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _curretHealth;
    private float _maxHealth = 100f;
    private float _minHealth = 0f;

    public float Health => _curretHealth;

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
    }

    public void GetHeal(float heal)
    {
        _curretHealth += heal;

        if (_curretHealth >= _maxHealth)
        {
            _curretHealth = _maxHealth;
        }
    }
}
