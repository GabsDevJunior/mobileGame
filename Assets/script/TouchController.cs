using UnityEngine;

public class TouchController : MonoBehaviour
{
    public Vector2 pastPosition;
    
    public float Velocity = 3f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //mousePosition AGORA = mousePosition passado;
            Move(Input.mousePosition.x - pastPosition.x);
        }

        pastPosition = Input.mousePosition;

    }
            public void Move(float speed)
        {
            transform.position += Vector3.right * Time.deltaTime * speed * Velocity;   
        }
}
