using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sphere : MonoBehaviour
{
    static int Srhere = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Grass"){
         Destroy(gameObject);
        }
    }

    void OnMouseDown() {
        Srhere = Srhere - 1;
        Destroy(gameObject);

        if(Srhere == 0){
            print("Ты победил!");
        }
    }
}
