// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class CameraControl : MonoBehaviour
// {
// public Transform target;

// public Transform bg1;

// public Transform bg2;

// private float size;

//     void Start()
//     {
//         // size = bg1.GetComponent<BoxCollider2D>().size.y;
//         size = 1.5f;
//     }

//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
//         transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);
 
//     //background
//         if(transform.position.y >= bg2.position.y){

//              bg1.position = new Vector3(bg1.position.x, bg2.position.y * size, bg1.position.z );
//             SwitchBG();
//             // Debug.Log(size);
//      }
//     }

//     private void SwitchBG(){
//         Transform temp = bg1;
//         bg1 = bg2;
//         bg2=temp;
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;


    void Start()
    {
    
    }

    void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);

 
    }


}

