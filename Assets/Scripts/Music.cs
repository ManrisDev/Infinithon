using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    [Header("Tags")]
    [SerializeField] private string CreatedTag;

    [Header("Music")]
    [SerializeField] private AudioClip[] soundtracks;
    public AudioSource play;

    int number_current_sound = 0;
    
    private void Update()
    {
        //Смена трека
        if (SceneManager.GetActiveScene().name != "Menu" && (!play.isPlaying || Input.GetKeyDown(KeyCode.N)))
        {
            play.clip = soundtracks[number_current_sound];
            play.Play();
            number_current_sound++;
            if (number_current_sound == soundtracks.Length)
                number_current_sound = 0;
        }
    }

    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(CreatedTag);
        if (obj != null)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.tag = CreatedTag;
            DontDestroyOnLoad(gameObject);
        }    
    }
}