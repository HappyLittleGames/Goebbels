using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderController : MonoBehaviour
{

    [SerializeField] private Slider m_slider = null;
    [SerializeField] private Flasj m_flasher = null;

    void Start ()
    {
	    
	}
	
	void Update ()
    {
	    
	}

    public void IncreaseSlider(int amount)
    {
        m_slider.value += amount;
        if (m_slider.value >= m_slider.maxValue)
        {
            Debug.Log("DONE FILLING" + gameObject.name);
            if (m_slider.value >= m_slider.maxValue)
            {
                m_flasher.SetState(true);
                UnityEngine.SceneManagement.SceneManager.LoadScene("END");
            }
        }
    }

    IEnumerator LoadLater(float later, string level)
    {
        yield return new WaitForSeconds(later);
        Debug.Log("QUITTINGGG");

        UnityEngine.SceneManagement.SceneManager.LoadScene(level);
    }
}
