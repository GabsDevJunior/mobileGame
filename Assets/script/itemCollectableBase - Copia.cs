using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCollectableBase : MonoBehaviour
{
    public string compareTag = "player";
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag(compareTag))
        {
            Collect();
        }
    }
    protected virtual void Collect()
    {
        Debug.Log("collect");
        gameObject.SetActive(false);
        OnCollect();
    }

    protected virtual void OnCollect()
    {

    }
}
