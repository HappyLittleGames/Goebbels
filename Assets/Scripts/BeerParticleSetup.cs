using UnityEngine;
using System.Collections;

public class BeerParticleSetup : MonoBehaviour
{

    [SerializeField] private GameObject m_rotator = null;
    [SerializeField] private ParticleSystem m_partSys = null;
    private float m_maxRate = 0;
    private float m_minRate = 0;

    [SerializeField] private float m_drainRate = 6.0f;


    void Start()
    {
        if (m_partSys == null)
            m_partSys = gameObject.GetComponent<ParticleSystem>();
        

        m_maxRate = GetEmissionRate(m_partSys);

    }

    void Update()
    {
        float drain = m_maxRate;
        if (drain > 0)
            SetEmissionRate(m_partSys, drain);

        if (Mathf.Abs(m_rotator.transform.localRotation.eulerAngles.z - 180) < 160)
        {
            EnableEmission(m_partSys, true);
            m_maxRate -= m_drainRate * Time.deltaTime;
        }
        else
        {
            EnableEmission(m_partSys, false);
        }
        
    }


    public static void EnableEmission(ParticleSystem particleSystem, bool enabled)
    {
        var emission = particleSystem.emission;
        emission.enabled = enabled;
    }

    public static float GetEmissionRate(ParticleSystem particleSystem)
    {
        return particleSystem.emission.rate.constantMax;
    }

    public static void SetEmissionRate(ParticleSystem particleSystem, float emissionRate)
    {
        var emission = particleSystem.emission;
        var rate = emission.rate;
        rate.constantMax = emissionRate;
        emission.rate = rate;
    }

}
