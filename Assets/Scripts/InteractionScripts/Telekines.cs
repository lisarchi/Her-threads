using UnityEngine;

public class Telekines : MonoBehaviour
{
    [SerializeField] internal PowerSystem powerSystem;
    
    [SerializeField] private float _charge = 0f;
    [SerializeField] private float _maxCharge = 3f; // секунды заряда
    [SerializeField] private float _chargeSpeed = 1f;

    [SerializeField] private float _minForce = 1f;
    [SerializeField] private float _maxForce = 7f;
    [SerializeField] private float _radius = 2f;

    [SerializeField] private float _powerPerSecond = 15f;

    private Rigidbody nearestRb;
    private Rigidbody lastHighlightedRb;
    private bool _isCharging = false;

    private void Update()
    {
        HighlightNearestTarget();

        if (UserInput.instance.InteractionInput)
        {
            if (powerSystem.SpendPower(_powerPerSecond * Time.deltaTime))
            {
                _isCharging = true;
                _charge += _chargeSpeed * Time.deltaTime;
                _charge = Mathf.Min(_charge, _maxCharge);
            }
            else
            {
                return;
            }
        }

        if (UserInput.instance.InteractionReleased)
        {
            ReleasePush();
        }
    }

    internal void ReleasePush()
    {
        if (!_isCharging) return;

        float t = _charge / _maxCharge;
        float force = Mathf.Lerp(_minForce, _maxForce, t);

        // Находим все объекты в радиусе
        //Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        //foreach (Collider col in colliders)
        //{
        //    Rigidbody rb = col.attachedRigidbody;
        //    if (rb != null && rb != GetComponent<Rigidbody>())
        //    {
        //        rb.AddExplosionForce(force, transform.position, radius, 1f, ForceMode.Impulse);
        //    }
        //}

        Rigidbody nearestRb = FindNearestRigidbody();

        if (nearestRb != null)
        {
            Vector3 direction = (nearestRb.transform.position - transform.position).normalized;
            nearestRb.AddExplosionForce(force, transform.position, _radius, 1f, ForceMode.Impulse);
        }

        // сбросф
        _charge = 0f;
        _isCharging = false;
    }

    internal void HighlightNearestTarget()
    {
        nearestRb = FindNearestRigidbody();

        // Снять подсветку с прошлого объекта
        if (lastHighlightedRb != null && lastHighlightedRb != nearestRb)
        {
            var highlighter = lastHighlightedRb.GetComponent<TelekinesisTargetHighlighter>();
            if (highlighter != null)
                highlighter.SetHighlight(false);
        }

        // Подсветить новый объект
        if (nearestRb != null)
        {
            var highlighter = nearestRb.GetComponent<TelekinesisTargetHighlighter>();
            if (highlighter != null)
                highlighter.SetHighlight(true);

            lastHighlightedRb = nearestRb;
        }
        else
        {
            lastHighlightedRb = null;
        }
    }

    internal Rigidbody FindNearestRigidbody()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _radius);
        Rigidbody nearestRb = null;
        float nearestDist = Mathf.Infinity;

        foreach (Collider col in colliders)
        {
            Rigidbody rb = col.attachedRigidbody;
            if (rb != null && rb != GetComponent<Rigidbody>())
            {
                float dist = Vector3.Distance(transform.position, rb.transform.position);
                if (dist < nearestDist)
                {
                    nearestDist = dist;
                    nearestRb = rb;
                }
            }
        }
        return nearestRb;
    }
}
