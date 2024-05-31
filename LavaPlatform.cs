using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.GameOver();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("On Trigger Enter");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("On Trigger Exit");
    }
    
}
