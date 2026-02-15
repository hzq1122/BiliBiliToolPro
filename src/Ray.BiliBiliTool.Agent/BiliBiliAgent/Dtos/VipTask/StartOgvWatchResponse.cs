namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos.VipTask;

public class StartOgvWatchResponse
{
    public string? closeType { get; set; }

    public string? showTime { get; set; }

    public WatchCountDownCfg? watch_count_down_cfg { get; set; }
}

public class WatchCountDownCfg
{
    public string? task_id { get; set; }

    public string? token { get; set; }

    /// <summary>
    /// 需要观看的毫秒数，通常为 600000（10分钟）
    /// </summary>
    public long milliseconds { get; set; }

    public string? complete_status_desc { get; set; }

    public string? count_down_status_desc { get; set; }
}
