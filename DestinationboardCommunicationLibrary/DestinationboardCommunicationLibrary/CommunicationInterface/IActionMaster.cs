using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinationboardCommunicationLibrary.CommunicationInterface
{
	/// <summary>
	/// 行動マスター
	/// ActionMasterテーブルをベースに作成したインターフェースクラス
	/// 作成日：2021/03/28 作成者gohya
	/// </summary>
	interface IActionMaster
	{
		#region 行動ID[ActionID]プロパティ
		/// <summary>
		/// 行動ID[ActionID]インターフェースクラス
		/// </summary>
		String ActionID { get; set; }
		#endregion
		#region ソート順[SortOrder]プロパティ
		/// <summary>
		/// ソート順[SortOrder]インターフェースクラス
		/// </summary>
		Int32 SortOrder { get; set; }
		#endregion
		#region 行動名[ActionName]プロパティ
		/// <summary>
		/// 行動名[ActionName]インターフェースクラス
		/// </summary>
		String ActionName { get; set; }
		#endregion
		#region 作成日時[CreateDate]プロパティ
		/// <summary>
		/// 作成日時[CreateDate]インターフェースクラス
		/// </summary>
		DateTime CreateDate { get; set; }
		#endregion
		#region 作成者[CreateUser]プロパティ
		/// <summary>
		/// 作成者[CreateUser]インターフェースクラス
		/// </summary>
		String CreateUser { get; set; }
		#endregion
		#region 更新日時[UpdateDate]プロパティ
		/// <summary>
		/// 更新日時[UpdateDate]インターフェースクラス
		/// </summary>
		DateTime UpdateDate { get; set; }
		#endregion
		#region 更新者[UpdateUser]プロパティ
		/// <summary>
		/// 更新者[UpdateUser]インターフェースクラス
		/// </summary>
		String UpdateUser { get; set; }
		#endregion

	}
}
