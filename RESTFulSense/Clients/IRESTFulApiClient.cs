﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace RESTFulSense.Clients
{
    public interface IRESTFulApiClient
    {
        ValueTask<T> GetContentAsync<T>(string relativeUrl);
        ValueTask<T> GetContentAsync<T>(string relativeUrl, CancellationToken cancellationToken);
        ValueTask<string> GetContentStringAsync(string relativeUrl);

        ValueTask PostContentWithNoResponseAsync<T>(
            string relativeUrl,
            T content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask PostContentWithNoResponseAsync<T>(
            string relativeUrl,
            T content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<T> PostContentAsync<T>(
            string relativeUrl,
            T content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<T> PostContentAsync<T>(
            string relativeUrl,
            T content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<Stream> PostContentWithStreamResponseAsync<T>(
            string relativeUrl,
            T content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PostContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PostContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PostFormAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            CancellationToken cancellationToken = default(CancellationToken))
            where TContent : class;

        ValueTask<T> PutContentAsync<T>(
            string relativeUrl,
            T content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PutContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PutContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<T> PutContentAsync<T>(string relativeUrl);
        ValueTask<T> PutContentAsync<T>(string relativeUrl, CancellationToken cancellationToken);
        ValueTask<T> PatchContentAsync<T>(
            string relativeUrl,
            T content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PatchContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PatchContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<T> PatchContentAsync<T>(string relativeUrl);
        ValueTask<T> PatchContentAsync<T>(string relativeUrl, CancellationToken cancellationToken);
        ValueTask DeleteContentAsync(string relativeUrl);
        ValueTask DeleteContentAsync(string relativeUrl, CancellationToken cancellationToken);
        ValueTask<T> DeleteContentAsync<T>(string relativeUrl);
        ValueTask<T> DeleteContentAsync<T>(string relativeUrl, CancellationToken cancellationToken);
    }
}
