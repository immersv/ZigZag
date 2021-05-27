using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tiles;

    public GameObject currentTile;

    private static TileManager instance;

    public static TileManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileManager>();
            }
            return instance;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void SpawnTile()
    {
        int index = Random.Range(0, 2);
        currentTile=Instantiate(tiles[index], currentTile.transform.GetChild(index).position, Quaternion.identity);
    }
}
