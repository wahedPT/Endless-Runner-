using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameControllerScript : MonoBehaviour
{
    public PlayerMovement player;
    public Camera camfollower;
    Vector3 camofset;
    public float camofsetz;
    public GameObject[] blocks;
    public float blockArrowPointer = -5;
    public float safemargin = 20;
    public GameObject[] obst;
    public float score = 0.0f;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //print("Welcome to Endless Game \n press Space to jump or escape from Obstacles");
        camofset = new Vector3(0, 0, camofsetz);//offset reference;
         
    }
    //xchallenge to change the fixedoffset to block size offset
    // Update is called once per frame
    void Update()
    {

        while (player != null && blockArrowPointer < player.transform.position.x + safemargin)
        {
            int value = Random.Range(0, blocks.Length);
            //if (blockArrowPointrt<10){ for some gap from starting
            // value=o;}
            GameObject blocksPrefab = Instantiate(blocks[value]);//tested same block sizes with fixed offset
            Blocksize bs = blocksPrefab.GetComponent<Blocksize>();
            blocksPrefab.transform.position = new Vector3(blockArrowPointer + bs.blocksize / 2, 0, 0);
            blockArrowPointer += bs.blocksize;
            int value1 = Random.Range(0, obst.Length);
            int difference = Random.Range(2, 10);
            GameObject obstprefab = Instantiate(obst[value1]);
            obstprefab.transform.position = new Vector3(blockArrowPointer + bs.blocksize+ difference, 1, 0);
        }
        if (player!=null)
        {
            score += Time.deltaTime;
            print("score is " + Mathf.RoundToInt(score));
            //scoreText.Text = Mathf.RoundToInt(score).ToString();
            //camfollower.transform.position = player.transform.position + camofset;
            camfollower.transform.position = new Vector3(player.transform.position.x, camfollower.transform.position.y, camfollower.transform.position.z);
        }
        

    }
    
}
