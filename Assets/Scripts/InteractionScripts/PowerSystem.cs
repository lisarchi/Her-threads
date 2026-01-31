using UnityEngine;

public class PowerSystem : MonoBehaviour
{
    [SerializeField] internal float maxPower = 100f;
    [SerializeField] internal float currentPower;
    [SerializeField] internal float regenRate = 10f; // восстановление в секунду

    private void Start()
    {
        currentPower = maxPower;
    }

    private void Update()
    {
        if (currentPower < maxPower)
        {
            currentPower += regenRate * Time.deltaTime;
            currentPower = Mathf.Min(currentPower, maxPower);
        }
    }

    internal bool SpendPower(float amount)
    {
        if (currentPower >= amount)
        {
            currentPower -= amount;
            return true;
        }
        return false;
    }
}
