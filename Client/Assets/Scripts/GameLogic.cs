using UnityEngine;
using UnityEngine.UI;

public enum World: ushort
{
	Lobby,
	Pier,
}

public class GameLogic: MonoBehaviour
{
	public static GameLogic instance;

	public GameObject[] worlds;
	public string[] activityTexts;
	public GameObject activityButton;
	public Text activityText;
	
	public QuizScreen quizScreen;
	public QuizFeedbackScreen quizFeedbackScreen;

	[Header("Prefabs")]
	public GameObject localPlayerPrefab;
	public GameObject otherPlayerPrefab;
	
	void Awake() {
		instance = this;
	}
	
	// todo more code
    public void SwitchWorlds(World newWorld) {
        worlds[(ushort) Player.localPlayer.world].SetActive(false);
        worlds[(ushort) newWorld].SetActive(true);
    }

    public void DoActivity() =>
        Player.localPlayer.GetComponent<PlayerActivity>().DoActivity();

    public void QuizGuess(int guess) =>
        Player.localPlayer.GetComponent<PlayerQuiz>().Guess(guess);
}
