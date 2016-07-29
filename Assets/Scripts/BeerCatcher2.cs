using UnityEngine;
using System.Collections;

public class BeerCatcher2 : MonoBehaviour
{

    [SerializeField] private TextPrompter m_prompter = null;
    [SerializeField] private JawBounce m_bouncer = null;
    private SliderController m_slider = null;

    private int m_percentage = 0;

    void Start()
    {
        if (m_bouncer == null)
            m_bouncer = gameObject.GetComponentInParent<JawBounce>();

        if (m_prompter == null)
            m_prompter = gameObject.GetComponentInParent<TextPrompter>();

        m_slider = GameObject.FindGameObjectWithTag("GameController").GetComponent<SliderController>();

    }

    void OnParticleCollision(GameObject other)
    {
        if ((other.tag == "beer") && (gameObject.tag == "throat"))
        {
            Debug.Log("chugged, open mouth man");
            m_bouncer.SetOpening(true);

            m_slider.IncreaseSlider(1);
        }
        else
            Debug.Log("hit nothing important");

        
    }
}
