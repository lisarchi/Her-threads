using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    void FixedUpdate()
    {
        if (UserInput.instance.MainMenuInput)
        {
            //Time.timeScale = 0.0f;
            //����� ����� ������� ������ ���� �����, ����� �� ��������� ����� ����� ����, ���� �������
            SceneManager.LoadScene("MainMenu");
        }
    }
}
