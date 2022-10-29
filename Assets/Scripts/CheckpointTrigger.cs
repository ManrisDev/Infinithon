using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public Transform Checkpoint_Object;
    public GameObject Checkpoint_Panel;
    public Transform player;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GlobalVar.SetStartCoordinates(player.position);
            Checkpoint_Panel.SetActive(true);
            Invoke("CheckpointPanelDisable", 1.4f);
        }
    }
    public void CheckpointPanelDisable()
    {
        Checkpoint_Panel.SetActive(false);
    }
}