using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBall : ProjectileBehavior
{
    // Start is called before the first frame update

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Monster>())
        {
            Debug.Log("Hit the monster");
           
        }
        else if (other.GetComponent<Wall>())
        {
            Debug.Log("Hit wall");
            Destroy(gameObject);
        }
    }
}
