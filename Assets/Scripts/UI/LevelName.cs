using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Код отображает название уровня
public class LevelName : MonoBehaviour
{
    public Text levelName;
    
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Infinite")
        {
            levelName.text = "LEVEL " + GlobalVar.GetLevel();
        }
        else
        {
            levelName.text = "LEVEL " + SceneManager.GetActiveScene().buildIndex;
        }
    }
}
