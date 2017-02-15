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

        m_maxRight = m_startRot.eulerAngles.x - m_maxRight;
        m_maxLeft = m_startRot.eulerAngles.x - m_maxLeft;
    }


    void Update()
    {

        // FUck just google this shit ruight.....

        if (m_swayingLeft)
        {
            m_manRoot.transform.Rotate(m_swayRate * Time.deltaTime,0,0);
        }
        //else
        //{
        //    m_manRoot.transform.Rotate(-m_swayRate * Time.deltaTime,0,0);
        //}

        Debug.Log(m_manRoot.transform.rotation.eulerAngles.x);

        if (m_manRoot.transform.rotation.eulerAngles.x > m_maxLeft)
        {
            //m_swayingLeft = false;
            m_swayRate = -m_swayRate;
        }
        //if (m_manRoot.transform.rotation.eulerAngles.x < m_maxRight)
        //{
        //    //m_swayingLeft = true;
        //}
    }
}
