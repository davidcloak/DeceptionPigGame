using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineRole : MonoBehaviour
{
    public Mesh Pigs;
    public Mesh Wolves;
    public float playersJoined = 6f;
    GameObject[] players;

    void Start()
    {
        players = new GameObject[(int) playersJoined];
        
        //gets the children of players
        WithForLoop();

        //Shuffles the array of players
        ShuffleArray();

        RolesDetermined();
    }

    void WithForLoop()
    {
        for (int i = 0; i < playersJoined; ++i)
        {
            players[i] = transform.GetChild(i).gameObject;
        }
    }

    void ShuffleArray()
    {
        for (int i = players.Length - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);

            GameObject temp = players[i];
            players[i] = players[randomIndex];
            players[randomIndex] = temp;
        }
    }

    void RolesDetermined()
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (i == 0 || i == 5)
            {
                print(players[i] + " you are wolf");
                players[i].GetComponent<MeshFilter>().mesh = Wolves;
                players[i].GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
            }
            else
            {
                print(players[i]+" you are pig");
                players[i].GetComponent<MeshFilter>().mesh = Pigs;
                players[i].GetComponent<MeshRenderer>().material.SetColor("_Color", Color.blue);
            }
        }
    }
}
