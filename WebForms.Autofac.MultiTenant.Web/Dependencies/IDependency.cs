﻿namespace WebForms.Autofac.MultiTenant.Minimal.Dependencies
{
    /// <summary>
    /// Demonstration dependency interface that allows you to inspect the unique
    /// ID on a specific resolved instance of the dependency.
    /// </summary>
    public interface IDependency
    {
        /// <summary>
        /// Gets the unique instance ID for the dependency.
        /// </summary>
        /// <value>
        /// A <see cref="System.Guid"/> that indicates the unique ID for the
        /// instance.
        /// </value>
        string ConnectionString { get; }
        string TenantName { get; }
    }
}