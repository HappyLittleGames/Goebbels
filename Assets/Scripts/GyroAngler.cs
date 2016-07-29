using UnityEngine;
using System.Collections;

public class GyroAngler : MonoBehaviour
{
    [SerializeField] private GameObject m_shoulder = null;
    private Quaternion m_startRot;
    private float m_startAngle = 0.0f;
    private float m_currentAngle = 0.0f;

    void Start()
    {
        m_startRot = m_shoulder.transform.rotation;

        Input.gyro.enabled = true;
        Input.gyro.updateInterval = 0.01f;
        

        if (m_shoulder == null)
            m_shoulder = gameObject;
    }

    void Update()
    {
        Quaternion targetRotation = (Quaternion.Euler(0,0, - Input.gyro.attitude.eulerAngles.z)); //????
        m_shoulder.transform.rotation = Input.gyro.attitude;
    }

}
