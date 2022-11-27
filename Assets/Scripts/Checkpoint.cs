using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CheckPointManager.Instance.lastCheckPointPos = new Vector3(gameObject.transform.position.x,
                gameObject.transform.position.y + 10, gameObject.transform.position.z);
        }
    }
}
