using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    void FixedUpdate()
    {
        if (UserInput.instance.MainMenuInput)
        {
            //Time.timeScale = 0.0f;
            //здесь нужно создать канвас окна паузы, чтобы не загружать снова сцену меню, надо править
            SceneManager.LoadScene("MainMenu");
        }
    }
}
