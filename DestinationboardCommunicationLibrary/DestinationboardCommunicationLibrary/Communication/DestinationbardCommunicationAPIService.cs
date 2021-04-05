using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestinationboardCommunicationLibrary.Communication
{
    public class gRPCArgsRcv : EventArgs
    {
        public object Request { get; set; }
        public object Replay { get; set; }
    }


    public class DestinationbardCommunicationAPIService : DestinationbardCommunicationAPI.DestinationbardCommunicationAPIBase
    {

        public event EventHandler RecieveGetStaffsEvent;

        public event EventHandler RecieveRegistStaffEvent;

        public event EventHandler RecieveGetActionsEvent;

        public event EventHandler RecieveGetDestinationsEvent;

        public event EventHandler RecieveRegistActionPlanEvent;

        public event EventHandler RecieveRegistActionsEvent;

        public event EventHandler RecieveRegistDestinationsEvent;

        public event EventHandler RecieveActionPlanTableEvent;

        public event EventHandler RecieveStaffMasterEvent;

        public event EventHandler RecieveActionMasterEvent;

        public event EventHandler RecieveDestinationMasterEvent;



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


        #region [GetStaffs]APIリクエスト受付処理
        /// <summary>
        /// [GetStaffs]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<GetStaffsReply> GetStaffs(GetStaffsRequest request, ServerCallContext context)
        {
            var message = new GetStaffsReply();

            // ここに処理を書く
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveGetStaffsEvent != null)
            {
                RecieveGetStaffsEvent(this, ev);
            }

            return Task.FromResult(message);
        }
        #endregion

        #region [RegistStaff]APIリクエスト受付処理
        /// <summary>
        /// [RegistStaff]APIリクエスト受付処理
        /// APIの要求を受け付けた時に走る処理
        /// </summary>
        /// <param name="request">リクエスト</param>
        /// <param name="context">コンテキスト</param>
        /// <returns>リプライ</returns>
        public override Task<RegistStaffReply> RegistStaff(RegistStaffRequest request, ServerCallContext context)
        {
            var message = new RegistStaffReply();

            // ここに処理を書く
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveRegistStaffEvent != null)
            {
                RecieveRegistStaffEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveGetActionsEvent != null)
            {
                RecieveGetActionsEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveGetDestinationsEvent != null)
            {
                RecieveGetDestinationsEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveRegistActionPlanEvent != null)
            {
                RecieveRegistActionPlanEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveRegistActionsEvent != null)
            {
                RecieveRegistActionsEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveRegistDestinationsEvent != null)
            {
                RecieveRegistDestinationsEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveActionPlanTableEvent != null)
            {
                RecieveActionPlanTableEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveStaffMasterEvent != null)
            {
                RecieveStaffMasterEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveActionMasterEvent != null)
            {
                RecieveActionMasterEvent(this, ev);
            }

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
            gRPCArgsRcv ev = new gRPCArgsRcv();
            ev.Request = request;
            ev.Replay = message;


            if (RecieveDestinationMasterEvent != null)
            {
                RecieveDestinationMasterEvent(this, ev);
            }

            return Task.FromResult(message);
        }
        #endregion


    }
}
