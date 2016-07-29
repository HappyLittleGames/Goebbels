using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Seconds : MonoBehaviour
{
    [SerializeField] private Text m_text;
    float m_float = 5;
	void Start ()
    {
        m_text.text = Time.realtimeSinceStartup.ToString("F2");
        StartCoroutine(Quit(10.0f));
    }

    IEnumerator Quit(float time)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("EXIOTING");
        Application.Quit();
    }
}
