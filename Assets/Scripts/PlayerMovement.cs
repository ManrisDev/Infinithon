using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //‘изика игрока
    public Transform player; //ѕозици€ игрока

    public float forwardForce = 200f;
    public float sidewaysForce = 100f;
    public float jumpForce = 1000f;
    public bool endGame = false;

    // We marked this as "Fixed" Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        //4 параметр - игнорирование массы при движении влево или вправо
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space) && player.position.y <= 0.905f && player.position.y > 0.89f)
        {
            rb.AddForce(0, jumpForce, 0);
        }

        if (rb.position.y > 0.5f)
        {
            endGame = false;
        }

        if (rb.position.y < 0f && !endGame)
        {
            FindObjectOfType<GameManager>().EndGame();
            endGame = true;
        }

        //Cheats
        /*if (Input.GetKeyDown(KeyCode.C))
        {
            GlobalVar.SetLevel(9);
            Debug.Log("Cheat activated");
        }*/
    }
}
