using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserLife : MonoBehaviour
{

    public float laserTime = 3.0f;
    public float currentTime;
    public GameObject startVFX;
    public GameObject endVFX;
    public Transform spawnPoint;


    private List<ParticleSystem> particles = new List<ParticleSystem>();


    // Start is called before the first frame update
    void Start()
    {
        // spawnPoint.transform.position = this.gameObject.transform.position;

        //Instantiate(startVFX, spawnPoint);

        // FillLists();
         currentTime = 0f;
        // for(int i = 0; i < particles.Count; i++) 
        // {
        //     particles[i].Play();
        // }
    }

    // Update is called once per frame
    void Update()
    {
         currentTime += Time.deltaTime;
        if (currentTime > laserTime)
        { 
            for(int i = 0; i < particles.Count; i++) 
        {
            particles[i].Stop();
        }
            Destroy(this.gameObject);
        }
        // startVFX.transform.position = this.gameObject.transform.position;
    }

    // void FillLists()
    // {
    //     for(int i=0; i<startVFX.transform.childCount; i++)
    //     {
    //         var ps = startVFX.transform.GetChild(i).GetComponent<ParticleSystem>();
    //         if (ps !=null)
    //         {
    //             particles.Add(ps);
    //         }
    //     }

    //     for(int i=0; i<endVFX.transform.childCount; i++)
    //     {
    //         var ps = endVFX.transform.GetChild(i).GetComponent<ParticleSystem>();
    //         if (ps !=null)
    //         {
    //             particles.Add(ps);
    //         }
    //     }
    // }
}
