using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    private Vector3 startPos;
    private int direction = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.right * direction * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, startPos) >= distance)
        {
            direction *= -1;
            Flip();
            startPos = transform.position;
        }
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1  ;
        transform.localScale = scale;
    }
}
