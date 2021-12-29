using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class online : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("New Scene");
    }

}
