using UnityEngine;
using UnityEngine.UI;

//Отображение счета во время игры
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        int encription = (int)(player.position.z + 2) / 3;
        scoreText.text = encription.ToString("0");
    }
}
