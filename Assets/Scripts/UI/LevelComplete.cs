using UnityEngine;
using UnityEngine.SceneManagement;

//��� ��������� � LevelComplete � ���������� ������ ����� ����������� ������
public class LevelComplete : MonoBehaviour
{
    //����������� �� ���� ������ �������� LevelComplete
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
