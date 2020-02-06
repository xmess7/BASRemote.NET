﻿using System;
using System.Threading.Tasks;
using BASRemote.Objects;

namespace BASRemote.Interfaces
{
    /// <summary>
    ///     Basic interface for running BAS functions.
    /// </summary>
    /// <typeparam name="TRunner">
    ///     Type that implements this interface.
    /// </typeparam>
    public interface IFunctionRunner<out TRunner>
    {
        /// <summary>
        ///     Call the BAS function and returns the runner object.
        /// </summary>
        /// <param name="functionName">
        ///     BAS function name as string.
        /// </param>
        /// <param name="functionParams">
        ///     BAS function arguments list.
        /// </param>
        /// <param name="onResult">
        ///     The function that will be called when the result is received.
        /// </param>
        /// <param name="onError">
        ///     The function that will be called when the error is received.
        /// </param>
        TRunner RunFunctionSync(string functionName, Params functionParams, Action<dynamic> onResult,
            Action<Exception> onError);

        /// <summary>
        ///     Call the BAS function asynchronously and get the result.
        /// </summary>
        /// <param name="functionName">
        ///     BAS function name as string.
        /// </param>
        /// <param name="functionParams">
        ///     BAS function arguments list.
        /// </param>
        /// <typeparam name="TResult">
        ///     The type of function result.
        /// </typeparam>
        Task<TResult> RunFunction<TResult>(string functionName, Params functionParams);

        /// <summary>
        ///     Call the BAS function asynchronously and get the result.
        /// </summary>
        /// <param name="functionName">
        ///     BAS function name as string.
        /// </param>
        /// <param name="functionParams">
        ///     BAS function arguments list.
        /// </param>
        Task<dynamic> RunFunction(string functionName, Params functionParams);
    }
}