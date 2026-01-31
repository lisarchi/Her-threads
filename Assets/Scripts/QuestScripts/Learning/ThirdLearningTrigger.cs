using UnityEngine;

public class ThirdLearningTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _previousImage;
    [SerializeField] private GameObject _learningImage;
    private SpriteRenderer _spriteRenderer;
    private Color _spriteColor;
    private float _alphaDelta;
    private float _showTime = 0.01f;

    private void Awake()
    {
        _spriteRenderer = _learningImage.GetComponent<SpriteRenderer>();
        _spriteColor = _spriteRenderer.color;
        _alphaDelta = _spriteColor.a / _showTime;
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Destroy(_previousImage);

            if (_learningImage != null)
            {
                if (_spriteColor.a < 1)
                {
                    _spriteColor.a += _alphaDelta * Time.deltaTime;
                    _spriteRenderer.color = _spriteColor;
                }

                Destroy(gameObject, 5);
            }
        }
    }
}
