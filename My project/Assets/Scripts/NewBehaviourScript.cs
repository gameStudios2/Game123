using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class NewBehaviourScript : MonoBehaviourPunCallbacks
{
    public InputField cInput;
    public InputField jInput;

    public void CreateRoom()
    {
        RoomOptions rop = new RoomOptions();
        rop.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(cInput.text, rop);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(jInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
