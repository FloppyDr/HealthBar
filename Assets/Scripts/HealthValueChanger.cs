using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class HealthValueChanger : MonoBehaviour
{
   [SerializeField] private Slider _healthBar;

    public void ChangeHp(float hp)
    {
        _healthBar.DOValue(_healthBar.value + hp, 0.5f, true);
    }
}
