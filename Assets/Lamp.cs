using UnityEngine;
using System.Collections;

public class Lamp : MonoBehaviour
{
		public Animator anim, monster;
		public Light blueLight, yellowLight;
		public float timeSpan;
	
		float timeCount;
		bool blue, yellow, button;
	
		void Update ()
		{
				timeCount += Time.deltaTime;
				if (timeCount > timeSpan) {
						timeCount %= timeSpan;
						ChangeLamp ();

						//今回はココがテーマ
						//if (!blue && yellow || !blue && !yellow || blue && yellow) {
						if (!blue || yellow) {
								anim.SetTrigger ("elevatorTrig");
								StartCoroutine (MonsterCrouch ());
								//メカニムに設定したトリガーをstringで指定して起動する
								//メカニム側はanyStateではなく新しく自分でつくったNewStateでトラジションを双方につなげ作る}
						}
				}
		}

		//コルーチンで再生タイムを微調整
		float startDelay = 0.2f;
		float crouchStepDelay = 0.8f;
		public IEnumerator MonsterCrouch ()
		{
				WaitForSeconds stdelay = new WaitForSeconds (startDelay);
				WaitForSeconds delay = new WaitForSeconds (crouchStepDelay);
				yield return stdelay;
				monster.SetBool ("crouch", true);
				yield return delay;
				monster.SetBool ("crouch", false);
		}

		void ChangeLamp ()
		{
				blue = Random.value > 0.5f ? true : false;
				yellow = Random.value > 0.5f ? true : false;

				blueLight.enabled = blue;
				yellowLight.enabled = yellow;
		}
}
