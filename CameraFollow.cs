using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject bird;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - bird.transform.position;
    }

    void Update()
    {
        if (Bird.ENDGAME) return;

        transform.position = new Vector3(
            bird.transform.position.x + offset.x,
            transform.position.y,
            transform.position.z);       
    }
}
