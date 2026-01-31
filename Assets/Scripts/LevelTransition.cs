using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    public int _scene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(_scene);
    }
}
