using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterTimeLoader : MonoBehaviour
{
    [Header("Название сцены, на которую перейти")]
    public int _scene;

    [Header("Задержка перед переходом (секунды)")]
    public float delay = 3f;

    void Start()
    {
        Invoke(nameof(LoadNextScene), delay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(_scene);
    }
}