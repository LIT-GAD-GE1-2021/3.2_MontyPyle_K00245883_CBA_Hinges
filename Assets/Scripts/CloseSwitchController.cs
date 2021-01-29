using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSwitchController : MonoBehaviour
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
            lvlManager.CloseTrapDoor();
            switchOnAnimator.SetBool("CloseSwitchOn", true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switchOnAnimator.SetBool("CloseSwitchOn", false);
        }
    }
}
