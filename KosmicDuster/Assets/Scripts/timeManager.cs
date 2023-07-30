using UnityEngine;
using System.Collections;

public class timeManager : MonoBehaviour
{
    public bool isSlow = false;
    public float slowDuration = 3f;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.T))
        {
            isSlow = true;
             StartCoroutine(ResetIsSlow());
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            isSlow = false;
        }

        if (isSlow)
        {
             StartCoroutine(ResetIsSlow());
        }
    }
    
    private System.Collections.IEnumerator ResetIsSlow()
    {
        yield return new WaitForSeconds(slowDuration);
        isSlow = false;
    }
}