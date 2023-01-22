using GroundCheck;
using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Animator), typeof(CapsuleCollider))]
public class Player : MonoBehaviour
{
    [SerializeField] private GroundChecker _groundChecker;
    public static bool onStairs;
    public bool OnGround => _groundChecker.IsGrounded;

    public Rigidbody Rigidbody { get; private set; }
    public Animator Animator { get; private set; }
    public Health Health { get; private set; }

    public void Awake()
    {
        Health = new Health();

        Rigidbody = GetComponent<Rigidbody>();
        Animator = GetComponent<Animator>();
        GetComponent<CapsuleCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Stair>())
        {
            print("столкнулся с лестницей");
            onStairs = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Stair>())
        {
            print("отошел от лестницы");
            onStairs = false;
        }
    }

}