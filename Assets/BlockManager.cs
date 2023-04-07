using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{

    public GameObject redBlock;
    public float space;

    private BoxCollider dimensions;

    /*
        Function that auto runs before start of game.
            It's going to create all of the block programatically

        REquired:
            Reference to the block Prefab
            Create blocks repeatedly
            dimensions of the space where we make the blocks
    */

    // runs before start
    void Awake() {

        // GetComponent is a way to fill out references of components already on the same gameobject
        dimensions = GetComponent<BoxCollider>();

        // Create a new block

        // Instantiate(redBlock, Vector3.zero, Quaternion.identity);
        // For loop allows us to execute code repeatedly
        // first part is declaring the iterator
        // second part is condition
        // third part will modify the iterator
        // i++ === i += 1 === i = i + 1
        for (int i = 0; i < 5; i++) {
            Debug.Log("For Loop, i is: " + i);
        }
        // Make a row of blocks
        for (float x = dimensions.center.x - dimensions.size.x / 2f; x < dimensions.center.x + dimensions.size.x / 2f; x += space) {
            Instantiate(redBlock, new Vector3(x, 0, 0), Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
