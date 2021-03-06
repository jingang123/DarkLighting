﻿using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// 消息提示
/// </summary>
public class Notification : MonoSingletion<Notification> {

    void Start()
    {
        TaskManager.Instance.OnGetEvent += GetPrintInfo;
        TaskManager.Instance.OnFinishEvent += finishPrintInfo;
        TaskManager.Instance.OnRewardEvent += rewardPrintInfo;
        TaskManager.Instance.OnCancelEvent += cancelPrintInfo;
    }

    public void GetPrintInfo(TaskEventArgs e)
    {
        print("接受任务" + e.taskID);
    }

    public void finishPrintInfo(TaskEventArgs e)
    {
        print("完成任务" + e.taskID);
        if (e.taskID=="T001")
        {
            PlayerPrefs.SetFloat("statue1", 1);
        }
        print("完成任务" + e.taskID);
        if (e.taskID == "T002")
        {
            PlayerPrefs.SetFloat("statue2", 1);
        }
        print("完成任务" + e.taskID);
        if (e.taskID == "T003")
        {
            PlayerPrefs.SetFloat("statue3", 1);
        }

    }

    public void rewardPrintInfo(TaskEventArgs e)
    {
        print("奖励物品" + e.id + "数量" + e.amount);
    }

    public void cancelPrintInfo(TaskEventArgs e)
    {
        print("取消任务" + e.taskID);
    }
}
