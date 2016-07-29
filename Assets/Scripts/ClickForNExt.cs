using UnityEngine;
using System.Collections;

public class ClickForNExt : MonoBehaviour
{

	void Update ()
    {
	    if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<SceneLoader>().LoadLevel("protoChug");
        }
        
	}
}
