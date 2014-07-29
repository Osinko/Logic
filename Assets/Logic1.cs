using UnityEngine;
using System.Collections;

public class Logic1 : MonoBehaviour
{

		void Start ()
		{
				bool a, b, c, d, e, f, g, h;
				a = true;
				b = true;
				c = true;
				d = false;
				e = false;
				f = true;
				g = false;
				h = false;

				print ("false");
				print (false);
				print (false);
				print (false);
				print (false);
				print ("\n");

				print ("AND");
				print (a && b);
				print (c && d);
				print (e && f);
				print (g && h);
				print ("\n");

				print ("A←B");
				print (a && !b);
				print (c && !d);
				print (e && !f);
				print (g && !h);
				print ("\n");

				print ("A");
				print (a);
				print (c);
				print (e);
				print (g);
				print ("\n");

				print ("!A&&B");
				print (!a && b);
				print (!c && d);
				print (!e && f);
				print (!g && h);
				print ("\n");

				print ("B");
				print (b);
				print (d);
				print (f);
				print (h);
				print ("\n");

				print ("A!=B");
				print (a != b);
				print (c != d);
				print (e != f);
				print (g != h);
				print ("\n");

				print ("A||B");
				print (a || b);
				print (c || d);
				print (e || f);
				print (g || h);
				print ("\n");

				print ("!(A||B)");
				print (!(a || b));
				print (!(c || d));
				print (!(e || f));
				print (!(g || h));
				print ("\n");

				print ("A==B");
				print (a == b);
				print (c == d);
				print (e == f);
				print (g == h);
				print ("\n");

				print ("!B");
				print (!b);
				print (!d);
				print (!f);
				print (!h);
				print ("\n");

				print ("A||!B");
				print (a || !b);
				print (c || !d);
				print (e || !f);
				print (g || !h);
				print ("\n");
		}

}
