using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSwitchController : MonoBehaviour
{
    public LevelManager lvlManager;
    public Animator switchOnAnimator;
    void Start()
    {
        
    }
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lvlManager.OpenTrapDoor();
            switchOnAnimator.SetBool("SwitchOn", true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switchOnAnimator.SetBool("SwitchOn", false);
        }
    }
}
