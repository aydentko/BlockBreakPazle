using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour {
    public BlockData[] blocks_arg;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OrderBlocks()
    {

    }
}

public enum BlocksColor
{
    RED, BLUE, GREEN, YELLOW
}

public enum BlocksState
{
    IDLE, CHANGE, NONE
}

public class BlockData
{
    BlocksColor color;
    BlocksState state;
    Vector2Int position;


}


