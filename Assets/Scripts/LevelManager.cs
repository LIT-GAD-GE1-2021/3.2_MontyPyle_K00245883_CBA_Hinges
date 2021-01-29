using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public GameObject trapdoor;
    public TrapdoorController trapdoorScript;
    public float trapdoorSpeed;

    private void Awake()
    {
        instance = this;
        trapdoorSpeed = 0;
    }
    public void OpenTrapDoor()
    {
        trapdoorSpeed = 400;
        trapdoorScript.SetTrapdoorSpeed(trapdoorSpeed);
    }
    public void CloseTrapDoor()
    {
        trapdoorSpeed = 400;
        trapdoorScript.SetTrapdoorSpeed(trapdoorSpeed * -1);
    }
}
