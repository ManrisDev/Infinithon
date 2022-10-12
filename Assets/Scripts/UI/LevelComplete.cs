using UnityEngine;
using UnityEngine.SceneManagement;

// од находитс€ в LevelComplete и отображает панель после прохождени€ уровн€
public class LevelComplete : MonoBehaviour
{
    //—рабатывает за счет ивента анимации LevelComplete
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
