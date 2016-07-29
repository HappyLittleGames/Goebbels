using UnityEngine;
using System.Collections;

public class SoundFiner : MonoBehaviour
{

    public void PlayMe(int sound)
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<Sounder>().PlaySound(sound, 1);
    }
	
}
