using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSide : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        Transform t = collision.gameObject.transform;
        t.position = new Vector3((-t.position.x) / 0.95f, t.position.y, 0f);
    }

}
