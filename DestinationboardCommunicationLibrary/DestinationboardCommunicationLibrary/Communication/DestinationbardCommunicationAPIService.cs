using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// gRPC受信時に発生させるイベント
/// </summary>
public class gRPCArgsRcv : EventArgs
{
    public object Request { get; set; } // リクエスト
    public object Replay { get; set; }  // リプライ
}


public class DestinationbardCommunicationAPIService : DestinationbardCommunicationAPI.DestinationbardCommunicationAPIBase
{

    // GetStaffsの受信イベントの作成
    public event EventHandler RecieveGetStaffsEvent;

    // RegistStaffの受信イベントの作成
    public event EventHandler RecieveRegistStaffEvent;

    // GetActionsの受信イベントの作成
    public event EventHandler RecieveGetActionsEvent;

    // RegistActionsの受信イベントの作成
    public event EventHandler RecieveRegistActionsEvent;

    // GetActionPlansの受信イベントの作成
    public event EventHandler RecieveGetActionPlansEvent;

    // RegistActionPlansの受信イベントの作成
    public event EventHandler RecieveRegistActionPlansEvent;

    // GetActionPlanの受信イベントの作成
    public event EventHandler RecieveGetActionPlanEvent;

    // RegistActionPlanの受信イベントの作成
    public event EventHandler RecieveRegistActionPlanEvent;

    // StaffMasterの受信イベントの作成
    public event EventHandler RecieveStaffMasterEvent;

    // ActionMasterの受信イベントの作成
    public event EventHandler RecieveActionMasterEvent;

    // DestinationMasterの受信イベントの作成
    public event EventHandler RecieveDestinationMasterEvent;

    // ActionPlanTableの受信イベントの作成
    public event EventHandler RecieveActionPlanTableEvent;



    /// <summary>
    /// ホスト名
    /// </summary>
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

    /// <summary>
    /// 受信受付
    /// </summary>
    public void Listen()
    {
        Server server = new Server
        {
            Services = { DestinationbardCommunicationAPI.BindService(this) },
            Ports = { new ServerPort(this.HostName, this.Port, ServerCredentials.Insecure) }
        };

        // スタート
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
        if (RecieveGetActionsEvent != null)
        {
            RecieveGetActionsEvent(this, ev);
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
        if (RecieveRegistActionsEvent != null)
        {
            RecieveRegistActionsEvent(this, ev);
        }

        return Task.FromResult(message);
    }
    #endregion

    #region [GetActionPlans]APIリクエスト受付処理
    /// <summary>
    /// [GetActionPlans]APIリクエスト受付処理
    /// APIの要求を受け付けた時に走る処理
    /// </summary>
    /// <param name="request">リクエスト</param>
    /// <param name="context">コンテキスト</param>
    /// <returns>リプライ</returns>
    public override Task<GetActionPlansReply> GetActionPlans(GetActionPlansRequest request, ServerCallContext context)
    {
        var message = new GetActionPlansReply();

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
        if (RecieveGetActionPlansEvent != null)
        {
            RecieveGetActionPlansEvent(this, ev);
        }

        return Task.FromResult(message);
    }
    #endregion

    #region [RegistActionPlans]APIリクエスト受付処理
    /// <summary>
    /// [RegistActionPlans]APIリクエスト受付処理
    /// APIの要求を受け付けた時に走る処理
    /// </summary>
    /// <param name="request">リクエスト</param>
    /// <param name="context">コンテキスト</param>
    /// <returns>リプライ</returns>
    public override Task<RegistActionPlansReply> RegistActionPlans(RegistActionPlansRequest request, ServerCallContext context)
    {
        var message = new RegistActionPlansReply();

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
        if (RecieveRegistActionPlansEvent != null)
        {
            RecieveRegistActionPlansEvent(this, ev);
        }

        return Task.FromResult(message);
    }
    #endregion

    #region [GetActionPlan]APIリクエスト受付処理
    /// <summary>
    /// [GetActionPlan]APIリクエスト受付処理
    /// APIの要求を受け付けた時に走る処理
    /// </summary>
    /// <param name="request">リクエスト</param>
    /// <param name="context">コンテキスト</param>
    /// <returns>リプライ</returns>
    public override Task<GetActionPlanReply> GetActionPlan(GetActionPlanRequest request, ServerCallContext context)
    {
        var message = new GetActionPlanReply();

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
        if (RecieveGetActionPlanEvent != null)
        {
            RecieveGetActionPlanEvent(this, ev);
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
        if (RecieveRegistActionPlanEvent != null)
        {
            RecieveRegistActionPlanEvent(this, ev);
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
        if (RecieveDestinationMasterEvent != null)
        {
            RecieveDestinationMasterEvent(this, ev);
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

        gRPCArgsRcv ev = new gRPCArgsRcv();
        ev.Request = request;
        ev.Replay = message;

        // nullチェック
        if (RecieveActionPlanTableEvent != null)
        {
            RecieveActionPlanTableEvent(this, ev);
        }

        return Task.FromResult(message);
    }
    #endregion


}