﻿using MediaBrowser.Model.Querying;
using MediaBrowser.Model.Devices;

namespace MediaBrowser.Controller.Security
{
    public interface IAuthenticationRepository
    {
        /// <summary>
        /// Creates the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        void Create(AuthenticationInfo info);

        /// <summary>
        /// Updates the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        void Update(AuthenticationInfo info);

        void Delete(AuthenticationInfo existing);

        /// <summary>
        /// Gets the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>QueryResult{AuthenticationInfo}.</returns>
        QueryResult<AuthenticationInfo> Get(AuthenticationInfoQuery query);

        DeviceOptions GetDeviceOptions(string deviceId);

        void UpdateDeviceOptions(string deviceId, DeviceOptions options);
    }
}
