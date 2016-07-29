using UnityEngine;
using System.Collections;

public class Sounder : MonoBehaviour {

    [SerializeField] private AudioClip[] m_sounds;
    [SerializeField] private AudioListener m_listener;
    [SerializeField] private AudioSource m_source;

    public void PlaySound(int sound, float volume)
    {
        m_source.PlayOneShot(m_sounds[sound], volume);
    }
}
