using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip[] sounds;
    public AudioSource audioSrc => GetComponent<AudioSource>();
    public void PlaySound(AudioClip clip, float volume = 1f, bool destroyed = false)
    {
        if(destroyed) AudioSource.PlayClipAtPoint(clip,transform.position);
        else audioSrc.PlayOneShot(clip, volume); 
    }
    public void StopSound()
    {
        audioSrc.Stop();
    }
}
