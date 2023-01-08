using UnityEngine;

namespace stateMachinePlayer
{
    public abstract class StairMove : State
    {
        protected readonly Player currentPlayer;
        protected readonly StateMachine currentStateMachine;
        private readonly float speed;
        private readonly float rotationSpeed;
        private readonly float limitSpeed;
        private static readonly int _speed = Animator.StringToHash("speed");

        protected StairMove(StateMachine stateMachine, Player player, float speed, float rotationSpeed, float limitSpeed) : base(stateMachine, player)
        {
            currentStateMachine = stateMachine;
            currentPlayer = player;
            this.speed = speed;
            this.rotationSpeed = rotationSpeed;
            this.limitSpeed = limitSpeed;
        }

        public override void Enter()
        {
        }
        public override void Exit()
        {
        }
        public override void Update()
        {
        }
        public sealed override void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            //currentPlayer.GetComponent<Rigidbody>().useGravity = false;
            Vector3 directionVector = new Vector3(h, v, 0);
            if (directionVector.magnitude > Mathf.Abs(0.1f))
                currentPlayer.transform.rotation = Quaternion.Lerp(currentPlayer.transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);

            NewAnimate();

            currentPlayer.Animator.SetFloat(_speed, Vector3.ClampMagnitude(directionVector, 1).magnitude);

            Vector3 moveDir = directionVector * speed;

            var velocity = currentPlayer.Rigidbody.velocity;
            if (velocity.x + velocity.z < limitSpeed)
            {
                currentPlayer.Rigidbody.AddForce(moveDir);
            }
        }

        protected virtual void NewAnimate()
        {
        }
    }
}