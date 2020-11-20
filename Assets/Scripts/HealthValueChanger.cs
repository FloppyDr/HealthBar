using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class HealthValueChanger : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] Player _player;

    private void OnEnable()
    {
        _player.HealthChanged += ChangeHp;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= ChangeHp;
    }

    private void ChangeHp()
    {
        _healthBar.DOValue(_player.Health, 0.5f, true);
    }
}
