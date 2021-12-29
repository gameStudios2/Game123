
using UnityEngine;
using Photon.Pun;

public class SpawnManager : MonoBehaviour
{
    public GameObject player;
    public float minX, minY, maxX, maxY;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 randpos = new Vector2 (Random.Range(minX, minY), Random.Range(maxX, maxY));
        PhotonNetwork.Instantiate(player.name, randpos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
