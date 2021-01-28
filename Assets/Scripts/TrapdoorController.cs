using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]

public class TrapdoorController : MonoBehaviour
{
        private HingeJoint2D trapdoorHinge;

        private void Awake()
        {
            // Initialise the hinge variable (saves me having to "wire it
            // up" via the inspector)
            trapdoorHinge = GetComponent<HingeJoint2D>();
        }


        public void SetTrapdoorSpeed(float speedToSet)
        {
            JointMotor2D trapdoorMotor = trapdoorHinge.motor;
            trapdoorMotor.motorSpeed = speedToSet;
            trapdoorHinge.motor = trapdoorMotor;
        }
    }
