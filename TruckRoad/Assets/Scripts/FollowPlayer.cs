using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    
    void Update()
    {
        transform.position = player.transform.position +  new Vector3(0,4.4f,-7.4f);
    }
}
