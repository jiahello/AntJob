﻿using System;

namespace AntJob.Data
{
    /// <summary>任务参数</summary>
    public interface ITask
    {
        /// <summary>任务项编号</summary>
        Int32 ID { get; set; }

        /// <summary>开始。大于等于</summary>
        DateTime Start { get; set; }

        /// <summary>结束。小于</summary>
        DateTime End { get; set; }

        /// <summary>批大小</summary>
        Int32 BatchSize { get; set; }

        /// <summary>数据</summary>
        String Data { get; set; }
    }
}