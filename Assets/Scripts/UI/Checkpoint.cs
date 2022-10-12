using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    public Text checkpoint;

    // Start is called before the first frame update
    void Start()
    {
        checkpoint.text = "Checkpoint!";
    }
}
