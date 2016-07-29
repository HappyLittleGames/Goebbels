using UnityEngine;
using System.Collections;

public class ParticleDissapation : MonoBehaviour
{
    private ParticleSystem m_partSys = null;

    private float m_emissionRate = 0.0f;

    void Start()
    {
        m_partSys = gameObject.GetComponent<ParticleSystem>();
        m_emissionRate = m_partSys.emission.rate.constantMax;
    }

	void Update ()
    {
        m_emissionRate *= 0.9f;
        
	}
}
