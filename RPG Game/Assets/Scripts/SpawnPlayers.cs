using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class SpawnPlayers : MonoBehaviour, IPunObservable
{

     int minRangeNumber = 0;
     int maxRangeNumber = 2;


    string[] character = new string[] { "Paladin", "X Bot", "Y Bot",};


    //public GameObject playerPrefab;
    public GameObject[] characters;
    public Transform[] spawnPoints;
    //public GameObject spawnPoint;

    private void Start()
    {
        int randomNumber = Random.Range(minRangeNumber, maxRangeNumber);

        PhotonNetwork.Instantiate(Path.Combine("CharactersPrefab", character[randomNumber]), transform.position, transform.rotation);

        //PhotonNetwork.Instantiate(playerPrefab.name,spawnPoints[randomNumber].transform.position , Quaternion.identity, 0);

    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        throw new System.NotImplementedException();
    }
}
