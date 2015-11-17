using UnityEngine;
using System.Collections;

public class CreateScrollingText : MonoBehaviour {
    public Transform creditTextObject;
    public string scrollText = "Development Team\nRyan Andersen\nSiddharth Shah\nDingfeng Shao\nWei Yang Quek\nMoon Chang";

	// Use this for initialization
	void Start () {
        string[] splitText = scrollText.Split('\n');
        int i = 0;
        foreach (string txtLine in splitText)
        {
            GameObject obj = (GameObject)Instantiate(creditTextObject.gameObject, Vector3.zero , Quaternion.Euler(0, 15, 0));
            obj.GetComponent<TextMesh>().text = txtLine;
            obj.transform.parent = this.transform;
            obj.transform.localScale = new Vector3(1, 1, 1);
            obj.transform.localPosition = new Vector3(0, -i * .5f, 0);
            i++;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
