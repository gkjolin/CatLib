﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */
 
using System;

namespace CatLib.API.INI
{

    public interface IINIResult
    {

        /// <summary>
        /// 当存储时
        /// </summary>
        void SetSaveCallback(Action<string> action);

        /// <summary>
        /// 获取一个ini配置
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        string Get(string section, string key, string def = null);

        /// <summary>
        /// 设定一个ini配置
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        void Set(string section, string key, string val);

        /// <summary>
        /// 移除一个配置
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        void Remove(string section, string key);

        /// <summary>
        /// 移除一个区块
        /// </summary>
        /// <param name="section"></param>
        void Remove(string section);

        /// <summary>
        /// 保存ini文件
        /// </summary>
        /// <returns></returns>
        void Save();

    }

}