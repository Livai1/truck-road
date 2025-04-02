using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Vector3 offSet = new Vector3(0,4.4f,-7.4f);

    void Update()
    {
        transform.position = player.transform.position + offSet;
    }
}
