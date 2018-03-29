using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySixthChallenge {
	public partial class Default : System.Web.UI.Page {
		
		protected void Page_Load(object sender, EventArgs e) {
			//INITIALIZE ARRAYS AND STATE ONLY ON FIRST TIME PAGE IS LOADED
			if(!Page.IsPostBack) {
				string[] assetNames = new string[0];
				int[] electionsRigged = new int[0];
				double[] averageSubterfuge = new double[0];
				ViewState.Add("Assets", assetNames);
				ViewState.Add("Elections", electionsRigged);
				ViewState.Add("Subterfuge", averageSubterfuge);
			}
		}

		protected void submitButton_Click(object sender, EventArgs e) {
			//INITIALIZE NEW ARRAYS FROM STATE AND RESIZE TO ADD NEW ELEMENTS FROM INPUT
			string[] assetNames = (string[])ViewState["Assets"];
			int[] electionsRigged = (int[])ViewState["Elections"];
			double[] averagesubterfuge = (double[])ViewState["Subterfuge"];
			Array.Resize(ref assetNames, assetNames.Length + 1);
			Array.Resize(ref electionsRigged, electionsRigged.Length + 1);
			Array.Resize(ref averagesubterfuge, averagesubterfuge.Length + 1);

			//ASSIGN VALUES FROM TEXT BOX ENTRY AS NEW ELEMENTS IN ARRAY
			assetNames[assetNames.Length - 1] = assetTextBox.Text;
			electionsRigged[electionsRigged.Length - 1] = int.Parse(electionsTextBox.Text);
			averagesubterfuge[averagesubterfuge.Length - 1] = double.Parse(subterfugeTextBox.Text);

			//UPDATE STATES TO INCLUDE NEWLY ADDED ELEMENTS
			ViewState["Assets"] = assetNames;
			ViewState["Elections"] = electionsRigged;
			ViewState["Subterfuge"] = averagesubterfuge;

			//PRINT RESULTS TO LABEL
			resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2}<br />Last Asset Added: {2}",
									electionsRigged.Sum(),
									averagesubterfuge.Average(),
									assetNames[assetNames.Length - 1]);
		}
	}
}