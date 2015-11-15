using UnityEngine;
using System.Collections;
using System.IO;
using System.Linq;

public class HighScores : MonoBehaviour {

	public string FileName;
	private TextAsset textAsset;
	private StreamWriter streamWriter;
	private string lastScore;
	private string[] tempArr;
	private int score = 50;
	private string playerName = "Sid";
	private int i;

	public void appendScore() {
		textAsset = Resources.Load (FileName + ".txt") as TextAsset;
		lastScore = File.ReadAllLines ("Resources/" + FileName + ".txt").Last ();
		tempArr = lastScore.Split ((char[])null);
		lastScore = tempArr[tempArr.Length];
		if (int.TryParse (lastScore, out i)) {
			if (score > i) {
				streamWriter = new StreamWriter ("Resources/" + FileName + ".txt");
				streamWriter.WriteLine (playerName + " " + lastScore + "\n");
				tempArr = File.ReadAllLines("Resources/" + FileName + ".txt");
			}
		}
	}
}
