using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class Stair : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.GetComponent<Player>())
    //    {
    //        collision.gameObject.GetComponent<PlayerMovement>().CheckingStair();
    //        print("вошел");
    //    }
    //}
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.GetComponent<Player>())
    //    {
    //        collision.gameObject.GetComponent<PlayerMovement>().CheckingStair();
    //        print("вышел");
    //    }
    //}

//    private void OnTriggerStay(Collider other)
//    {
//        if (Input.GetKeyDown(KeyCode.E))
//        {
//            if (other.gameObject.GetComponent<Player>())
//            {
//                other.gameObject.GetComponent<PlayerMovement>().CheckingStair();
//                other.gameObject.GetComponent<Rigidbody>().useGravity = false;
//                print("вошел");
//            }
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        if (other.gameObject.GetComponent<Player>())
//        {
//            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
//            other.gameObject.GetComponent<PlayerMovement>().CheckingStair();
//            print("вышел");
//        }
//    }
}


