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

        // ���� ������ ����
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon Master Server!");

        // ����Ǹ� �κ�� ����
        PhotonNetwork.JoinLobby();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarning($"Disconnected from Photon Server. Reason: {cause}");

        // ������ ����� �ٽ� ���� �õ�
        ConnectToPhoton();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Photon Lobby!");

        // �κ� �������� ���� �߰� �۾� ����
        // ��: �� ���� �Ǵ� �뿡 ����
    }

}