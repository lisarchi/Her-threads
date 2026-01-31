using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] internal int _health;
    public HillItem[] hillItem; //«адать в инспекторе пр€мую ссылку на хиллку
    private float _timeOfReduce;
    private float _timeOfAdd;
    private float _timeOfDamage;
        
    private void Start()
    {
        _health = 105;
    }

    internal void Update()
    {
        if (Time.timeScale == 0)
            return;

        if (_health > 120)
        {
            _health = 120;
        }

        if (_health < 1)
        {
            _health = 1;
        }       
    }
    internal void ReduceHp()
        {
            if (_timeOfReduce > 0)
            {
                _timeOfReduce -= Time.deltaTime;
            }
            if (_timeOfReduce <= 0)
            {
                _timeOfReduce = 1;
                _health--;

            }
        }
    internal void AddHp()
        {
            if (_timeOfAdd > 0)
            {
                _timeOfAdd -= Time.deltaTime;
            }
            if (_timeOfAdd <= 0)
            {
                _timeOfAdd = 1;
                _health++;

            }
        }
    internal void HillHp()
    {
        foreach (HillItem hill in hillItem)
        {
            _health = _health + hill._hillScore;
        }
        
    }
    internal void Damage()
    {
        if (_timeOfDamage > 0)
        {
            _timeOfDamage -= Time.deltaTime;
        }
        if (_timeOfDamage <= 0)
        {
            _timeOfDamage = 0.5f;
            _health--;
        }
    }
}