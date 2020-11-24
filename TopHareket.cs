using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareket : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;

    void Start ()
    {
        fizik = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate ()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        // Horizontal yatay demektir
        float dikey = Input.GetAxisRaw("Vertical");
        // Vertical diket demektir

        Vector3 vec = new Vector3(yatay,0,dikey);

        fizik.AddForce(vec * hiz);
    }
}
