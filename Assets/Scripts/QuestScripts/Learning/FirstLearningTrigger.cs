using UnityEngine;

public class FirstLearningTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _learningImage;
    [SerializeField] private GameObject _secondTrigger;
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
    
    public void OnTriggerStay (Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if (_learningImage != null)
            {
                if (_spriteColor.a < 1)
                {
                    _spriteColor.a += _alphaDelta * Time.deltaTime;
                    _spriteRenderer.color = _spriteColor;
                }
                
                _secondTrigger.transform.position = new Vector3(-3.37f, 2.07f, -0.45f);

                Destroy(gameObject, 5);
            }
        }
    }
}
