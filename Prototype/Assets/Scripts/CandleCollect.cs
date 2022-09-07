using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleCollect : MonoBehaviour
{
    public GameObject Enemy;
    public AudioSource ObiWan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy.transform.position = new Vector3(4.99f, 0, 3.605f);
        ObiWan.Play();

    }
}
