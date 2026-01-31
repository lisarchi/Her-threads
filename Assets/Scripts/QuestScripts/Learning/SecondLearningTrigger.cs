using UnityEngine;

public class SecondLearningTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _previousImage;
    [SerializeField] private GameObject _learningImage;
    [SerializeField] private GameObject _thirdTrigger;

    private SpriteRenderer _learningSpriteRenderer;
    private Color _learningSpriteColor;
    private float _learningAlphaDelta;
    private float _showTime = 0.01f;

    private void Awake()
    {
        _learningSpriteRenderer = _learningImage.GetComponent<SpriteRenderer>();
        _learningSpriteColor = _learningSpriteRenderer.color;
        _learningAlphaDelta = _learningSpriteColor.a / _showTime;
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Destroy(_previousImage);
            
            if (_learningImage != null)
            {
                if (_learningSpriteColor.a < 1) 
                {
                    _learningSpriteColor.a += _learningAlphaDelta * Time.deltaTime;
                    _learningSpriteRenderer.color = _learningSpriteColor;
                }

                _thirdTrigger.transform.position = new Vector3(-7.2f, 2.07f, -0.29f);

                Destroy(gameObject, 5);
            }
        }
    }
}