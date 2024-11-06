using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillItem : MonoBehaviour
{
    private HealthBar _healthBar;
    internal int _hillScore = 15;

    private void Start()
    {
        _healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>();
    }
    void OnTriggerEnter(Collider colHill)
    {
        if (colHill.tag.Equals("Player"))
        {
            _healthBar.HillHp();

            Destroy(gameObject);
        }
    }
}
