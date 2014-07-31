using UnityEngine;
using System.Collections;

//論理テスト
public class Logic1 : MonoBehaviour
{
		bool r, g, b, monster;

		void Update ()
		{ 
				if (Input.GetKeyDown (KeyCode.Space)) {
						ChangeFlag ();
						//if (!b && !g || g && b || !r && !g && b) {	//カルノー図によって得た単純化された論理式
						if (!r && b || g && b || !r && !g && !b || !g && !b && r) {
								monster = true;
						} else {
								monster = false;
						}
						print ("RED=" + r + "  :GREEN=" + g + "   :BLUE=" + b + "  → 　MONSTER=" + monster);
				}
		}

		void ChangeFlag ()
		{
				r = Random.value > 0.5f ? true : false;
				g = Random.value > 0.5f ? true : false;
				b = Random.value > 0.5f ? true : false;
		}
}
