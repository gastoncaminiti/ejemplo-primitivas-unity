using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float cooldown = 3f;
    
    //Components Reference
    private MeshRenderer rendererReference;
    private Rigidbody   rigidbodyReference; 


    void Start()
    {
        rendererReference  = GetComponent<MeshRenderer>();
        rigidbodyReference = GetComponent<Rigidbody>();
        rendererReference.enabled = false;
        rigidbodyReference.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > cooldown)
        {
            //UN COMENTARIO
            rendererReference.enabled = true;
            rigidbodyReference.useGravity = true;
        }
    }
}
