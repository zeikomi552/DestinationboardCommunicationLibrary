﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinationboardCommunicationLibrary.CommunicationInterface
{
	/// <summary>
	/// 行先マスター
	/// DestinationMasterテーブルをベースに作成したインターフェースクラス
	/// 作成日：2021/03/28 作成者gohya
	/// </summary>
	interface IDestinationMaster
	{
		#region 行先ID[DestinationID]プロパティ
		/// <summary>
		/// 行先ID[DestinationID]インターフェースクラス
		/// </summary>
		String DestinationID { get; set; }
		#endregion
		#region ソート順[SortOrder]プロパティ
		/// <summary>
		/// ソート順[SortOrder]インターフェースクラス
		/// </summary>
		Int32 SortOrder { get; set; }
		#endregion
		#region 行先名[DestinationName]プロパティ
		/// <summary>
		/// 行先名[DestinationName]インターフェースクラス
		/// </summary>
		String DestinationName { get; set; }
		#endregion
		#region 行動ID[ActionID]プロパティ
		/// <summary>
		/// 行動ID[ActionID]インターフェースクラス
		/// </summary>
		String ActionID { get; set; }
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
