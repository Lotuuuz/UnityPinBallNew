using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource backGroundMusic_AS;
    [SerializeField] private AudioSource SFX_AS;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //backGroundMusic_AS.Play();
    }

    // Update is called once per frame
    public void  Play(AudioClip clip)    
    {
        SFX_AS.PlayOneShot(clip);
    }
}
