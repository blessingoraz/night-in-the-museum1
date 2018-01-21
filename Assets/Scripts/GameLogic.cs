using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{
	public GameObject player;
	public GameObject eventSystem;
	public GameObject startUI, restartUI;
	public GameObject startPoint, playPoint, restartPoint, point1, point2, point3;
	private Vector3 startUIPosition;
	private Vector3 close = new Vector3(240, 32 ,-398);
	private bool isDoorClosed = false;
	void Start()
	{
		// Update 'player' to be the camera's parent gameobject, i.e. 'GvrEditorEmulator' instead of the camera itself.
		// Required because GVR resets camera position to 0, 0, 0.
		player = player.transform.parent.gameObject;

		// Move the 'player' to the 'startPoint' position.
		player.transform.position = startPoint.transform.position;
		startUIPosition = startUI.transform.position;

	}

	// Begin the museum showcase.
	public void StartMuseum()
	{
		isDoorClosed = true;
		// Move the player to the play position.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", playPoint.transform.position,
				"time", 4,
				"easetype", "linear"
			)
		);
	}

	void Update() {
		
		if (isDoorClosed) {
			startUI.transform.position = Vector3.Lerp (startUI.transform.position, close, Time.deltaTime * 2);
		}
	}

	// Play narrator
	public void GoToPoint1()
	{
		// Move the player to the play position.

		iTween.MoveTo(player,
			iTween.Hash(
				"position", point1.transform.position,
				"time", 1,
				"easetype", "linear"
			)
		);
	}

	// Play narrator
	public void GoToPoint2()
	{
		// Move the player to the play position.

		iTween.MoveTo(player,
			iTween.Hash(
				"position", point2.transform.position,
				"time", 1,
				"easetype", "linear"
			)
		);
	}

	// Play narrator
	public void GoToPoint3()
	{
		// Move the player to the play position.

		iTween.MoveTo(player,
			iTween.Hash(
				"position", point3.transform.position,
				"time", 1,
				"easetype", "linear"
			)
		);
	}
	// Do this when the player solves the puzzle.
	public void RestartMuseum()
	{

		// Move the player to the restart position.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", playPoint.transform.position,
				"time", 2,
				"easetype", "linear"
			)
		);
	}
}