using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinationboardCommunicationLibrary.Communication
{
    public class DestinationbardCommunicationAPIService : DestinationbardCommunicationAPI.DestinationbardCommunicationAPIBase
    {
        public string HostName { get; set; } = "127.0.0.1";

        /// <summary>
        /// ポート番号
        /// </summary>
        public int Port { get; set; } = 552;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="hostname">ホスト名</param>
        /// <param name="port">ポート番号</param>
        public DestinationbardCommunicationAPIService(string hostname, int port)
        {
            // ホスト名のセット
            this.HostName = hostname;

            // ポート番号のセット
            this.Port = port;
        }

        public void Listen()
        {
            Server server = new Server
            {
                Services = { DestinationbardCommunicationAPI.BindService(this) },
                Ports = { new ServerPort(this.HostName, this.Port, ServerCredentials.Insecure) }
            };


            server.Start();
        }


        #region [RegstStaff]APIリクエスト受付処理
        /// <summary>
        /// [RegstStaff]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<RegstStaffReply> RegstStaff(RegstStaffRequest request, ServerCallContext context)
        {
            var message = new RegstStaffReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [DeleteStaff]APIリクエスト受付処理
        /// <summary>
        /// [DeleteStaff]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<DeleteStaffReply> DeleteStaff(DeleteStaffRequest request, ServerCallContext context)
        {
            var message = new DeleteStaffReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [GetActions]APIリクエスト受付処理
        /// <summary>
        /// [GetActions]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<GetActionsReply> GetActions(GetActionsRequest request, ServerCallContext context)
        {
            var message = new GetActionsReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [GetDestinations]APIリクエスト受付処理
        /// <summary>
        /// [GetDestinations]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<GetDestinationsReply> GetDestinations(GetDestinationsRequest request, ServerCallContext context)
        {
            var message = new GetDestinationsReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [RegistActionPlan]APIリクエスト受付処理
        /// <summary>
        /// [RegistActionPlan]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<RegistActionPlanReply> RegistActionPlan(RegistActionPlanRequest request, ServerCallContext context)
        {
            var message = new RegistActionPlanReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [RegistActions]APIリクエスト受付処理
        /// <summary>
        /// [RegistActions]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<RegistActionsReply> RegistActions(RegistActionsRequest request, ServerCallContext context)
        {
            var message = new RegistActionsReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [RegistDestinations]APIリクエスト受付処理
        /// <summary>
        /// [RegistDestinations]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<RegistDestinationsReply> RegistDestinations(RegistDestinationsRequest request, ServerCallContext context)
        {
            var message = new RegistDestinationsReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [ActionPlanTable]APIリクエスト受付処理
        /// <summary>
        /// [ActionPlanTable]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<ActionPlanTableReply> ActionPlanTable(ActionPlanTableRequest request, ServerCallContext context)
        {
            var message = new ActionPlanTableReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [StaffMaster]APIリクエスト受付処理
        /// <summary>
        /// [StaffMaster]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<StaffMasterReply> StaffMaster(StaffMasterRequest request, ServerCallContext context)
        {
            var message = new StaffMasterReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [ActionMaster]APIリクエスト受付処理
        /// <summary>
        /// [ActionMaster]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<ActionMasterReply> ActionMaster(ActionMasterRequest request, ServerCallContext context)
        {
            var message = new ActionMasterReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion

        #region [DestinationMaster]APIリクエスト受付処理
        /// <summary>
        /// [DestinationMaster]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<DestinationMasterReply> DestinationMaster(DestinationMasterRequest request, ServerCallContext context)
        {
            var message = new DestinationMasterReply();

            // ここに処理を書く

            return Task.FromResult(message);
        }
        #endregion


    }
}
