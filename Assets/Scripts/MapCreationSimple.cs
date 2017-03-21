using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreationSimple : MonoBehaviour {
    public GameObject Tile;
    GameObject[,] tiles;
    Vector2[,] parentList;
    int[,] map = { 
                   { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   { 0, 0, 0, 0, 3, 0, 0, 0, 0, 0},
                   { 0, 0, 2, 2, 0, 0, 0, 2, 0, 0},
                   { 0, 0, 0, 0, 0, 0, 3, 0, 0, 0},
                   { 1, 0, 0, 0, 3, 0, 0, 0, 2, 0},
                   { 0, 0, 0, 0, 0, 0, 0, 3, 0, 0},
                   { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                   { 0, 0, 0, 0, 3, 0, 0, 2, 0, 0},
    };

    void Start(){
        parentList = new Vector2[8, 10];
        tiles = new GameObject[8, 10];
        for(int i = 0; i < 10; i++){
            for(int j = 0; j < 8; j++){
                tiles[j, i] = Instantiate(Tile, new Vector3(i, 0, j), Quaternion.identity) as GameObject;
                 if (map[j, i] == 0) { 
                     tiles[j, i].GetComponent<Renderer>().material.color = Color.white;
                 }
                 else if (map[j, i] == 2){
                     tiles[j, i].GetComponent<Renderer>().material.color = Color.white;
                 }
                 else if (map[j, i] == 3) { 
                     tiles[j, i].GetComponent<Renderer>().material.color = Color.white;
                 }
                 else { 
                     tiles[j, i].GetComponent<Renderer>().material.color = Color.white;
                 }
            }
        }
    }
}
