using System;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace solCommon.Web.UI.DataGrid
{
	/// <summary>
	/// CheckBoxColumn Derives from DataGrid Column
	/// </summary>
	public class DGCheckBoxColumn : DataGridColumn
	{
		public DGCheckBoxColumn(): base()
		{
		}
  
		public override void InitializeCell(TableCell cell, 
			int columnIndex, ListItemType itemType) 
		{
			//let the base class initialize the cell
			base.InitializeCell(cell, columnIndex, itemType);

			if(    itemType == ListItemType.EditItem || 
				itemType == ListItemType.Item || 
				itemType == ListItemType.AlternatingItem || 
				itemType == ListItemType.SelectedItem ||
				itemType == ListItemType.Header)
			{

				CheckBox checkbox = new CheckBox();
				//assign an ID that we can use to find the control later
				//we don't want to add a normal checkbox to the header.
				checkbox.ID = (itemType==ListItemType.Header)? "checkboxHead": "checkboxCol";

				cell.Controls.Add(checkbox);
			}
		}
		public Int32[] SelectedIndexes 
		{
			get 
			{
				ArrayList selectedIndexList = new ArrayList();
				//iterate each DataGridItem and find our checkbox
				foreach( DataGridItem item in this.Owner.Items ) 
				{
					CheckBox chkBox = 
						(CheckBox) item.FindControl("checkboxCol");
     
					//If it's selected then add it to our ArrayList
					if ( chkBox != null && chkBox.Checked )  
					{
						selectedIndexList.Add( item.ItemIndex );
					} 
     
				}
				return (Int32[])selectedIndexList.ToArray(typeof( 
					System.Int32 ) );
			}
		}

		public object[] SelectedDataKeys 
		{
			get 
			{
				//Just iterate each of the selectedindexes and 
				//match it up to the datakey field
				ArrayList dataKeyList = new ArrayList();
				//make sure the datakeys have some values
				if(this.Owner.DataKeys.Count > 0)
				{
					foreach( Int32 selectedIndex in SelectedIndexes ) 
					{
     
						object DataKey = 
							(this.Owner.DataKeys[selectedIndex].ToString());
						dataKeyList.Add(DataKey);
					}
				}
				return (object[])dataKeyList.ToArray(typeof( object ) );
			}
   
		}

		public static void RegisterClientCheckEvents(Page pg, string formID)
		{
			string strCol = GetCheckColScript();
			string strHead = GetCheckHeadScript();

			if(!pg.IsClientScriptBlockRegistered("clientScriptCheckAll"))
				pg.RegisterClientScriptBlock("clientScriptCheckAll", strHead.Replace("[frmID]",formID));
			if(!pg.IsClientScriptBlockRegistered("clientScriptCheckChanged"))
				pg.RegisterClientScriptBlock("clientScriptCheckChanged", strCol.Replace("[frmID]",formID));

			RegisterAttributes(pg);

		}

		private static void RegisterAttributes(Control ctrl)
		{
			foreach (Control wc in ctrl.Controls)
			{
				try
				{
					if ( wc.HasControls() )
						RegisterAttributes(wc);

					CheckBox chk = (CheckBox)wc;
					if (chk != null && chk.ID == "checkboxCol")
					{
						chk.Attributes.Add("onclick","CheckChanged()");
					}
					else if ( chk != null && chk.ID == "checkboxHead")
					{
						chk.Attributes.Add("onclick","CheckAll(this)");
					}
				}
				catch
				{
				}
			}
		}

		private static string GetCheckColScript()
		{
			string strScript;
			strScript= " <script language=JavaScript>";
			strScript+=" function CheckAll( checkAllBox )";
			strScript+=" {";
			strScript+=" var frm = document.[frmID];";
			strScript+="  var ChkState=checkAllBox.checked;";
			strScript+="  for(i=0;i< frm.length;i++)";
			strScript+="  {";
			strScript+="         e=frm.elements[i];";
			strScript+="        if(e.type=='checkbox' && e.name.indexOf('checkboxCol') != -1)";
			strScript+="            e.checked= ChkState ;";
			strScript+="  }";
			strScript+=" }";
			strScript+="  </script>";

			return strScript;
		}

		private static string GetCheckHeadScript()
		{
			string strScript="";
			strScript= "<script language=JavaScript>";
			strScript+="function CheckChanged()";
			strScript+="{";
			strScript+="  var frm = document.[frmID];";
			strScript+="  var boolAllChecked;";
			strScript+="  boolAllChecked=true;";
			strScript+="  for(i=0;i< frm.length;i++)";
			strScript+="  {";
			strScript+="    e=frm.elements[i];";
			strScript+="  if ( e.type=='checkbox' && e.name.indexOf('checkboxCol') != -1 )";
			strScript+="      if(e.checked== false)";
			strScript+="      {";
			strScript+="         boolAllChecked=false;";
			strScript+="         break;";
			strScript+="      }";
			strScript+="  }";
			strScript+="  for(i=0;i< frm.length;i++)";
			strScript+="  {";
			strScript+="    e=frm.elements[i];";
			strScript+="    if ( e.type=='checkbox' && e.name.indexOf('checkboxHead') != -1 )";
			strScript+="    {";
			strScript+="      if( boolAllChecked==false)";
			strScript+="         e.checked= false ;";
			strScript+="      else";
			strScript+="         e.checked= true;";
			strScript+="      break;";
			strScript+="    }";
			strScript+="   }";
			strScript+=" }";
			strScript+=" </script>";

			return strScript;
		}
	}
}
