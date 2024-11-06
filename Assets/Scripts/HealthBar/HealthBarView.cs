using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarView : MonoBehaviour
{
    private HealthBar _healthBar;
    [SerializeField] private GameObject _maxHealth;
    [SerializeField] private GameObject _highHealth;
    [SerializeField] private GameObject _lowHealth;
    [SerializeField] private GameObject _minHealth;

    private void Start()
    {
        _healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>();
    }
    private void Update()
    {
        if (_healthBar._health >= 1 && _healthBar._health <= 40)
        {
            _minHealth.SetActive(true);
            _healthBar.AddHp();
        }
        else
        {
            _minHealth.SetActive(false);
        }

        if (_healthBar._health >= 41 && _healthBar._health <= 70)
        {
            _lowHealth.SetActive(true);
        }
        else
        {
            _lowHealth.SetActive(false);
        }

        if (_healthBar._health >= 71 && _healthBar._health <= 100)
        {
            _highHealth.SetActive(true);
        }
        else
        {
            _highHealth.SetActive(false);
        }

        if (_healthBar._health >= 101 && _healthBar._health <= 120)
        {
            _maxHealth.SetActive(true);
            _healthBar.ReduceHp();
            
        }
        else
        {
            _maxHealth.SetActive(false);
        }
    }
}
