using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinationboardCommunicationLibrary.CommunicationInterface
{
	interface IStaffMaster
	{
		#region 従業員ID[StaffID]プロパティ
		/// <summary>
		/// 従業員ID[StaffID]インターフェースクラス
		/// </summary>
		String StaffID { get; set; }
		#endregion
		#region 従業員名[StaffName]プロパティ
		/// <summary>
		/// 従業員名[StaffName]インターフェースクラス
		/// </summary>
		String StaffName { get; set; }
		#endregion
		#region 表示(True)/非表示(False)[Display]プロパティ
		/// <summary>
		/// 表示(True)/非表示(False)[Display]インターフェースクラス
		/// </summary>
		bool Display { get; set; }
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

	}
}
