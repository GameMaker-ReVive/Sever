using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class ServerManager : MonoBehaviourPunCallbacks
{
    void Start()
    {
        ConnectToPhoton();
    }

    void ConnectToPhoton()
    {
        Debug.Log("Connecting to Photon Server...");

        // 포톤 서버에 연결
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon Master Server!");

        // 연결되면 로비로 입장
        PhotonNetwork.JoinLobby();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarning($"Disconnected from Photon Server. Reason: {cause}");

        // 연결이 끊기면 다시 연결 시도
        ConnectToPhoton();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Photon Lobby!");

        // 로비에 입장했을 때의 추가 작업 수행
        // 예: 룸 생성 또는 룸에 입장
    }

}