using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTenthChallenge {
	public partial class Default : System.Web.UI.Page {

		//INITIALIZE PUBLIC VARIABLES TO BE USED
		string stringToReverse = "Dave Diehl";
		string reversedString = "";
		string secondToReverse = "Michael,Gob,Buster,Lindsay,George,Lucille";
		string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

		protected void Page_Load(object sender, EventArgs e) {

			//DISPLAY STRING TO BE REVERSED FOR COMPARISON
			initialStringToReverse.Text = stringToReverse;
			secondStringToReverse.Text = secondToReverse;
			initialStringToPad.Text = secondToReverse;
			puzzleLabel.Text = puzzle;
		}

		protected void reverseStringButton_Click(object sender, EventArgs e) {

			//SPLIT STRING INTO ARRAY
			string[] arr = stringToReverse.ToLower().Split(' ');

			//PASS EACH STRING ELEMENT INTO REVERSE FUNCTION
			reversedString += reverseString(arr[1]) + " ";
			reversedString += reverseString(arr[0]);

			//DISPLAY RESULT
			reverseStringResult.Text = reversedString;
		}

		protected void secondReverseButton_Click(object sender, EventArgs e) {

			//PASS STRING THROUGH REVERSE FUNCTION
			string reversed = secondReverse(secondToReverse);

			//DISPLAY RESULT
			secondReverseLabel.Text = reversed;
		}

		protected void padButton_Click(object sender, EventArgs e) {

			//PASS STRING INTO PAD FUNCTION
			string result = padString(secondToReverse).ToString();

			//DISPLAY RESULT
			padResultLabel.Text = result;
		}

		protected void puzzleButton_Click(object sender, EventArgs e) {
			string result = solvePuzzle(puzzle);
			puzzleResultLabel.Text = result;
		}

		protected string reverseString(string toReverse) {

			//INITIALIZE RETURN VARIABLE AND SPLIT PASSED STRING INTO NEW ARRAY
			string reversed = "";
			string[] arr = toReverse.Split();

			//ITERATE THROUGH NEWLY SPLIT ARRAY STARTING AT END POINT, CAPITALIZE ONLY LAST CHARACTER
			for(int i = toReverse.Length - 1; i >= 0; i--) {
				if(i == toReverse.Length - 1)
					reversed += toReverse[i].ToString().ToUpper();
				else
					reversed += toReverse[i];
			}
			return reversed;
		}

		protected string secondReverse(string toReverse) {

			//INITIALIZE REVERSED STRING, SPLIT PASSED STRING INTO ARRAY
			string reversed = "";
			string[] arr = toReverse.Split(',');

			//REASSEMBLE ARRAY INTO STRING IN REVERSE
			for (int i = arr.Length - 1; i >= 0; i--) {
				reversed += arr[i];
				if (i > 0)
					reversed += ",";
			}
			return reversed;
		}

		protected string padString(string toPad) {

			//INITIALIZE PADDED STRING, SPLIT PASSED STRING INTO ARRAY
			string[] arr = toPad.Split(',');
			string result = "";
			double padding;
			double padLeft = 0.0;

			//ADD PADDING TO EACH SIDE BASED ON STRING ELEMENT LENGTH
			for(int i = 0; i < arr.Length; i++) {
				padding = 14 - arr[i].Length;
				padLeft = padding / 2 + arr[i].Length;
				result += arr[i].PadLeft((int)padLeft, '*').PadRight(14, '*') + "<br />";
			}
			return result;
		}

		protected string solvePuzzle(string puzzle) {

			string result = "";
			//REMOVE TARGET TEXT FROM STRING, FORMAT TO LOWERCASE, REPLACE Z's WITH T's TO CORRECT
			int remove = puzzle.IndexOf('r');
			puzzle = puzzle.Remove(remove, 9).ToLower().Replace('z', 't');
			
			//DIVIDE INTO SUBSTRINGS TO CAPITALIZE FIRST LETTER
			string substring = puzzle.Substring(0, 1).ToUpper();
			string substring2 = puzzle.Substring(1, puzzle.Length - 1);

			return substring + substring2;
		}
	}
}

//StartsWith(), EndsWith(), Contains()
//IndexOf()
//Insert(index, string), Remove(index, int length)
//Substring(index, int length)
//Trim(), TrimStart(), TrimEnd()
//PadLeft(total width of pad, 'char'), PadRight(width of pad, 'char')
//ToUpper(), ToLower()
//Replace(string, string)
//Split()
//StringBuilder class/obj (name = new StringBuilder();) name.Append();
