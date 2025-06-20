using UnityEngine;

public class LerpHelper : MonoBehaviour
{
<<<<<<< Updated upstream
    public float lerpSpeed;
    public Transform target;
=======

    public Transform target;

    public float lerpSpeed;
>>>>>>> Stashed changes
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, lerpSpeed
<<<<<<< Updated upstream
        * Time.deltaTime * 2f);
=======
        * Time.deltaTime);
>>>>>>> Stashed changes
    }
}
