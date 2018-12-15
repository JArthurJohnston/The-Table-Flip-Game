using UnityEngine;

public class SoundEffect : MonoBehaviour {
    public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        sound.Play();
    }
}
