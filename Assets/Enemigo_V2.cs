using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_V2 : MonoBehaviour
{
    public EnemiigoData data;
    // Start is called before the first frame update
    void Start()
    {
        if (!data.isAlive)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        data.isAlive = false;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
}
