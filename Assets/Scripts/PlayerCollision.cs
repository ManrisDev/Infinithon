using UnityEngine;

//Находится в Player
public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
