using UnityEngine;
using System.Collections;

public class Sway : MonoBehaviour
{
    [SerializeField]
    private Quaternion m_startRot = new Quaternion(0, 0, 0, 0);
    private GameObject m_manRoot = null;

    [SerializeField] private float m_swayRate = 0;
    [SerializeField] private float m_maxLeft;
    [SerializeField] private float m_maxRight;
    [SerializeField] private bool m_swayingLeft = true;

    void Start()
    {
        if (m_manRoot == null)
            m_manRoot = gameObject;

        m_startRot = m_manRoot.transform.rotation;

        m_maxRight -= 1000;
        m_maxLeft -= 1000;
    }


    void Update()
    {

        // FUck just google this shit ruight.....

        if (m_swayingLeft)
        {
            m_manRoot.transform.Rotate(0, 0, m_swayRate * Time.deltaTime);
        }
        else
        {
            m_manRoot.transform.Rotate(0, 0, -m_swayRate * Time.deltaTime);
        }

        Debug.Log(m_manRoot.transform.rotation.eulerAngles.z);

        if (m_manRoot.transform.rotation.eulerAngles.z - 1000 > m_maxLeft)
        {
            m_swayingLeft = false;
        }
        else if (m_manRoot.transform.rotation.eulerAngles.z - 1000 < m_maxRight)
        {
            m_swayingLeft = true;
        }
    }
}
