using UnityEngine;
using System.Collections;

public class GyroAngler : MonoBehaviour
{
    [SerializeField] private GameObject m_shoulder = null;
    private Quaternion m_startRot;
    private float m_startAngle = 0.0f;
    private float m_currentAngle = 0.0f;

    [SerializeField]
    private bool xLock = false;
    [SerializeField]
    private bool yLock = false;
    [SerializeField]
    private bool zLock = false;

    void Start()
    {
        m_startRot = m_shoulder.transform.rotation;

        //Input.gyro.enabled = true;
        //Input.gyro.updateInterval = 0.01f;
        

        if (m_shoulder == null)
            m_shoulder = gameObject;
    }

    void Update()
    {
        Quaternion referenceRotation = Quaternion.identity;
        Quaternion deviceRotation = DeviceRotation.Get();
        Quaternion eliminationOfXY = Quaternion.Inverse(Quaternion.FromToRotation(referenceRotation * Vector3.forward, deviceRotation * Vector3.forward));
        Quaternion rotationZ = eliminationOfXY * deviceRotation;
        float roll = rotationZ.eulerAngles.z;

        Quaternion targetRotation = Quaternion.Euler(0,0, roll);
        m_shoulder.transform.rotation = targetRotation;


        // rotLocks

      
    }

}
