// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class TileManager : MonoBehaviour
// {
 
//  public GameObject[] tilePrefabs;
//  public float zSpawn =0;
//  public float tileLength =30;
//  public int numberOfTiles =5;
//  public Transform playerTransform;

   
//     void Start()
//     {
      
//     for(int i=0; i<numberOfTiles; i++){
//         if(i == 0)
//         SpawnTile(0);
//         else
//         SpawnTile(Random.Range(0, tilePrefabs.Length));
//     }
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(playerTransform.position.y > zSpawn- (numberOfTiles * tileLength)){
//             SpawnTile(Random.Range(0, tilePrefabs.Length));
        
//         }
//     }

//     public void SpawnTile(int tileIndex){
//         Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn,transform.rotation);
//         zSpawn += tileLength;
     
//     }
// }



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float ySpawn = 0;
    public float tileLength = 30;
    public int numberOfTiles = 5;
    public Transform playerTransform;

    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
                SpawnTile(0);
            else
                SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    void Update()
    {
        if (playerTransform.position.y > ySpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], new Vector3(0, ySpawn, 0), Quaternion.identity);
        ySpawn += tileLength;
    }
}
