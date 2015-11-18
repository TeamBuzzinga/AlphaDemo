using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapPlayerPosition : MonoBehaviour {

	public Image mapImage;
	public GameObject floor;
	public GameObject player; 

	public Image positionIndicator;

	private RectTransform rectTransform;
	private Vector2 mapRange;
	private Vector2 floorRange;
	private Vector2 floorPos;
	private Vector2 playerPos;

	// Use this for initialization
	void Start () {
		rectTransform = GetComponent<RectTransform> ();
		//positionIndicator = GetComponentInChildren<Image>();
		mapRange = new Vector2(rectTransform.rect.width, rectTransform.rect.height);
		floorRange = new Vector2 (floor.transform.localScale.x, floor.transform.localScale.z);
		floorPos = new Vector2 (floor.transform.position.x, floor.transform.position.z);
		//playerPos = new Vector2 (player.transform.position.x, player.transform.position.z);

		//Debug.Log ("mapRange = " + new Vector2(mapRangeX, mapRangeY).ToString());
		//Debug.Log ("floorRange = " + new Vector2(floorRangeX, floorRangeZ).ToString());
	}
	
	// Update is called once per frame
	void Update () {
		playerPos = new Vector2 (player.transform.position.x, player.transform.position.z);
//		relativePositionX = player.transform.position.x -  floor.transform.position.x;
//		relativePositionZ = player.transform.position.z -  floor.transform.position.z;
//		Debug.Log("relativePosition = " + new Vector2(relativePositionX, relativePositionZ));
//		Debug.Log (new Vector2 ((-0.5f * mapRangeX) + relativePositionX * (mapRangeX / floorRangeX), (-0.5f * mapRangeY) + relativePositionZ * (mapRangeY / floorRangeZ)).ToString ());
		//positionIndicator.rectTransform.anchoredPosition = new Vector2 ((-0.5f * mapRangeX) + relativePositionX * (mapRangeX / floorRangeX), (-0.5f * mapRangeY) + relativePositionZ * (mapRangeY / floorRangeZ));
		//positionIndicator.rectTransform.anchoredPosition = new Vector2 ((-mapRangeX) + relativePositionX * (mapRangeX / floorRangeX), (-mapRangeY) + relativePositionZ * (mapRangeY / floorRangeZ));
		//positionIndicator.rectTransform.anchoredPosition = new Vector2 ((playerPosX / (floorPosX - 0.5f * floorRangeX)) * (- mapRangeX/2f), (playerPosZ / (floorPosZ - 0.5f * floorRangeZ)) * (- mapRangeY/2f));
		positionIndicator.rectTransform.anchoredPosition = new Vector2 (-mapRange.x / 2f + ((playerPos.x - (floorPos.x - floorRange.x / 2f)) / floorRange.x) * mapRange.x, -mapRange.y / 2f + ((playerPos.y - (floorPos.y - floorRange.y / 2f)) / floorRange.y) * mapRange.y);
	}
}
