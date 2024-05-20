// Roan Silver      Created: ~September        Last Edits: December 19, 2023
// Major Collaborator: Alexander Zotov on YouTube
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private static GameObject WhoWinsText, Player1MoveText, Player2MoveText, Player1WinsText, Player2WinsText, Player1Power, Player2Power;

	//Added public instead of private
    public static GameObject player1, player2, DiceCard;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;

    public static bool done = false;

	public Camera MainCamera;
    public Camera BossCam1;

	public static int p1Power = 1;
	public static int p2Power = 1;
	public static int advance;
    
    // Start is called before the first frame update
    void Start()
    {
		Player1WinsText = GameObject.Find("Player1WinsText");
		Player2WinsText = GameObject.Find("Player2WinsText");
        WhoWinsText = GameObject.Find("WhoWinsText");
        Player1MoveText = GameObject.Find("Player1MoveText");
        Player2MoveText = GameObject.Find("Player2MoveText");
		Player1Power = GameObject.Find("Player1Power");
		Player2Power = GameObject.Find("Player2Power");

        player1 = GameObject.Find("player1");
        player2 = GameObject.Find("player2");
		DiceCard = GameObject.Find("DiceCard");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

		Player1WinsText.gameObject.SetActive(false);
		Player2WinsText.gameObject.SetActive(false);
        WhoWinsText.gameObject.SetActive(false);
        Player1MoveText.gameObject.SetActive(true);
        Player2MoveText.gameObject.SetActive(false);

		Player1Power.gameObject.SetActive(true);
		Player2Power.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex > player1StartWaypoint + diceSideThrown)
			{
				player1.GetComponent<FollowThePath>().moveAllowed = false;
				Player1MoveText.gameObject.SetActive(false);
				Player2MoveText.gameObject.SetActive(true);

				// Boss Spaces

				if (player1.GetComponent<FollowThePath>().waypointIndex == 12){
					Cameras.state = 1;
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 23){
					Cameras.state = 1;
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 34){
					Cameras.state = 1;
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 45){
					Cameras.state = 1;
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 56){
					Cameras.state = 1;
				}

				// Roll Again Spaces

				if (player1.GetComponent<FollowThePath>().waypointIndex == 2){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 6){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 11){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 13){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 17){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 19){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 27){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 36){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 37){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 47){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 51){
					Dice.whosTurn = 1;
					Player1MoveText.gameObject.SetActive(true);
					Player2MoveText.gameObject.SetActive(false);
				}

				// Power Spaces

/**
				if (player1.GetComponent<FollowThePath>().waypointIndex == 3){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 4){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 10){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 14){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 15){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 20){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 21){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 22){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 26){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 29){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 32){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 33){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 35){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 38){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 44){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 49){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 50){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 54){
					Player1Power.GetComponent<TextEditor>().Change();
				}

				if (player1.GetComponent<FollowThePath>().waypointIndex == 55){
					Player1Power.GetComponent<TextEditor>().Change();
				}
**/
				player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
			}

		if ((player2.GetComponent<FollowThePath>().waypointIndex) > (player2StartWaypoint + diceSideThrown))
		{
			player2.GetComponent<FollowThePath>().moveAllowed = false;
			Player2MoveText.gameObject.SetActive(false);
			Player1MoveText.gameObject.SetActive(true);
			
			// Boss Spaces

			if (player2.GetComponent<FollowThePath>().waypointIndex == 12){
				Cameras.state = 1;
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 23){
				Cameras.state = 1;
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 34){
				Cameras.state = 1;
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 45){
				Cameras.state = 1;
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 56){
				Cameras.state = 1;
			}

			// Roll Again Spaces

			if (player2.GetComponent<FollowThePath>().waypointIndex == 2){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 6){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 11){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 13){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 17){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 19){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 27){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 36){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 37){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 47){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 51){
				Dice.whosTurn = -1;
				Player2MoveText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
			}

			// Power Spaces

/**
			if (player2.GetComponent<FollowThePath>().waypointIndex == 3){
				//Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 4){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 10){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 14){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 15){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 20){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 21){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 22){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 26){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 29){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 32){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 33){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 35){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 38){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 44){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 49){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 50){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 54){
				Player2Power.GetComponent<TextEditor>().Change();
			}

			if (player2.GetComponent<FollowThePath>().waypointIndex == 55){
				Player2Power.GetComponent<TextEditor>().Change();
			}
**/
			player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
		}

		if (player1.GetComponent<FollowThePath>().waypointIndex == player1.GetComponent<FollowThePath>().waypoints.Length)
			{
				WhoWinsText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
				Player2MoveText.gameObject.SetActive(false);
				Player1WinsText.gameObject.SetActive(true); 
				WhoWinsText.GetComponent<Text>().text = "Player 1 Wins";
				gameOver = true;
			}
		if (player2.GetComponent<FollowThePath>().waypointIndex == player2.GetComponent<FollowThePath>().waypoints.Length)
			{
				WhoWinsText.gameObject.SetActive(true);
				Player1MoveText.gameObject.SetActive(false);
				Player2MoveText.gameObject.SetActive(false);
				Player2WinsText.gameObject.SetActive(true);
				WhoWinsText.GetComponent<Text>().text = "Player 2 Wins";
				gameOver = true;
			}
    }

	public static void MovePlayer(int playerToMove)
	{
		switch(playerToMove) {
			case 1:
				player1.GetComponent<FollowThePath>().moveAllowed = true;
				break;


			case 2:
				player2.GetComponent<FollowThePath>().moveAllowed = true;
				break;
		}
	}
}
