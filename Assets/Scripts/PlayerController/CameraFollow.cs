using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] private float _followSpeed = 2f;
	[SerializeField] private Transform _target;
    [SerializeField] private float _shakeDuration = 0f;
    [SerializeField] private float _shakeAmount = 0.01f;
    [SerializeField] private float _decreaseFactor = 1.0f;

    private Transform _camTransform;
	
	Vector3 originalPos;

	void Awake()
	{
		Cursor.visible = false;
		if (_camTransform == null)
		{
			_camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void OnEnable()
	{
		originalPos = _camTransform.localPosition;
	}

	private void Update()
	{
		Vector3 newPosition = _target.position;
		newPosition.z = -10;
		transform.position = Vector3.Slerp(transform.position, newPosition, _followSpeed * Time.deltaTime);

		if (_shakeDuration > 0)
		{
			_camTransform.localPosition = originalPos + Random.insideUnitSphere * _shakeAmount;

			_shakeDuration -= Time.deltaTime * _decreaseFactor;
		}
	}

	public void ShakeCamera()
	{
		originalPos = _camTransform.localPosition;
		_shakeDuration = 0.01f;
	}
}
