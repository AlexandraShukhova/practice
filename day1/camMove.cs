using UnityEngine;

public class camMove : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        //движение камеры за объектом
        transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10f);  
    }
}
