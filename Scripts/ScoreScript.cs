using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public Text score;

    public static int ScoreCount;

    // Start is called before the first frame update
    void Start()
    {
        ScoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + ScoreCount;
    }
}