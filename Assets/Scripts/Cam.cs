using UnityEngine;

//Настройка следования за игроком, в Main Camera
public class Cam : MonoBehaviour
{
    public Transform player; //Положение игрока
    public Vector3 offset; //Смещение

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
