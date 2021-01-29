using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]

public class TrapdoorController : MonoBehaviour
{
        private HingeJoint2D trapdoorHinge;

        private void Awake()
        {
            trapdoorHinge = GetComponent<HingeJoint2D>();
        }
        public void SetTrapdoorSpeed(float trapdoorSpeed)
        {
            JointMotor2D trapdoorMotor = trapdoorHinge.motor;
            trapdoorMotor.motorSpeed = trapdoorSpeed;
            trapdoorHinge.motor = trapdoorMotor;
        }
    }
