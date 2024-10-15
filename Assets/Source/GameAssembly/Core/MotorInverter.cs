using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExecutionOrderClickerTask.GameAssembly
{
    [RequireComponent(typeof(HingeJoint))]
    public class MotorInverter : MonoBehaviour
    {
        [SerializeField]
        private float invertDelay = 2f;

        private HingeJoint joint;

        private void Awake()
        {
            joint = GetComponent<HingeJoint>();
        }

        private void OnEnable()
        {
            InvokeRepeating(nameof(Invert), invertDelay, invertDelay);

        }

        private void Invert()
        {
            JointMotor newMotor = joint.motor;
            newMotor.targetVelocity *= -1;
            joint.motor = newMotor;
        }
    }
}
