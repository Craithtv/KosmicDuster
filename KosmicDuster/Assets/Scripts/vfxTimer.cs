using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class vfxTimer : MonoBehaviour
{

    public float decayTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        decayTime -= Time.deltaTime;

        if (decayTime <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
