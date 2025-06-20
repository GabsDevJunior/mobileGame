using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Lerp Settings")]
    public Transform target;
    public float lerpSpeed;

    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos =  target.position;
        pos.y = transform.position.y; 
        pos.x = transform.position.x;

        transform.Translate(transform.forward * speed * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, pos, lerpSpeed
        * Time.deltaTime * 2f);
    }
}
