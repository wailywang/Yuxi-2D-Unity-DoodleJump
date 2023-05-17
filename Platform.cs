using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public PlatformType platformType;
    public float bouncespeed = 100f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal == Vector2.down)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if(rb != null )
            {
                rb.velocity = Vector2.up * bouncespeed;
            }
            // Weak Platform
            if (platformType == PlatformType.weak)
            {
                if(GetComponent<Animator>()!=null)
                {
                    GetComponent<Animator>().SetTrigger("Trigger");
                    Invoke("HideGameObject", 0.4f);
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("MainCamera"))
        {
            gameObject.SetActive(false);
        }
    }
    void HideGameObject()
    {
        gameObject.SetActive(false);
    }
}

public enum PlatformType
{
    normal,weak
}
