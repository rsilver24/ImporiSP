// Roan Silver      Created: ~September        Last Edits: December 19, 2023
// Major Collaborator: Alexander Zotov on YouTube
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour{

	private Sprite[] diceSides;
	private SpriteRenderer rend;
	public static int whosTurn = 1;
	private bool coroutineAllowed = true;
	public static int wpIndex;
	public static GameObject player1, player2;

    // Start is called before the first frame update
    private void Start()
    {
		if (SceneController.counter > 0)
        {
            Destroy(gameObject);
        }
        rend = GetComponent<SpriteRenderer>();
		diceSides = Resources.LoadAll<Sprite>("DiceSides/");
		rend.sprite = diceSides[5];
		player1 = GameObject.Find("player1");
    	player2 = GameObject.Find("player2");
    }

	private void OnMouseDown()
	{
		if (!GameControl.gameOver && coroutineAllowed)
			StartCoroutine("RollTheDice");
	}

	private IEnumerator RollTheDice()
	{
		coroutineAllowed = false;
		int randomDiceSide = 0;
		for (int i = 0; i <= 20; i++)
		{
			randomDiceSide = Random.Range(0, 6);
			rend.sprite = diceSides[randomDiceSide];
			yield return new WaitForSeconds(0.05f);
		}

		GameControl.diceSideThrown = randomDiceSide + 1;

		if (whosTurn == 1){ 
			wpIndex = player1.GetComponent<FollowThePath>().waypointIndex;
		} 
		else if (whosTurn == -1){
			wpIndex = player2.GetComponent<FollowThePath>().waypointIndex; 
		} 

		if (6 <= wpIndex && wpIndex <= 11){ 
			if (GameControl.diceSideThrown > 12 - wpIndex){ 
				GameControl.diceSideThrown = 12 - wpIndex; 
			} 
		} 

		else if (17 <= wpIndex && wpIndex <= 22){ 
			if (GameControl.diceSideThrown > 23 - wpIndex){ 
				GameControl.diceSideThrown = 23 - wpIndex; 
			} 
		} 

		else if (28 <= wpIndex && wpIndex <= 33){ 
			if (GameControl.diceSideThrown > 34 - wpIndex){ 
				GameControl.diceSideThrown = 34 - wpIndex; 
			} 
		} 

		else if (39 <= wpIndex && wpIndex <= 44){ 
			if (GameControl.diceSideThrown > 45 - wpIndex){ 
				GameControl.diceSideThrown = 45 - wpIndex; 
			} 
		} 

		if (wpIndex == 11)
		{
			//nothing yet
		}
		
		if (whosTurn == 1)
		{
			GameControl.MovePlayer(1);
		} else if (whosTurn == -1)
		{
			GameControl.MovePlayer(2);
		}
		whosTurn *= -1;
		coroutineAllowed = true;
	}
}
