using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace stateMachinePlayer
{
    public class StairsState : StateMove
    {
        public StairsState(StateMachine stateMachine, Player player, float speed, float rotationSpeed, float limitSpeed) : base(stateMachine, player, speed, rotationSpeed, limitSpeed)
        {

        }

        public override void Enter()
        {
            currentPlayer.GetComponent<Rigidbody>().useGravity = false;
            Debug.Log("начинаю перемещение по лестнице");
        }

        public override void Exit()
        {
            currentPlayer.GetComponent<Rigidbody>().useGravity = true;
            Debug.Log("закончил перемещение по лестнице");
        }

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                    currentStateMachine.ChangeState(new RunState(currentStateMachine, currentPlayer, 200, 10, 2));
            }

        }

    }
}

